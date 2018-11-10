using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    public class Factura
    {
        private string nombreEmpresa;
        private string direccionEmpresa;
        private string fecha;
        private Factura tipoPago;
        private int id;
        public Factura()
        {
            
        }
        
        public Factura TipoPago { get => tipoPago; set => tipoPago = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string DireccionEmpresa { get => direccionEmpresa; set => direccionEmpresa = value; }
        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
