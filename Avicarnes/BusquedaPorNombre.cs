using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    
    public class BusquedaPorNombre : Busqueda
    {
        public BusquedaPorNombre(TextBox criterio, DelegadoCliente client) : base(criterio, client){}

        protected override DelegadoCliente seleccion(TextBox criterio)
        {
            Cliente.select(nombre: criterio.Text);
            return Cliente;
        }
        protected override void filtro(TextBox filtro)
        {
            filtro.Text = Cliente.getId().ToString();
            if (filtro.Text == "0")
                filtro.Text = "";
            
        }
    }
}
