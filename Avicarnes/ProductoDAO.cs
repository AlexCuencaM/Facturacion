﻿using Oracle.ManagedDataAccess.Client;
using System.Data;
using Avicarnes;
using System.Windows.Forms;
namespace DAO
{
    public class ProductoDAO:SubPlantilla
    {
        
        public ProductoDAO(OracleConnection conexion,DataGridViewRow id):this(conexion)
        {
            
            try
            {
                Product = new DescripcionProducto();
                Product.crearProducto(System.Convert.ToInt32(id.Cells[0].Value) );
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Escriba números. ");
                id.Cells[0].Value = "";
                Conexion.Close();
            }
        }

        public ProductoDAO(OracleConnection connection)
        {
            Param = new ParametrosOracle();
            Lista = new LineaProducto();            
            Conexion = connection;
        }

        public override void limpiar()
        {
            Product.setValores("", 0);
            Lista = new LineaProducto(Product);
        }
        /// <summary>
        /// Elabora una consulta que busca un producto por su código
        /// </summary>
        /// <typeparam name="X">decimal</typeparam>
        /// <typeparam name="T">NA</typeparam>
        /// <param name="precio">Precio del producto</param>
        /// <param name="peso">Peso del prodcuto</param>
        /// <returns></returns>
        public override OracleCommand selectCliente<X, T>(X id, T na)//Solo se usa el id
        {            
            return selectProducto("operaciones_producto_pk.select_producto", System.Convert.ToInt32(id));
        }

        protected override void setDatosCliente(OracleDataReader reader)//Descripcion y peso
        {
            Product.setValores(reader.GetString(0),reader.GetDecimal(1));
            Lista.agregarDescripcionProducto(Product);
            
        }

        private OracleCommand setParamsValueSelect(OracleCommand cmd, int id)
        {
            cmd.Parameters[1].Value = id;            
            return cmd;
        }

        public OracleCommand selectProducto(string procedure, int id)
        {
            OracleCommand orcl = new OracleCommand(procedure, Conexion);
            orcl.CommandType = CommandType.StoredProcedure;
            orcl.Parameters.Add(Param.getFuncionRef());
            orcl.Parameters.Add(Param.getParam("PN_ID", DbType.Int32));           
            return setParamsValueSelect(orcl,id);
        }
    }
}