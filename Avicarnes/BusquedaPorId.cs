using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class BusquedaPorId : Busqueda
    {
        public BusquedaPorId(TextBox id, DelegadoCliente client) : base(id, client) { }
        protected override DelegadoCliente seleccion(TextBox id)
        {          
            Cliente.select(id:Convert.ToInt32(id.Text));
            return Cliente;
        }

        protected override void filtro(TextBox filtro)
        {
            filtro.Text = Cliente.getNombre();
        }
    }
}
