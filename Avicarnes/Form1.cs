using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public partial class Form1 : Form
    {
        private OracleConnection conexion;              
        private DelegadoCliente cliente;
        private Factura factura;

        public Form1()
        {
            conexion = new OracleConnection("DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ADMINISTRADOR;PASSWORD=avicarnes");            
            factura = new Factura();
            
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {        
            if (textBoxCliente.Focused)                
                operacionDatosCliente(textBoxCliente,textBoxIdCliente,BuscarPor.NOMBRE);
        }        
        
        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIdCliente.Focused)                 
                    operacionDatosCliente(textBoxIdCliente, textBoxCliente,BuscarPor.ID);
            }
            catch (FormatException)
            {
                operacionesDeExcepcion();
                textBoxIdCliente.Text = "";
            }           
        }

        /// <summary>
        /// Método que realiza la búsqueda de pedidos por nombre o por id
        /// </summary>
        /// <param name="campo">Campo que indica que tipo de busqueda instanciar</param>
        /// <param name="campo2">Campo que se rellena por la busqueda del parámetro campo</param>
        /// <param name="criterio">Puede ser nombre o id</param>
        private void operacionDatosCliente(TextBox campo, TextBox campo2, BuscarPor criterio)
        {
            DelegadoCliente datosCliente = new DelegadoCliente(conexion);           
            BusquedaDual search = FactoryDeBusqueda.crear(campo, datosCliente, criterio);
            datosCliente = search.buscarCliente(datosCliente);
            search.asignacionDeCampos(labelDireccionCliente, labelEstadoDePago, labelTelefono, campo2);
            cliente = datosCliente;//Asignacion de los datos de cliente 
        }
        private void operacionesDeExcepcion()
        {
            MessageBox.Show("Escriba números");
            
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            loadHeader();
            loadDatosEmpresa();
            loadTelf();
        }
        /// <summary>
        /// Cargar Los datos del encabezado a la aplicación
        /// </summary>
        private void loadHeader()
        {
            CargaDelEncabezado fact = new CargaDelEncabezado(labelIdPedido, labelFecha);
            CargaDeDatos<Label> factura = fact;
            factura.cargar(new FacturaDAO(conexion, this.factura));
            this.factura = fact.Factura; // Para asignar valores de factura.
        }      

        private void loadDatosEmpresa()
        {
            CargaDeDatos<Label> empresa = new CargarDatosEmpresa(labelNombreEmpresa, labelDireccionEmpresa);
            empresa.cargar(new EmpresaDAO(conexion, factura));                      
        }

        private void loadTelf()
        {
            CargaDeDatos<Label> telefono = new CargaTelefonoEmpresa(labelTelfonoDeEmpresa);
            telefono.cargar(new TelefonoEmpresaDAO(conexion));            
        }               
        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(cliente.getId().ToString() +  " " + cliente.getNombre() + " " +
                             cliente.getEstado()  + " " + cliente.getDireccion() + " " +
                             cliente.getTelf());
            MessageBox.Show(factura.Id.ToString()  + " " + factura.Fecha);
            string[] a = { "codigo", "descripcione", "1", "2", "3", "4", "5","6" };
            dataGridViewProducto.Rows.Add(a);
        }
        
        private void dataGridViewProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            
            
            switch (e.ColumnIndex)
            {
                case 0://Codigo, RF-008
                    dataGridViewProducto.CurrentRow.Cells[6].ReadOnly = true;
                    codigo();
                    break;
                
                case 3://Peso, RF-009
                    subtotal();
                    
                    break;
                case 6://Porcentaje, RF-010
                    total();                    
                    break;
                default:                    
                    break;

            }
        }

        private void codigo()
        {
            try
            {
                loadProducto();
            }
            catch(FormatException)
            {
                operacionesDeExcepcion();
                dataGridViewProducto.CurrentRow.Cells[0].Value = "";
            }
            
        }

        SubPlantilla product;
        private void loadProducto()
        {
            CargaDeDatos<DataGridViewRow> cargarProducto = new CargaDeProducto(dataGridViewProducto.CurrentRow);
            product = new ProductoDAO(conexion, Convert.ToInt32(dataGridViewProducto.CurrentRow.Cells[0].Value));            
            cargarProducto.cargar(product);

            
        }

        private void subtotal()
        {
            //Validar
            CargaDeDatos<DataGridViewRow> cargarSubtotal = new CargaSubtotalProducto(dataGridViewProducto.CurrentRow);
            SubPlantilla producto = new SubtotalProductoDAO(conexion);
            cargarSubtotal.cargar(producto);

            CargaDeDatos<DataGridViewRow> cargartotal = new CargarTotalProducto(dataGridViewProducto.CurrentRow);
            SubPlantilla product = new TotalProductoDAO(conexion);
            cargartotal.cargar(product);

            dataGridViewProducto.CurrentRow.Cells[6].ReadOnly = false;                                    
        }

        private void total()
        {
            CargaDeDatos<DataGridViewRow> cargartotal = new CargarTotalProducto(dataGridViewProducto.CurrentRow);
            SubPlantilla producto = new TotalProductoDAO(conexion);
            cargartotal.cargar(producto);
            //dataGridViewProducto.CurrentRow.Cells[7].Value = "$12.00";
        }
    }
}