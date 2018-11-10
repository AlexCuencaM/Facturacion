using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    class DescripcionProducto
    {
        private Producto numeroSerie;
        private string descripcion;
        private double precio;
        private double peso;

        public DescripcionProducto(string descripcion, double precio, double peso)
        {
            Descripcion = descripcion;
            Precio = precio;
            Peso = peso;
        }

        public double Peso { get => peso; set => peso = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
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
