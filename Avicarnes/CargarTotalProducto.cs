using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class CargarTotalProducto:CargaDeProducto
    {
        public CargarTotalProducto(DataGridViewRow currentRow) : base(currentRow)
        {

        }
        protected override void presentarData(Plantilla dato)
        {
            SubPlantilla product = (SubPlantilla)dato;
            try
            {                
                if (campo.Cells[6].Value != null)
                {
                    if (!String.IsNullOrEmpty(campo.Cells[6].Value.ToString()))
                        asignarValor((SubPlantilla)dato);
                }
                else
                    defecto(product);
            }
            catch(FormatException)
            {
                MessageBox.Show("Escriba números");
                
            }

            
        }
        protected override void asignarValor(SubPlantilla subPlantilla)
        {            
            subPlantilla.select(Convert.ToInt32(campo.Cells[6].Value), Convert.ToDecimal(campo.Cells[5].Value));
            campo.Cells[7].Value = subPlantilla.Lista.TotalProducto;
        }
        private void defecto(SubPlantilla subPlantilla)
        {
            subPlantilla.select(0, Convert.ToDecimal(campo.Cells[5].Value));
            campo.Cells[7].Value = subPlantilla.Lista.TotalProducto;
        }
    }
}
