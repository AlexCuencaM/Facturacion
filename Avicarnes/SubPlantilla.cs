using Oracle.ManagedDataAccess.Client;
namespace DAO
{
    public abstract class SubPlantilla<T> : PlantillaCliente<T>, Iinsert<T>
    {
        public void insert(T elemento)
        {
            try
            {
                Conexion.Open();
                OracleCommand cmd = insertCliente(elemento);
                cmd.ExecuteNonQuery();                
                Conexion.Close();
            }
            catch (OracleException)
            {
                System.Windows.Forms.MessageBox.Show("Error :(");
                Conexion.Close();
            }
        }
                
        public abstract OracleCommand insertCliente(T elemento);        

    }
}
