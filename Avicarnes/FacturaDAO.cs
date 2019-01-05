using System.Data;
using Avicarnes;
using Oracle.ManagedDataAccess.Client;
namespace DAO
{

    public class FacturaDAO : Plantilla
    {
        private Factura factura;
        public Factura Factura { get => factura; }

        public FacturaDAO(OracleConnection cn, Factura factura)
        {
            Param = new ParametrosOracle();
            Conexion = cn;
            this.factura = factura;
        }     
        protected override void setDatosCliente(OracleDataReader reader)//Solo es el id y la fecha
        {
            factura.Id = reader.GetInt32(0);
            factura.Fecha = reader.GetString(1);
        }

        public override OracleCommand selectCliente<X, T>(X id, T nombre)//Parametros no usados
        {
            return selectCliente("factura_pk.selectheader");
        }

        public override void limpiar()
        {
            factura.Id = 0;
            factura.Fecha = "";
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

