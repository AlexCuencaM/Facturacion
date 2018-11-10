using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    public class Pago
    {
        private string estado;
        public string Estado { get => estado; set => estado = value; }
        public Pago(string estado)
        {
            Estado = estado;
        }
    }
}
