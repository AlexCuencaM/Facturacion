﻿using Oracle.ManagedDataAccess.Client;
namespace DAO
{
    public abstract class Plantilla: IDao
    {
        private OracleConnection conexion;
        private ParametrosOracle param;        

        protected OracleConnection Conexion { get => conexion; set => conexion = value; }        
        public ParametrosOracle Param { get => param; set => param = value; }
        /// <summary>
        /// Es un metodo que extrae la consulta dela BD
        /// </summary>
        /// <param name="id">id del cliente </param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <returns></returns>
        public abstract OracleCommand selectCliente <X,T>(X campo, T campo2);
        /// <summary>
        /// Inicialilzar los datos de un objeto mediante la BD
        /// </summary>
        /// <param name="reader">Lector de la consulta</param>
        protected abstract void setDatosCliente(OracleDataReader reader);
        /// <summary>
        /// Borrar los datos establecidos por la BD del objeto
        /// </summary>
        public abstract void limpiar();

        public void select<X,T>(X campo1, T campo2)
        {
            try
            {
                conexion.Open();
                OracleCommand cmd = selectCliente(campo1, campo2);
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
            catch(OracleException)
            {
                System.Windows.Forms.MessageBox.Show("Conecte su base de datos");
                conexion.Close();
            }
            
        }

    }
}