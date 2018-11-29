using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public abstract class Busqueda
    {
        private TextBox campo;
        private DelegadoCliente cliente;
        public Busqueda(TextBox criterioBusqueda, DelegadoCliente cliente)
        {            
            campo = criterioBusqueda;
            Cliente = cliente;
        }

        protected DelegadoCliente Cliente { get => cliente; set => cliente = value; }

        public DelegadoCliente buscarCliente(DelegadoCliente criterio)
        {
            
            if (!String.IsNullOrEmpty(campo.Text))
                criterio = seleccion(campo);
            else
                criterio.select();
            return criterio;
        }

        public abstract DelegadoCliente seleccion(TextBox criterio);
    }
}
