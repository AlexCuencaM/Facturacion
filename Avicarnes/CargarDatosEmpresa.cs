using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class CargarDatosEmpresa : CargaDeDatos
    {
        private Label direccion;
        public CargarDatosEmpresa(Label labelNombreEmpresa, Label labelDireccionEmpresa)
        {
            campo = labelNombreEmpresa;
            direccion = labelDireccionEmpresa;
        }
        public override void presentarData(Plantilla dato)
        {
            EmpresaDAO datoEmpresa = (EmpresaDAO)dato;
            campo.Text = datoEmpresa.Factura.NombreEmpresa;
            direccion.Text = datoEmpresa.Factura.DireccionEmpresa;
        }
    }
}
