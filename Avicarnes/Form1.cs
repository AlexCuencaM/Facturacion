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
            Busqueda search = FactoryDeBusqueda.crear(campo, datosCliente, criterio);
            datosCliente = search.buscarCliente(datosCliente);
            search.asignacionDeCampos(labelDireccionCliente, labelEstadoDePago, labelTelefono, campo2);
            cliente = datosCliente;//Asignacion de los datos de cliente 
        }
        private void operacionesDeExcepcion()
        {
            MessageBox.Show("Escriba números");
            textBoxIdCliente.Text = "";
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            loadHeader();
            cargarDatosEmpresa();
            cargarTelf();
        }
        /// <summary>
        /// Cargar Los datos del encabezado a la aplicación
        /// </summary>
        private void loadHeader()
        {
            CargaDelEncabezado fact = new CargaDelEncabezado(labelIdPedido, labelFecha);
            CargaDeDatos<FacturaDAO> factura = fact;
            factura.cargar(new FacturaDAO(conexion, this.factura));
            this.factura = fact.Factura; // Para asignar valores de factura.
        }      

        private void cargarDatosEmpresa()
        {
            CargaDeDatos<EmpresaDAO> empresa = new CargarDatosEmpresa(labelNombreEmpresa, labelDireccionEmpresa);
            empresa.cargar(new EmpresaDAO(conexion, factura));                      
        }

        private void cargarTelf()
        {
            CargaDeDatos<Telefono> telefono = new CargaTelefonoEmpresa(labelTelfonoDeEmpresa);
            telefono.cargar(new TelefonoEmpresaDAO(conexion));            
        }               
        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(cliente.getId().ToString() +  " " + cliente.getNombre() + " " +
                             cliente.getEstado()  + " " + cliente.getDireccion() + " " +
                             cliente.getTelf());
            MessageBox.Show(factura.Id.ToString()  + " " + factura.Fecha);
        }
    }
}