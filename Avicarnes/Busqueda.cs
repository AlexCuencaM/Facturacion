using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public abstract class Busqueda
    {
        private TextBox campo;
        private DelegadoCliente cliente;
        /// <summary>
        /// Constructor que toma los valores del criterio de búsqueda y un cliente para modificarlo con o sin datos
        /// </summary>
        /// <param name="criterioBusqueda">nombre o id</param>
        /// <param name="cliente"></param>
        public Busqueda(TextBox criterioBusqueda, DelegadoCliente cliente)
        {            
            campo = criterioBusqueda;
            Cliente = cliente;
        }

        protected DelegadoCliente Cliente { get => cliente; set => cliente = value; }

        /// <summary>
        /// Método que valida los datos de los clientes mediante la busqueda por el criterio
        /// </summary>
        /// <param name="criterio">Puede ser nombre o id</param>
        /// <returns></returns>
        public DelegadoCliente buscarCliente(DelegadoCliente criterio)
        {            
            if (!String.IsNullOrEmpty(campo.Text))
                criterio = seleccion(campo);
            else
                criterio.select();
            return criterio;
        }

        /// <summary>
        /// Metodo que permite modificar los datos en el codigo cliente
        /// </summary>
        /// <param name="labelDireccionCliente">Direccion del cliente</param>
        /// <param name="labelEstadoDePago">Credito o Contado</param>
        /// <param name="labelTelefono">Telefono del cliente</param>
        /// <param name="search">Campo rellenado segun al busqueda</param>
        /// 
        public void asignacionDeCampos(Label labelDireccionCliente, Label labelEstadoDePago, Label labelTelefono, TextBox search)
        {
            labelDireccionCliente.Text = "Direccion: " + Cliente.getDireccion();
            labelEstadoDePago.Text = "Estado: " + Cliente.getEstado();
            labelTelefono.Text = "Teléfono(s): " + Cliente.getTelf();
            filtro(search);
        }
        /// <summary>
        /// Validacion segun tipo de búsqueda
        /// </summary>
        /// <param name="filtro">Puede ser nombre o id</param>
        protected abstract void filtro(TextBox filtro);
        /// <summary>
        /// Retorna los datos de una consulta select segun el criterio
        /// </summary>
        /// <param name="criterio">Puede ser nombre o id</param>
        /// <returns></returns>
        protected abstract DelegadoCliente seleccion(TextBox criterio);
    }
}
