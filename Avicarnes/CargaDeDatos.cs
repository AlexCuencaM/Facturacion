using System.Windows.Forms;
using DAO;

namespace Avicarnes
{
    public abstract class CargaDeDatos<T>
    {
        protected Label campo;
        public abstract void presentarData(Plantilla<T> dato);
        public void cargar(Plantilla<T> presentar)
        {
            presentar.select(0, "");           
            presentarData(presentar);
        }                
    }
}
