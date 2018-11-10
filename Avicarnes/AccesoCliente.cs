namespace Avicarnes
{
    public class AccesoCliente
    {
        private Cliente cliente;
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public AccesoCliente()
        {
            cliente = new Cliente();
            cliente.crearTelefono();
        }

        public void setDatosCliente(int id, string nombre, string dir,string estado)
        {
            Cliente.Id = id;
            Cliente.Nombre = nombre;
            Cliente.Direccion = dir;
            Cliente.Estado = estado;
        }

        public void setDatosTelefono(string telf)
        {
            Cliente.Telf.agregarTelefono(telf);
        }

        public void LimpiarLista()
        {
            Cliente.Telf.limpiar();
        }
    }
}
