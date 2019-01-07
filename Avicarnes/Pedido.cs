using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Avicarnes
{
    public class Pedido
    {        
        private List<LineaProducto> productos;
        private List<DescripcionProducto> descripcionProductos;        
        private Factura factura;

        public Pedido()
        {
            productos = new List<LineaProducto>();
            descripcionProductos = new List<DescripcionProducto>();                       
        }

        public Pedido listas(DataGridViewRowCollection rows)
        {
            foreach (DataGridViewRow i in rows)
            {
                LineaProducto producto = new LineaProducto();
                DescripcionProducto descripcionProducto = new DescripcionProducto();                
                setLista(i,producto,descripcionProducto);
            }            
            return this;
        }

        private void setLista(DataGridViewRow i, LineaProducto lineaProducto, DescripcionProducto descripcionProducto)
        {
            if (i.Cells[1].Value != null && i.Cells[3].Value != null)
            {
                descripcionProducto.NumeroSerie = new Producto();
                setValorLista(i,lineaProducto,descripcionProducto);                
                AddValor(lineaProducto,descripcionProducto);
            }
        }
        private void setValorLista(DataGridViewRow i, LineaProducto producto, DescripcionProducto descripcionProducto)
        {            
            descripcionProducto.NumeroSerie.Id = Convert.ToInt32(i.Cells[0].Value);            
            descripcionProducto.setValores(i.Cells[1].Value.ToString(), Convert.ToDouble(i.Cells[3].Value),
                Convert.ToDecimal(i.Cells[4].Value), Convert.ToDecimal(i.Cells[5].Value));         
            producto.setValores(Convert.ToInt32(i.Cells[2].Value), Convert.ToInt32(i.Cells[6].Value), Convert.ToDecimal(i.Cells[7].Value));            
        }        

        private void AddValor(LineaProducto producto, DescripcionProducto descripcionProducto)
        {
            MessageBox.Show(descripcionProducto.NumeroSerie.Id.ToString());
            DescripcionProductos.Add(descripcionProducto);            
            Productos.Add(producto);
        }

        public List<LineaProducto> Productos { get => productos; set => productos = value; }
        public Factura Factura { get => factura; set => factura = value; }        
        public List<DescripcionProducto> DescripcionProductos { get => descripcionProductos; set => descripcionProductos = value; }
    }

}
