using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicarnes
{
    public class Pedido
    {
        private Cliente cliente;
        private List<LineaProducto> producto;
        private decimal totalVenta;
        private Factura factura;
        public List<LineaProducto> Producto { get => producto; set => producto = value; }
        public Factura Factura { get => factura; set => factura = value; }
        public decimal TotalVenta { get => totalVenta; set => totalVenta = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public void crearCliente()
        {
            Cliente = new Cliente();
        }

        /*public void crearFactura(string nombreEmpresa, string direccion, int id)
        {
            factura = new Factura(nombreEmpresa, direccion, id);
        }*/

        public void agregarLineaDeProducto(List<LineaProducto> producto)
        {
            Producto = producto;
        }

       
    }

}
