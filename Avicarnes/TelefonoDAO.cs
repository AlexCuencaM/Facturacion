using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Avicarnes;
namespace DAO
{
    public class TelefonoDAO :Plantilla
    {
        

        public TelefonoDAO(OracleConnection cn)
        {
            Persona = new AccesoCliente();
            Param = new ParametrosOracle();
            Conexion = cn;
        }    
        
        public virtual OracleCommand selectCliente(string procedure, int? id, string nombre)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            orcl.Parameters.Add(Param.getParam("PN_ID_CLIENTE", DbType.Int32));
            orcl.Parameters.Add(Param.getParam("PV_NOMBRE", DbType.String));

            setParamsValueSelect(orcl, id, nombre);
            return orcl;
        }

        private OracleCommand setParamsValueSelect(OracleCommand cmd, int? id, string nombre)
        {
            cmd.Parameters[1].Value = id;
            cmd.Parameters[2].Value = nombre;
            return cmd;
        }
        public override void limpiar()
        {
            Persona.LimpiarLista();
        }
        public override void setDatosCliente(OracleDataReader reader)
        {
            Persona.setDatosTelefono(reader.GetString(0));
        }
        public override OracleCommand selectCliente(int? id, string nombre)
        {
            return selectCliente("operaciones_cliente_pk.SELECTTELEFONOCLIENTE", id, nombre);
        }
        public List<string> getTelf()
        {
            List<string> telf = new List<string>();
            if (Persona.Cliente.Telf.ListaTelefono == null)
                telf.Add("");
            telf = Persona.Cliente.Telf.ListaTelefono;
            return telf;
        }
    }
}

  