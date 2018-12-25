using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    public class DescripcionProducto
    {
        private Producto numeroSerie;
        private string descripcion;
        private decimal precio;
        private double peso;
        private decimal subtotal;
        public DescripcionProducto(string descripcion, decimal precio)
        {
            Descripcion = descripcion;
            Precio = precio;            
        }

        public double Peso { get => peso; set => peso = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public Producto NumeroSerie { get => numeroSerie; set => numeroSerie = value; }

        public void crearProducto(int id)
        {
            NumeroSerie = new Producto(id);
        }
        public int getId()
        {
            return numeroSerie.Id;
        }


    }
}
