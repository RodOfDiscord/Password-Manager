using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly PasswordStorageContext passwordStorageContext;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(PasswordStorageContext context)
        {
            dbSet = context.Set<T>();
            passwordStorageContext = context;
        }

        public T Create(T entity)
        {
            dbSet.Add(entity);
            Save();
            return entity;
        }

        public void DeleteById(Guid id)
        {
            T? entity = dbSet.Find(id);
            if (entity == null)
                return;
            dbSet.Remove(entity);
            Save();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public T? GetById(Guid id)
        {
            return dbSet.FirstOrDefault(x => x.Id == id);
        }

        public T Update(T entity)
        {
            dbSet.Update(entity);
            Save();
            return entity;
        }

        public void Save()
        {
           passwordStorageContext.SaveChanges();
        }
    }
}