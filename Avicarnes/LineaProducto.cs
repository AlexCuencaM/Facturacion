using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    public class LineaProducto
    {
        private double subtotal;
        private int cantidad;
        private int descuento;
        private double totalProducto;
        private DescripcionProducto producto;

        public double Subtotal { get => subtotal; set => subtotal = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public double TotalProducto { get => totalProducto; set => totalProducto = value; }

        public LineaProducto(int cantidad, int descuento)
        {
            Cantidad = cantidad;
            Descuento = descuento;
        }

        public LineaProducto(int cantidad,double subtotal)
        {
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public LineaProducto(int cantidad, int descuento, double subtotal, double total)
        {
            Cantidad = cantidad;
            Descuento = descuento;
            Subtotal = subtotal;
            TotalProducto = total;
        }

        public double getPrecio()
        {
            return producto.Precio;
        }

        public double getPeso()
        {
            return producto.Precio;
        }

        public void crearDescripcionProducto(string descripcion, double precio, double peso)
        {
            producto = new DescripcionProducto(descripcion, precio, peso);
        }

    }
}
 