using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Avicarnes
{
    public partial class Form2 : Form
    {        
        List<DescripcionProducto> lista;
        List<LineaProducto> linea;
        List<Factura> facturas;
        List<Cliente> clientes;
        public Form2(List<DescripcionProducto> product, List<LineaProducto> linea,Factura factura)
        {
            initListas(factura);            
            lista = product;
            this.linea = linea;
            InitializeComponent();
        }
        private void initListas(Factura factura)
        {
            facturas = new List<Factura>();
            clientes = new List<Cliente>();
            facturas.Add(factura);
            clientes.Add(factura.Cliente);
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
            agregarData("Producto", lista);
            agregarData("ProductoId", getCodigo());
            agregarData("LineaProducto", linea);
            agregarData("FacturaProducto",facturas);
            agregarData("ClienteFactura",clientes);
        }
        private void agregarData <T>(string nombre,List<T> lista)
        {
            ReportDataSource rds1 = new ReportDataSource(nombre, lista);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
        }
        private List<Producto> getCodigo()
        {
            List<Producto> codigo = new List<Producto>();            
            foreach (DescripcionProducto i in lista)            
                codigo.Add(i.NumeroSerie);                                      
            return codigo;            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }
    }
}