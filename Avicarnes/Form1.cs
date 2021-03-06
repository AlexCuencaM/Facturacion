﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public partial class Form1 : Form
    {
        private OracleConnection conexion;                      
        private Factura factura;
        public Form1()
        {          
            conexion = new OracleConnection("DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID=ADMINISTRADOR;PASSWORD=avicarnes");            
            factura = new Factura();
            factura.Cliente = new Cliente();
            factura.Cliente.crearTelefono();
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {        
            if (textBoxCliente.Focused)                
                operacionDatosCliente(textBoxCliente,textBoxIdCliente,BuscarPor.NOMBRE);
        }        
        
        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {           
            if (textBoxIdCliente.Focused)                 
                operacionDatosCliente(textBoxIdCliente, textBoxCliente,BuscarPor.ID);           
        }

        /// <summary>
        /// Método que realiza la búsqueda de pedidos por nombre o por id
        /// </summary>
        /// <param name="campo">Campo que indica que tipo de busqueda instanciar</param>
        /// <param name="campo2">Campo que se rellena por la busqueda del parámetro campo</param>
        /// <param name="criterio">Puede ser nombre o id</param>
        private void operacionDatosCliente(TextBox campo, TextBox campo2, BuscarPor criterio)//RF-002
        {
            DelegadoCliente datosCliente = new DelegadoCliente(conexion);           
            BusquedaDual search = FactoryDeBusqueda.crear(campo, datosCliente, criterio);
            datosCliente = search.buscarCliente(datosCliente);
            search.asignacionDeCampos(labelDireccionCliente, labelEstadoDePago, labelTelefono, campo2);            
            factura.Cliente = datosCliente.Persona().Cliente;
        }
        private void operacionesDeExcepcion()
        {
            MessageBox.Show("Escriba números");            
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            //RF-001
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
            Pedido pedido = new Pedido();
            pedido = pedido.listas(dataGridViewProducto.Rows);
            pedido.Factura = factura;        
            Form2 form = new Form2(pedido);         
            form.Show();          
        }
        
        private void dataGridViewProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {                        
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
            CargaDeDatos<DataGridViewRow> cargarProducto = new CargaDeProducto(dataGridViewProducto.CurrentRow);
            PlantillaCliente<LineaProducto> product = new ProductoDAO(conexion,dataGridViewProducto.CurrentRow);            
            cargarProducto.cargar(product);
            subtotal();
            total();
        }
        private void subtotal()
        {            
            CargaDeDatos<DataGridViewRow> cargarSubtotal = new CargaSubtotalProducto(dataGridViewProducto.CurrentRow);
            PlantillaCliente<LineaProducto> producto = new SubtotalProductoDAO(conexion);
            cargarSubtotal.cargar(producto);
            total();
            dataGridViewProducto.CurrentRow.Cells[6].ReadOnly = false;                                    
        }

        private void total()
        {
            CargaDeDatos<DataGridViewRow> cargartotal = new CargarTotalProducto(dataGridViewProducto.CurrentRow);
            PlantillaCliente<LineaProducto> producto = new TotalProductoDAO(conexion);
            cargartotal.cargar(producto);            
        }

        private void button1_Click(object sender, EventArgs e)//CU-005, RF-017
        {
            textBoxIdCliente.Text = "";
            dataGridViewProducto.Rows.Clear();
            operacionDatosCliente(textBoxIdCliente, textBoxCliente, BuscarPor.ID);
        }
    }
}