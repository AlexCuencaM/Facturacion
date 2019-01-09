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
            if (campo.Cells[0].Value != null)
                if (!String.IsNullOrEmpty(campo.Cells[0].Value.ToString()))
                    asignarValor((PlantillaCliente<LineaProducto>)dato);                        
        }
        protected virtual void asignarValor(PlantillaCliente<LineaProducto> subPlantilla)
        {
            subPlantilla.select(Convert.ToInt32(campo.Cells[0].Value), "NA");
            campo.Cells[1].Value = subPlantilla.Campo.getDescripcion();
            campo.Cells[4].Value = subPlantilla.Campo.getPrecio();
            LineaProducto = subPlantilla.Campo;            
        }
    }
}
