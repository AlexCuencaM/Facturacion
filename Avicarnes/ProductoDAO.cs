using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Avicarnes;

namespace DAO
{
    public class ProductoDAO:Plantilla
    {
        private List<LineaProducto> lista;
        private DescripcionProducto product;
        private int id;
        protected DescripcionProducto Product { get => product; set => product = value; }

        public ProductoDAO(int id)
        {
            lista = new List<LineaProducto>();
            this.id = id;
        }

        public override void limpiar()
        {
            lista.RemoveAt(lista.Count - 1);
            Product = null;
        }
        /// <summary>
        /// Elabora una operacion para el subtotal
        /// </summary>
        /// <typeparam name="X">decimal</typeparam>
        /// <typeparam name="T">double</typeparam>
        /// <param name="precio">Precio del producto</param>
        /// <param name="peso">Peso del prodcuto</param>
        /// <returns></returns>
        public override OracleCommand selectCliente<X, T>(X id, T peso)
        {
            return selectProducto("operaciones_producto_pk.select_producto", System.Convert.ToInt32(id));
        }

        public override void setDatosCliente(OracleDataReader reader)
        {
            product = new DescripcionProducto(reader.GetString(0),reader.GetDecimal(1));
            product.NumeroSerie.Id = id;
            lista.Add(new LineaProducto(product));            
        }
        public OracleCommand selectProducto(string procedure, int? id)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            orcl.Parameters.Add(Param.getParam("pn_id", DbType.Int32));            
            return orcl;
        }



    }
}