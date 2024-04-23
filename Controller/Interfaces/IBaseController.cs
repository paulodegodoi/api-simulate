namespace PizzariaCSharp.Controller.Interfaces
{
    public interface IBaseController<T>
    {
        T Get(int id);
        List<T> GetAll();
        T Post(T entity);
        T Update(int id, T entity);
        void Delete(int id);
    }
}