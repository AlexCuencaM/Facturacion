using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public class AccesoDAO // Se crea cliente y telefono
    {
        private Plantilla clienteBd;
        private Plantilla telfBd;
        
        public AccesoDAO(OracleConnection cn)
        {
            clienteBd = new ClienteDAO(cn);
            telfBd = new TelefonoDAO(cn);
        }

        public Plantilla ClienteBd { get => clienteBd; set => clienteBd = value; }
        public Plantilla TelfBd { get => telfBd; set => telfBd = value; }

        public void select(int? id , string nombre)
        {
            clienteBd.select(id, nombre);
            telfBd.select(id, nombre);
            clienteBd.Persona.Cliente.Telf = telfBd.Persona.Cliente.Telf;
        }
        
    }
}
