using Avicarnes;
using Oracle.ManagedDataAccess.Client;
namespace DAO
{
    public abstract class Plantilla: IDao
    {
        private OracleConnection conexion;
        private ParametrosOracle param;
        private AccesoCliente persona;

        protected OracleConnection Conexion { get => conexion; set => conexion = value; }
        public AccesoCliente Persona { get => persona; set => persona = value; }
        public ParametrosOracle Param { get => param; set => param = value; }
        public abstract OracleCommand selectCliente(int? id, string nombre);

        public abstract void setDatosCliente(OracleDataReader reader);
        public abstract void limpiar();

        public void select(int? id, string nombre)
        {
            conexion.Open();
            OracleCommand cmd = selectCliente(id,nombre);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    setDatosCliente(reader);
                }
            }

            else          
                limpiar();

            reader.Close();
            conexion.Close();
        }        
    }
}
