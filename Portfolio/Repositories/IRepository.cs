namespace Portfolio.Repositories
{
    public interface IRepository<T>
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
        List<T> GetAllClient();
        void changeStatus(T entity);
    }
}
