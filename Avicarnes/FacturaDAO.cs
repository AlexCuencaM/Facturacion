using System.Collections.Generic;
using System.Data;
using Avicarnes;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{

    public class FacturaDAO : Plantilla<FacturaDAO>
    {
        private Factura factura;
        public Factura Factura { get => factura; }

        public FacturaDAO(OracleConnection cn, Factura factura)
        {
            Param = new ParametrosOracle();
            Conexion = cn;
            this.factura = factura;
        }

        public override void update(FacturaDAO cliente)
        {

        }
        public override void delete(int id)
        {

        }
        public override void insert(FacturaDAO cliente)
        {

        }
        
        public override void setDatosCliente(OracleDataReader reader)
        {
            factura.Id = reader.GetInt32(0);
            factura.Fecha = reader.GetString(1);
        }

        public override OracleCommand selectCliente(int? id = 0, string nombre = "")
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


