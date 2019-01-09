using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public sealed class CargaDelEncabezado:CargaDeDatos<Label>
    {
        
        private Label fecha;
        private Factura factura;
        public CargaDelEncabezado(Label pedido, Label fecha)
        {
            campo = pedido;
            this.fecha = fecha;
        }

        public Factura Factura => factura;

        protected override void presentarData(Plantilla dato)
        {
            presentarData((PlantillaCliente<Factura>)dato);
            
        }
        private void presentarData(PlantillaCliente<Factura> dato)
        {
            campo.Text = "Nota de Venta:\n\n" + " " + dato.Campo.Id;
            fecha.Text = "Fecha:\n\n" + "  " + dato.Campo.Fecha;
            this.factura = dato.Campo;
        }
    }
}
