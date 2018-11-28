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
            
            if (textBoxCliente.Focused )
            {
                DelegadoCliente pedidoPorNombre = new DelegadoCliente(conexion);
                pedidoPorNombre = condicionDeSelectPorNombre(pedidoPorNombre);
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
                    pedidoPorId = condicionDeSelectPorId(pedidoPorId);
                    presentarDatosPor(pedidoPorId, textBoxCliente, pedidoPorId.getNombre());
                    cliente = pedidoPorId;
                }
            }
            catch (FormatException)
            {
                operacionesDeExcepcion();
            }           
        }

        private DelegadoCliente condicionDeSelectPorId(DelegadoCliente id)
        {
            if (textBoxIdCliente.Text != "")
                id.select(id: Convert.ToInt32(textBoxIdCliente.Text));
            else
                id.select();
            return id;
        }

        private DelegadoCliente condicionDeSelectPorNombre(DelegadoCliente nombre)
        {
            if (textBoxCliente.Text != "")
                nombre.select(nombre: textBoxCliente.Text);
            else
                nombre.select();
            return nombre;
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
