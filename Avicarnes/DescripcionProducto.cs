namespace Avicarnes
{
    public class DescripcionProducto
    {
        private Producto numeroSerie;
        private string descripcion;
        private decimal precio;
        private double peso;
        private decimal subtotal;
        public void setValores(string descripcion, decimal precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
        public void setValores(string descripcion, double peso, decimal precio, decimal subtotal)
        {
            setValores(descripcion,precio);
            Peso = peso;
            Subtotal = subtotal;
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
