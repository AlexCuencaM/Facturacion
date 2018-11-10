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
        private DelegadoCliente pedidoPorNombre;
        private DelegadoCliente pedidoPorId;
        private FacturaDAO factura;
        public Form1()
        {
            conexion = new OracleConnection("DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ADMINISTRADOR;PASSWORD=avicarnes");
            pedidoPorNombre = new DelegadoCliente(conexion);
            pedidoPorId = new DelegadoCliente(conexion);
            factura = new FacturaDAO(conexion);
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBoxCliente.Focused )
            {
                condicionDeSelectPorNombre();
                presentarDatosPor(pedidoPorNombre, textBoxIdCliente, "" + pedidoPorNombre.getId());
            }         
        }

        private void condicionDeSelectPorNombre()
        {
            if (textBoxCliente.Text != "")
                pedidoPorNombre.select(nombre: textBoxCliente.Text);
            else
                pedidoPorNombre.select();
        }
        
        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIdCliente.Focused)
                {
                    condicionDeSelectPorId();
                    presentarDatosPor(pedidoPorId, textBoxCliente, pedidoPorId.getNombre());
                }
            }
            catch (FormatException)
            {
                operacionesDeExcepcion();
            }           
        }

        private void condicionDeSelectPorId()
        {
            if (textBoxIdCliente.Text != "")
                pedidoPorId.select(id: Convert.ToInt32(textBoxIdCliente.Text));

            else
                pedidoPorId.select();
            
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
        }
        private void cargarHeader()
        {
            cargarDatosEmpresa();
            obtenerHeader();
            
        }
        private void obtenerHeader()
        {
            Plantilla<FacturaDAO> fact = new FacturaDAO(conexion);
            fact.select(0,"");
            FacturaDAO factura = (FacturaDAO)fact;
            presentarDatos1(factura);
        }

        private void presentarDatos1(FacturaDAO factura)
        {
            labelIdPedido.Text = "Nota de Venta:\n\n"+ " " + factura.Factura.Id;
            labelFecha.Text = "Fecha:\n\n" + "  " + factura.Factura.Fecha;
        }
        private void cargarDatosEmpresa()
        {
            Plantilla<EmpresaDAO> datosEmpresa = new EmpresaDAO(conexion);
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

        private void presentarDatos(TelefonoEmpresaDAO telefono)
        {
            labelTelfonoDeEmpresa.Text += "  " + telefono.Persona.Cliente.Telf.presentarTelf();
        }

        private void presentarDatos(EmpresaDAO dato)
        {
            labelNombreEmpresa.Text = dato.Factura.NombreEmpresa;
            labelDireccionEmpresa.Text = dato.Factura.DireccionEmpresa;
        }

        private void presentarDatosPor(DelegadoCliente pedido,TextBox criterio,string campo)
        {
            criterio.Text = campo;
            labelDireccionCliente.Text = "Direccion: " + pedido.getDireccion();
            labelEstadoDePago.Text = "Estado: " + pedido.getEstado();
            if (criterio.Text == "0")
                criterio.Text = "";
            labelTelefono.Text ="Teléfono(s): " + pedido.getTelf();
        }
    
        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no agregada :(");
        }
    }
}
