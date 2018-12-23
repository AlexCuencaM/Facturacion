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
        
        public override void limpiar()
        {
            
        }
        /// <summary>
        /// Obtiene los telefono(s) de la empresa de la BD
        /// </summary>
        /// <typeparam name="X">Entero</typeparam>
        /// <typeparam name="T">string</typeparam>        
        /// <returns></returns>
   
        public override OracleCommand selectCliente<X, T>(X id, T nombre)
        {
            return selectCliente("datos_Empresa_pk.SELECTTELEFONOEMPRESA");
        }

        public override void setDatosCliente(OracleDataReader reader)
        {
            base.setDatosCliente(reader);
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
