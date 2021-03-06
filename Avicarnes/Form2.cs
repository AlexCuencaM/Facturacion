﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Avicarnes
{
    public partial class Form2 : Form
    {
        private List<Factura> facturas = new List<Factura>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Telefono> telefonos = new List<Telefono>();
        private Pedido pedido;

        public Form2(Pedido pedido)
        {
            this.pedido = pedido;
            initListas(pedido);
            InitializeComponent();
        }
        private void initListas(Pedido pedido)
        {            
            facturas.Add(pedido.Factura);
            clientes.Add(pedido.Factura.Cliente);
            telefonos.Add(pedido.Factura.Cliente.Telf);
        }

        private void Form2_Load(object sender, EventArgs e)
        {            
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Avicarnes.Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            origenes();
            this.reportViewer1.RefreshReport();
        }

        private void origenes()
        {
            origenCliente();
            origenProducto();            
        }
        private void origenProducto()
        {
            agregarData("Producto", pedido.DescripcionProductos);
            agregarData("ProductoId", getCodigo());
            agregarData("LineaProducto", pedido.Productos);
        }
        private void origenCliente()
        {
            agregarData("FacturaProducto", facturas);
            agregarData("ClienteFactura", clientes);
            agregarData("ClienteTelefono", telefonos);
        }
        private void agregarData <T>(string nombre,List<T> lista)
        {
            ReportDataSource rds1 = new ReportDataSource(nombre, lista);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
        }
        private List<Producto> getCodigo()
        {
            List<Producto> codigo = new List<Producto>();            
            foreach (DescripcionProducto i in pedido.DescripcionProductos)            
                codigo.Add(i.NumeroSerie);                                      
            return codigo;            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }
    }
}