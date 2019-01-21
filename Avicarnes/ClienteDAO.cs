using Oracle.ManagedDataAccess.Client;
using System.Data;
using Avicarnes;
namespace DAO
{
    public class ClienteDAO:SubPlantilla<AccesoCliente>
    {
        
        public ClienteDAO(OracleConnection cn)
        {            
            Campo = new AccesoCliente();
            Param = new ParametrosOracle();
            Conexion = cn;
        }       
       
        public override OracleCommand selectCliente<X,T>(X id, T nombre)
        {
            return selectCliente("operaciones_cliente_pk.SELECTCLIENTE", System.Convert.ToInt32(id), nombre.ToString());
        }

        public override void limpiar()
        {
            Campo.Cliente.limpiar();
        }
        protected override void setDatosCliente(OracleDataReader reader)
        {
            Campo.setDatosCliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetString(3));
        }

        private OracleCommand setParamsValueSelect(OracleCommand cmd, int? id, string nombre)
        {
            cmd.Parameters[1].Value = id;
            cmd.Parameters[2].Value = nombre;
            return cmd;
        }
        public OracleCommand selectCliente(string procedure,int? id, string nombre)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            orcl.Parameters.Add(Param.getParam("PN_ID", DbType.Int32) ) ;
            orcl.Parameters.Add(Param.getParam("PV_NOMBRE",DbType.String));            
            return setParamsValueSelect(orcl, id, nombre); ;
        }

        public override OracleCommand insertCliente(AccesoCliente elemento)
        {
            throw new System.NotImplementedException();
        }
    }
}
