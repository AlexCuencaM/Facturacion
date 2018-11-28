using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public class AccesoDAO // Se crea cliente y telefono
    {
        private Plantilla<Cliente> clienteBd;
        private Plantilla<Telefono> telfBd;
        
        public AccesoDAO(OracleConnection cn)
        {
            clienteBd = new ClienteDAO(cn);
            telfBd = new TelefonoDAO(cn);
        }

        public Plantilla<Cliente> ClienteBd { get => clienteBd; set => clienteBd = value; }
        public Plantilla<Telefono> TelfBd { get => telfBd; set => telfBd = value; }

        public void select(int? id , string nombre)
        {
            clienteBd.select(id, nombre);
            telfBd.select(id, nombre);
            clienteBd.Persona.Cliente.Telf = telfBd.Persona.Cliente.Telf;
        }
        
    }
}
