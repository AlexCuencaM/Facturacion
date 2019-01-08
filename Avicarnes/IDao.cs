namespace DAO
{
    public interface IDao
    {
        void select<X,T>(X campo, T campo2);     
    }
}
