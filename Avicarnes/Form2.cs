using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Avicarnes
{
    public partial class Form2 : Form
    {
        
        List<DescripcionProducto> lista;
        List<LineaProducto> linea;
        public Form2(List<DescripcionProducto> product, List<LineaProducto> linea)
        {
            lista = product;
            this.linea = linea;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {            
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Avicarnes.Report1.rdlc";

            ReportDataSource rds1 = new ReportDataSource("Producto", lista);
            ReportDataSource rds2 = new ReportDataSource("ProductoId", getCodigo());
            ReportDataSource rds3 = new ReportDataSource("LineaProducto", linea);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds2);                        
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }
        private List<Producto> getCodigo()
        {
            List<Producto> codigo = new List<Producto>();
            
            foreach (DescripcionProducto i in lista)
            {
                codigo.Add(i.NumeroSerie);                
            }            
            return codigo;
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
