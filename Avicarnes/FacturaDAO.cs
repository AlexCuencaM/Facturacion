using System.Data;
using Avicarnes;
using Oracle.ManagedDataAccess.Client;
namespace DAO
{

    public class FacturaDAO : PlantillaCliente<Factura>
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
    }
}

