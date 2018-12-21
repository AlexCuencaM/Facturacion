using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DAO;
namespace Avicarnes
{
    public class CargaDelEncabezado:CargaDeDatos
    {
        
        private Label fecha;
        private Factura factura;
        public CargaDelEncabezado(Label pedido, Label fecha)
        {
            campo = pedido;
            this.fecha = fecha;
        }

        public Factura Factura => factura;

        public override void presentarData(Plantilla dato)
        {
            FacturaDAO factura = (FacturaDAO)dato;
            campo.Text = "Nota de Venta:\n\n" + " " + factura.Factura.Id;
            fecha.Text = "Fecha:\n\n" + "  " + factura.Factura.Fecha;
            this.factura = factura.Factura;
        }
    }
}
