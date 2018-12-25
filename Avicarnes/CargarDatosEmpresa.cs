using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public sealed class CargarDatosEmpresa : CargaDeDatos<Label>
    {
        private Label direccion;
        public CargarDatosEmpresa(Label labelNombreEmpresa, Label labelDireccionEmpresa)
        {
            campo = labelNombreEmpresa;
            direccion = labelDireccionEmpresa;
        }
        protected override void presentarData(Plantilla dato)
        {
            EmpresaDAO datoEmpresa = (EmpresaDAO)dato;
            campo.Text = datoEmpresa.Factura.NombreEmpresa;
            direccion.Text = datoEmpresa.Factura.DireccionEmpresa;
        }
    }
}
