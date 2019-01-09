using Oracle.ManagedDataAccess.Client;
using Avicarnes;
using System.Data;
namespace DAO
{
    public class EmpresaDAO:Plantilla
    {
        private Factura factura;
        public Factura Factura { get => factura; set => factura = value; }

        public EmpresaDAO(OracleConnection cn, Factura factura)
        {        
            Param = new ParametrosOracle();
            this.factura = factura;
            Conexion = cn;
        }
        public override void limpiar()
        {
        }
        
        protected override void setDatosCliente(OracleDataReader reader)//Solo guarda nombre y direccion de la empresa
        {
            factura.NombreEmpresa = reader.GetString(0);
            factura.DireccionEmpresa = reader.GetString(1);
        }

        public override OracleCommand selectCliente<X, T>(X id, T nombre)
        {
            OracleCommand orcl = new OracleCommand("datos_empresa_pk.SELECTEMPRESA", Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            return orcl;
        } 
    }
}
