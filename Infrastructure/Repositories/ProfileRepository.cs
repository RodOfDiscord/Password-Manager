using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProfileRepository : BaseRepository<Profile>
    {
        public ProfileRepository(PasswordStorageContext context) : base(context)
        {
        }

        public IEnumerable<Profile> GetAllWithNotes()
        {
            return dbSet.Include(x => x.Notes);
        }
    }
}
