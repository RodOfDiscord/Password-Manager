using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(PasswordStorageContext context) : base(context)
        {
        }

        public IEnumerable<Profile> GetAllWithNotes()
        {
            return dbSet.Include(x => x.Notes);
        }

        public Profile? GetByName(string name)
        {
            return GetAll().FirstOrDefault(x => x.Name == name);
        }

        public Profile? GetByNameWithNotes(string name)
        {
            return dbSet.Include(x => x.Notes).FirstOrDefault(x => x.Name == name);
        }

        public Profile? GetByNameWithAll(string name)
        {
            return dbSet.Include(x => x.Notes).ThenInclude(n => n.Category).FirstOrDefault(x => x.Name == name);
        }
    }
}