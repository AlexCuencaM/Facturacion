using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class BusquedaPorId : BusquedaDual
    {
        public BusquedaPorId(TextBox id, DelegadoCliente client) : base(id, client) { }
        /// <summary>
        /// Metodo que devuelve un objeto con datos del cliente
        /// </summary>
        /// <param name="id">Criterio de busqueda</param>
        /// <returns>Cliente con datos</returns>
        protected override DelegadoCliente seleccion(TextBox id)
        {          
            Cliente.select(id:Convert.ToInt32(id.Text));
            return Cliente;
        }

        /// <summary>
        /// Asigna el campo nombre con los datos del cliente dados en el metodo seleccion
        /// </summary>
        /// <param name="nombre">el campo a modificar</param>
        protected override void filtro(TextBox nombre)
        {
            nombre.Text = Cliente.getNombre();
        }
    }
}
