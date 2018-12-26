using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Avicarnes;
namespace DAO
{
    public class TotalProductoDAO:SubtotalProductoDAO
    {
        public TotalProductoDAO(OracleConnection conexion):base(conexion)
        {
            
        }
        public override void limpiar()
        {

        }

        public override OracleCommand selectCliente<X, T>(X descuento, T subtotal)
        {
            return selectSubtotal("operaciones_producto_pk.total",
                System.Convert.ToInt32(descuento), System.Convert.ToDecimal(subtotal));
        }

        private OracleCommand selectSubtotal(string procedure, int? descuento, decimal subtotal)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            orcl.Parameters.Add(Param.getParam("PN_PESO", DbType.Int32));
            orcl.Parameters.Add(Param.getParam("PN_PRECIO", DbType.Decimal));
            return setParamsValueSelect(orcl, descuento, subtotal);
        }

        protected override void setDatosCliente(OracleDataReader reader)
        {
            LineaProducto producto = new LineaProducto(reader.GetDecimal(0));
            Lista.Add(producto);
            
        }
        public OracleCommand setParamsValueSelect(OracleCommand orcl, int? descuento, decimal subtotal)
        {
            orcl.Parameters[1].Value = descuento;
            orcl.Parameters[2].Value = subtotal;
            return orcl;
        }
    }
}
