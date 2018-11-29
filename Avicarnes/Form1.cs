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
            {
                DelegadoCliente pedidoPorNombre = new DelegadoCliente(conexion);
                Busqueda search = new BusquedaPorNombre(textBoxCliente, pedidoPorNombre);
                pedidoPorNombre = search.buscarCliente(pedidoPorNombre); 
                presentarDatosPor(pedidoPorNombre, textBoxIdCliente, "" + pedidoPorNombre.getId());
                cliente = pedidoPorNombre;
            }         

        }
        
        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIdCliente.Focused)
                {
                    DelegadoCliente pedidoPorId = new DelegadoCliente(conexion);
                    Busqueda search = new BusquedaPorId(textBoxIdCliente, pedidoPorId);
                    pedidoPorId = search.buscarCliente(pedidoPorId);
                    presentarDatosPor(pedidoPorId, textBoxCliente, pedidoPorId.getNombre());
                    cliente = pedidoPorId;
                }
            }
            catch (FormatException)
            {
                operacionesDeExcepcion();
            }           
        }

        private void presentarDatosPor(DelegadoCliente pedido, TextBox criterio, string campo)
        {
            criterio.Text = campo;
            if (criterio.Text == "0")
                criterio.Text = ""; 

            labelDireccionCliente.Text = "Direccion: " + pedido.getDireccion();
            labelEstadoDePago.Text = "Estado: " + pedido.getEstado();
            labelTelefono.Text = "Teléfono(s): " + pedido.getTelf();
        }        

       
        private void operacionesDeExcepcion()
        {
            MessageBox.Show("Escriba números");
            textBoxIdCliente.Text = "";
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cargarHeader();
            cargarDatosEmpresa();

        }
        
        private void cargarHeader()
        {
            Plantilla<FacturaDAO> fact = new FacturaDAO(conexion,this.factura);
            fact.select(0,"");
            FacturaDAO factura = (FacturaDAO)fact;
            presentarDatos(factura);
            this.factura = factura.Factura;
        }    
        private void cargarDatosEmpresa()
        {
            Plantilla<EmpresaDAO> datosEmpresa = new EmpresaDAO(conexion,factura);
            datosEmpresa.select(0, "");
            EmpresaDAO dato = (EmpresaDAO)datosEmpresa;
            presentarDatos(dato);
            cargarTelf();
        }
        private void cargarTelf()
        {
            Plantilla<Telefono> telf = new TelefonoEmpresaDAO(conexion);
            telf.select(0, "");
            TelefonoEmpresaDAO datoTelf = (TelefonoEmpresaDAO)telf;
            presentarDatos(datoTelf);
        }

        private void presentarDatos(FacturaDAO factura)
        {
            labelIdPedido.Text = "Nota de Venta:\n\n" + " " + factura.Factura.Id;
            labelFecha.Text = "Fecha:\n\n" + "  " + factura.Factura.Fecha;
        }
        private void presentarDatos(TelefonoEmpresaDAO telefono)
        {
            labelTelfonoDeEmpresa.Text += "  " + telefono.Persona.Cliente.Telf.presentarTelf();
        }

        private void presentarDatos(EmpresaDAO dato)
        {
            labelNombreEmpresa.Text = dato.Factura.NombreEmpresa;
            labelDireccionEmpresa.Text = dato.Factura.DireccionEmpresa;
        } 
    
        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no agregada :(");
        }
    }
}