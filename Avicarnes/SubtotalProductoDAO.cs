using System.Data;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public class SubtotalProductoDAO : ProductoDAO
    {
        

        public SubtotalProductoDAO(OracleConnection conexion):base(conexion)
        {            

        }
        public override void limpiar()
        {
            
        }

        public override OracleCommand selectCliente<X, T>(X peso, T precio)
        {
            return  selectSubtotal("operaciones_producto_pk.subtotal",
                System.Convert.ToDouble(peso), System.Convert.ToDecimal(precio));
        }

        public OracleCommand selectSubtotal(string procedure, double? peso, decimal precio)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef() );
            orcl.Parameters.Add(Param.getParam("PN_PESO", DbType.Double));
            orcl.Parameters.Add(Param.getParam("PN_PRECIO", DbType.Decimal));
            return setParamsValueSelect(orcl, peso,precio);
        }

        protected override void setDatosCliente(OracleDataReader reader)
        {           
            Product.Subtotal = reader.GetDecimal(0);
            Lista.agregarDescripcionProducto(Product);
        }
        public OracleCommand setParamsValueSelect(OracleCommand orcl, double? peso, decimal precio)
        {            
            orcl.Parameters[1].Value = peso;
            orcl.Parameters[2].Value = precio;
            return orcl;
        }
    }
}
