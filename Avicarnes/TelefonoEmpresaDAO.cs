using Avicarnes;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace DAO
{
    public class TelefonoEmpresaDAO:TelefonoDAO
    {       
        public TelefonoEmpresaDAO(OracleConnection cn):base(cn)
        {
            Persona.Cliente.crearTelefono();
        }

        public override void delete(int id)
        {
            base.delete(id);
        }

        public override void insert(Telefono cliente)
        {
            base.insert(cliente);
        }
        public override void limpiar()
        {
            base.limpiar();
        }
        public override void update(Telefono cliente)
        {
            base.update(cliente);
        }

        public override OracleCommand selectCliente(int? id, string nombre)
        {
            return selectCliente("datos_Empresa_pk.SELECTTELEFONOEMPRESA", id, nombre);
        }

        public override void setDatosCliente(OracleDataReader reader)
        {
            base.setDatosCliente(reader);
        }
        public override OracleCommand selectCliente(string procedure, int? id, string nombre)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            return orcl;
        }
        
    }
}
