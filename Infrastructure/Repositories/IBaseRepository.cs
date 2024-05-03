using Domain;

namespace Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T? GetById(Guid id);
        T Create(T entity);
        T Update(T entity);
        void DeleteById(Guid id);
    }
}
