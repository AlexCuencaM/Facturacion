using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Avicarnes;
using System.Data;
namespace DAO
{
    public class EmpresaDAO:Plantilla<EmpresaDAO>
    {
        private Factura factura;

        public Factura Factura { get => factura; set => factura = value; }

        public EmpresaDAO(OracleConnection cn, Factura factura)
        {
            Persona = new AccesoCliente();
            Param = new ParametrosOracle();
            this.factura = factura;
            Conexion = cn;
        }
        public override void insert(EmpresaDAO a)
        {

        }

        public override void update(EmpresaDAO a)
        {

        }

        public override void delete(int a)
        {

        }

        public override void limpiar()
        {
        }
        
        public override void setDatosCliente(OracleDataReader reader)
        {
            factura.NombreEmpresa = reader.GetString(0);
            factura.DireccionEmpresa = reader.GetString(1);
        }

        public override OracleCommand selectCliente(int? id, string nombre)
        {
            OracleCommand orcl = new OracleCommand("datos_empresa_pk.SELECTEMPRESA", Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            return orcl;
        } 
    }
}
