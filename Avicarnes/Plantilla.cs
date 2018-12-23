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


        /// <summary>
        /// Es un metodo que extrae la consulta dela BD
        /// </summary>
        /// <param name="id">id del cliente </param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <returns></returns>
        public abstract OracleCommand selectCliente <X,T>(X campo, T campo2);
        /// <summary>
        /// Inicialilzar los datos de un objeto mediante la BD
        /// </summary>
        /// <param name="reader">Lector de la consulta</param>
        public abstract void setDatosCliente(OracleDataReader reader);
        /// <summary>
        /// Borrar los datos establecidos por la BD del objeto
        /// </summary>
        public abstract void limpiar();

        public void select<X,T>(X id, T nombre)
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
