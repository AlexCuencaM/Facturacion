namespace Avicarnes
{
    public class Producto
    {
        private int id;
        public int Id { get => id; set => id = value; }

        public Producto(int id)
        {
            this.id = id;
        }
        public Producto()
        {

        }
    }
}
