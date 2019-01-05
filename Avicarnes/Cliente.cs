using System.Collections.Generic;
namespace Avicarnes
{
    public class Cliente
    {
        private Telefono telf;
        private string nombre;
        private string direccion;
        private string estado;
        private int id;
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        public Cliente()
        {

        }

        public void crearTelefono()
        {
            telf =  new Telefono();
        }
        public void limpiar()
        {
            Nombre = "";
            Direccion = "";
            id = 0;
            Estado = "";
            telf.limpiar();
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }
        public Telefono Telf { get => telf; set => telf = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
