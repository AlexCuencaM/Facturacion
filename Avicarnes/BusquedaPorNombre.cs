using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    
    public class BusquedaPorNombre : BusquedaDual
    {

        public BusquedaPorNombre(TextBox nombre, DelegadoCliente client) : base(nombre, client){}


        /// <summary>
        /// Regresa el resultado de los datos del cliente a traves de un nombre
        /// </summary>
        /// <param name="cliente">Contiene el nombre del Cliente </param>
        /// <returns>Los datos del cliente</returns>
        protected override DelegadoCliente seleccion(TextBox cliente)
        {
            Cliente.select(nombre: cliente.Text);
            return Cliente;
        }
        /// <summary>
        /// Asigna el campo id con los datos del cliente dados en el metodo seleccion
        /// </summary>
        /// <param name="id">El id del cliente que se rellena</param>
        protected override void filtro(TextBox id)
        {
            id.Text = Cliente.getId().ToString();
            if (id.Text == "0")
                id.Text = "";
            
        }
    }
}
