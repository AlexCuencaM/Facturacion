using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicarnes;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public abstract class SubPlantilla:Plantilla
    {
        private DescripcionProducto product;
        private HashSet<LineaProducto> lista;
        protected DescripcionProducto Product { get => product; set => product = value; }
        public HashSet<LineaProducto> Lista { get => lista; set => lista = value; }
    }
}
