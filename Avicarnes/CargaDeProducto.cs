using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAO;

namespace Avicarnes
{
    public sealed class CargaDeProducto : CargaDeDatos<DataGridViewRow>
    {
        private HashSet<LineaProducto> lineaProducto;

        public CargaDeProducto(DataGridViewRow currentRow)
        {
            campo = currentRow;
        }

        public HashSet<LineaProducto> LineaProducto => lineaProducto;

        protected override void presentarData(Plantilla dato)
        {
            SubPlantilla product = (SubPlantilla)dato;
            if (!String.IsNullOrEmpty(campo.Cells[0].Value.ToString() ) )            
                asignarValor(product);            
        }
        private void asignarValor(SubPlantilla subPlantilla)
        {
            subPlantilla.select(Convert.ToInt32(campo.Cells[0].Value), "NA");
            campo.Cells[1].Value = subPlantilla.Lista.Last().getDescripcion();
            campo.Cells[4].Value = subPlantilla.Lista.Last().getPrecio();
            lineaProducto = subPlantilla.Lista;
            
        }
    }
}
