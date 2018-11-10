namespace DAO
{
    public interface IDao <T>
    {
        void delete(int id);
        void insert(T element);
        void update(T element);
    }
}
