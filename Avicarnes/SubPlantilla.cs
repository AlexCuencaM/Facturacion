using Avicarnes;
namespace DAO
{
    public abstract class SubPlantilla:Plantilla
    {
        private DescripcionProducto product;
        private LineaProducto lista;
        protected DescripcionProducto Product { get => product; set => product = value; }
        public LineaProducto Lista { get => lista; set => lista = value; }
    }
}
