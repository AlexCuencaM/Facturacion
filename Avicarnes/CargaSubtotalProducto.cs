﻿using System;
using System.Linq;
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
            try
            {
                if (campo.Cells[3].Value != null)
                    if (!String.IsNullOrEmpty(campo.Cells[3].Value.ToString()))
                        asignarValor((PlantillaCliente<LineaProducto>)dato);
            }
            catch(FormatException)
            {
                MessageBox.Show("Escriba números");
            }            
                
        }
        protected override void asignarValor(PlantillaCliente<LineaProducto> subPlantilla)
        {            
            subPlantilla.select(Convert.ToDouble(campo.Cells[3].Value),Convert.ToDecimal(campo.Cells[4].Value) );
            campo.Cells[5].Value = subPlantilla.Campo.Producto.Subtotal;
            
        }
    }
}
