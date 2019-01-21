using System.Data;
using Avicarnes;
using Oracle.ManagedDataAccess.Client;
namespace DAO
{
    public class FacturaDAO : SubPlantilla<Factura>
    {    
        public FacturaDAO(OracleConnection cn, Factura factura)
        {
            Param = new ParametrosOracle();
            Conexion = cn;
            Campo = factura;
        }     
        protected override void setDatosCliente(OracleDataReader reader)//Solo es el id y la fecha
        {
            Campo.Id = reader.GetInt32(0);
            Campo.Fecha = reader.GetString(1);
        }

        public override OracleCommand selectCliente<X, T>(X id, T nombre)//Parametros no usados
        {
            return selectCliente("factura_pk.selectheader");
        }

        public override void limpiar()
        {
            Campo.Id = 0;
            Campo.Fecha = "";
        }

        public OracleCommand selectCliente(string procedure)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            return orcl;
        }        

        public override OracleCommand insertCliente(Factura elemento)
        {
            OracleCommand orcl = new OracleCommand("factura_pk.insert_factura");
            orcl.CommandType = CommandType.StoredProcedure;            
            parametros(orcl);
            return setParamsValueInsert(orcl, elemento);
        }
        private void parametros(OracleCommand orcl)
        {
            orcl.Parameters.Add(Param.getParam("pn_id_factura", DbType.Int32));
            orcl.Parameters.Add(Param.getParam("pv_fecha", DbType.String));
            orcl.Parameters.Add(Param.getParam("pn_id_cliente", DbType.Int32));
            orcl.Parameters.Add(Param.getParam("pv_nombre_cliente", DbType.String));
        }
        private OracleCommand setParamsValueInsert(OracleCommand cmd, Factura factura)
        {
            cmd.Parameters[0].Value = factura.Id;
            cmd.Parameters[1].Value = factura.Fecha;
            cmd.Parameters[2].Value = factura.Cliente.Id;
            cmd.Parameters[3].Value = factura.Cliente.Nombre;
            return cmd;
        }
    }
}