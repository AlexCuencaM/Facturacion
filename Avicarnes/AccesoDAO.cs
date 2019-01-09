using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public class AccesoDAO // Se crea cliente y telefono
    {
        private PlantillaCliente<AccesoCliente> clienteBd;
        private PlantillaCliente<AccesoCliente> telfBd;
        
        public AccesoDAO(OracleConnection cn)
        {
            clienteBd = new ClienteDAO(cn);
            telfBd = new TelefonoDAO(cn);
        }

        public PlantillaCliente<AccesoCliente> ClienteBd { get => clienteBd; set => clienteBd = value; }
        public PlantillaCliente<AccesoCliente> TelfBd { get => telfBd; set => telfBd = value; }

        public void select(int? id , string nombre)
        {
            clienteBd.select(id, nombre);
            telfBd.select(id, nombre);
            clienteBd.Campo.Cliente.Telf = telfBd.Campo.Cliente.Telf;
        }
        
    }
}
