using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public class DelegadoCliente // Es el delegado del cliente
    {
        private AccesoDAO sistemaBd;       
        public DelegadoCliente(OracleConnection cn)
        {      
            sistemaBd = new AccesoDAO(cn);
        }

        public string getDireccion()
        {
            return Persona().Cliente.Direccion;
        }

        public int getId()
        {
            return Persona().Cliente.Id;
        }

        public string getNombre()
        {
            return Persona().Cliente.Nombre;
        }

        public AccesoCliente Persona()
        {
            return sistemaBd.ClienteBd.Persona;
        }

        public string getTelf()
        {        
            return Persona().Cliente.Telf.presentarTelf();
        }

        public void select(int? id = 0, string nombre = "")
        {
            sistemaBd.select(id, nombre);
        }
        public string getEstado()
        {
            return Persona().Cliente.Estado;
        }
    }
}
