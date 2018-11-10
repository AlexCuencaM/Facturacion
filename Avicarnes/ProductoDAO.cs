using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicarnes;
namespace DAO
{
    public class ProductoDAO : IDao<LineaProducto>
    {
        private List<LineaProducto> lista;
        public void update(LineaProducto cliente)
        {

        }
        public void delete(int id)
        {

        }
        public void insert(LineaProducto cliente)
        {

        }
        public List<LineaProducto> select()
        {
            return lista;
        }
    }
}