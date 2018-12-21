using System.Windows.Forms;
using DAO;

namespace Avicarnes
{
    public abstract class CargaDeDatos
    {
        protected Label campo;
        public abstract void presentarData(Plantilla dato);
        /// <summary>
        /// Presenta datos en la aplicación
        /// </summary>
        /// <param name="presentar"></param>
        public void cargar(Plantilla presentar)
        {
            presentar.select(0, "");           
            presentarData(presentar);
        }                
    }
}
