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

        private void operacionDatosCliente(TextBox campo, TextBox campo2, BuscarPor criterio)
        {
            DelegadoCliente pedidoPor = new DelegadoCliente(conexion);           
            Busqueda search = FactoryDeBusqueda.crear(campo, pedidoPor, criterio);
            pedidoPor = search.buscarCliente(pedidoPor);
            search.test(labelDireccionCliente, labelEstadoDePago, labelTelefono, campo2);
            cliente = pedidoPor;
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
        private void loadHeader()
        {
            CargaDelEncabezado fact = new CargaDelEncabezado(labelIdPedido, labelFecha);
            CargaDeDatos<FacturaDAO> factura = fact;
            factura.cargar(new FacturaDAO(conexion, this.factura));
            this.factura = fact.Factura;
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