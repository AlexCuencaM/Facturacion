namespace DAO
{
    public abstract class PlantillaCliente<T>:Plantilla
    {
        private T campo;
        public T Campo { get => campo; set => campo = value; }
    }
}
