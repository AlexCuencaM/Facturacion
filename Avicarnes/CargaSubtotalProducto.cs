using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Avicarnes
{
    public class CargaSubtotalProducto : CargaDeProducto
    {

        public CargaSubtotalProducto(DataGridViewRow currentRow) : base(currentRow)
        {
            
        }
        protected override void presentarData(Plantilla dato)
        {
            SubPlantilla product = (SubPlantilla)dato;            
            if (!String.IsNullOrEmpty(campo.Cells[3].Value.ToString()))
            {                
                asignarValor((SubPlantilla)dato);
            }
                
        }
        protected override void asignarValor(SubPlantilla subPlantilla)
        {            
            subPlantilla.select(Convert.ToDouble(campo.Cells[3].Value),Convert.ToDecimal(campo.Cells[4].Value) );
            campo.Cells[5].Value = subPlantilla.Lista.Last().Producto.Subtotal;
            
        }
    }
}
