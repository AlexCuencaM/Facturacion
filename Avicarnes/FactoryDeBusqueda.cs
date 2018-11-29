using System;
using System.Windows.Forms;
using DAO;
namespace Avicarnes
{
    public class FactoryDeBusqueda
    {
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
