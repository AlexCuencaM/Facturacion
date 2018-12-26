using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAO;

namespace Avicarnes
{
    public class CargaDeProducto : CargaDeDatos<DataGridViewRow>
    {
        private LineaProducto lineaProducto;
        public LineaProducto LineaProducto { get => lineaProducto; set => lineaProducto = value; }

        public CargaDeProducto(DataGridViewRow currentRow)
        {
            campo = currentRow;
        }        
        protected override void presentarData(Plantilla dato)
        {
            SubPlantilla product = (SubPlantilla)dato;            
            if (campo.Cells[0].Value != null)
                if (!String.IsNullOrEmpty(campo.Cells[0].Value.ToString()))
                    asignarValor(product);                        
        }
        protected virtual void asignarValor(SubPlantilla subPlantilla)
        {
            subPlantilla.select(Convert.ToInt32(campo.Cells[0].Value), "NA");
            campo.Cells[1].Value = subPlantilla.Lista.getDescripcion();
            campo.Cells[4].Value = subPlantilla.Lista.getPrecio();
            LineaProducto = subPlantilla.Lista;
            
        }
    }
}
