namespace Infrastructure.Repositories
{
    public interface IRepository<T, K>
    {
        IEnumerable<T> GetAll();

        T? GetById(K id);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
