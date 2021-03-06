﻿namespace Avicarnes
{
    public class LineaProducto
    {
        
        private int cantidad;
        private int descuento;
        private decimal totalProducto;
        private DescripcionProducto producto;
        
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public decimal TotalProducto { get => totalProducto; set => totalProducto = value; }
        public DescripcionProducto Producto { get => producto; set => producto = value; }        

        public LineaProducto(DescripcionProducto product)
        {
            producto = product;
            
        }        
        public LineaProducto()
        {

        }
        
        public decimal getPrecio()
        {
            return producto.Precio;
        }

        public decimal getPeso()
        {
            return producto.Precio;
        }
        public string getDescripcion()
        {
            return producto.Descripcion;
        }

        public void crearDescripcionProducto()
        {
            producto = new DescripcionProducto();
        }
        public void setValores(int cantidad ,int descuento,decimal total)
        {
            Cantidad = cantidad;
            Descuento = descuento;
            TotalProducto = total;
        }
        public void agregarDescripcionProducto(DescripcionProducto pro)
        {
            producto = pro;
        }
    }
}
 