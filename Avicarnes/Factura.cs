namespace Avicarnes
{
    public class Factura
    {
        private string nombreEmpresa;
        private string direccionEmpresa;
        private string fecha;        
        private int id;
        private Cliente cliente;
        public Factura()
        {
            
        }                
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string DireccionEmpresa { get => direccionEmpresa; set => direccionEmpresa = value; }
        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        
    }
}
