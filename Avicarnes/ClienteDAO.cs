using Oracle.ManagedDataAccess.Client;
using System.Data;
using Avicarnes;
namespace DAO
{
    public class ClienteDAO:Plantilla<Cliente>
    {
        
        public ClienteDAO(OracleConnection cn)
        {            
            Persona = new AccesoCliente();
            Param = new ParametrosOracle();
            Conexion = cn;
        }

        public override void update(Cliente cliente)
        {

        }
        public  override void delete(int id)
        {

        }
        public override void insert(Cliente cliente)
        {

        }
       
        public override OracleCommand selectCliente(int? id, string nombre)
        {
            return selectCliente("operaciones_cliente_pk.SELECTCLIENTE", id, nombre);
        }

        public override void limpiar()
        {
            Persona.Cliente.limpiar();
        }
        public override void setDatosCliente(OracleDataReader reader)
        {
            Persona.setDatosCliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetString(3));
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

            setParamsValueSelect(orcl, id, nombre);
            return orcl;
        }
    }
}
