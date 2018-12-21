using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class FactoryDeBusqueda
    {
        /// <summary>
        /// Metodo que ayuda a la creacion de tipo de busqueda
        /// </summary>
        /// <param name="campo">Puede ser nombre o id</param>
        /// <param name="cliente">Objeto a modificar</param>
        /// <param name="criterio">Parametro que diferencia el tipo de busqueda</param>
        /// <returns></returns>
        public static Busqueda crear(TextBox campo,DelegadoCliente cliente,BuscarPor criterio)
        {
            switch(criterio)
            {
                case BuscarPor.NOMBRE:
                    return new BusquedaPorNombre(campo,cliente);

                case BuscarPor.ID:
                    return new BusquedaPorId(campo, cliente);

                default:
                    throw new NotSupportedException("No existe ese tipo de búsqueda");
            }
        }
    }
}
