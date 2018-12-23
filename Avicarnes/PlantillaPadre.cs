using System;
using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public abstract class PlantillaPadre:Iproducto
    {
        private OracleConnection conexion;
        private ParametrosOracle param;
        private AccesoCliente persona;

        protected OracleConnection Conexion { get => conexion; set => conexion = value; }
        public AccesoCliente Persona { get => persona; set => persona = value; }
        public ParametrosOracle Param { get => param; set => param = value; }

        public abstract OracleCommand selectCliente<T,X>(T id, X nombre);
        public void select<T,X>(T peso,X precio)
        {
            conexion.Open();
            OracleCommand cmd = selectCliente(peso, precio);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    setDatosCliente(reader);
                }
            }

            else
                limpiar();

            reader.Close();
            conexion.Close();
        }

        public abstract void limpiar();
        public abstract void setDatosCliente(OracleDataReader reader);
    }
}
