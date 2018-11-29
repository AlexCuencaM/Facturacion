using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    
    public class BusquedaPorNombre : Busqueda
    {
        public BusquedaPorNombre(TextBox criterio, DelegadoCliente client) : base(criterio, client)
        {

        }

        public override DelegadoCliente seleccion(TextBox criterio)
        {
            Cliente.select(nombre: criterio.Text);
            return Cliente;
        }
    }
}
