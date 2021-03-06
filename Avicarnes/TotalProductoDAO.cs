﻿using System.Data;
using Oracle.ManagedDataAccess.Client;
namespace DAO
{
    public class TotalProductoDAO:SubtotalProductoDAO
    {
        public TotalProductoDAO(OracleConnection conexion):base(conexion)
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
            orcl.Parameters.Add(Param.getParam("PN_descuento", DbType.Int32));
            orcl.Parameters.Add(Param.getParam("PN_subtotal", DbType.Decimal));
            return setParamsValueSelect(orcl, descuento, subtotal);
        }

        protected override void setDatosCliente(OracleDataReader reader)
        {
             Campo.TotalProducto = reader.GetDecimal(0);                        
        }
        public OracleCommand setParamsValueSelect(OracleCommand orcl, int? descuento, decimal subtotal)
        {
            orcl.Parameters[1].Value = descuento;
            orcl.Parameters[2].Value = subtotal;
            return orcl;
        }
    }
}
