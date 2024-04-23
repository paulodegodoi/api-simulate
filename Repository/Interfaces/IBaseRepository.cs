namespace PizzariaCSharp.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        T Create(T entity);
        T Update(T entity);
        void Delete(int id);

    }
}