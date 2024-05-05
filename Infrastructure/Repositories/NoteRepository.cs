using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class NoteRepository : BaseRepository<Note>, INoteRepository
    {
        public NoteRepository(PasswordStorageContext context) : base(context)
        {
        }

        public IEnumerable<Note> GetAllWithCategories()
        {
            return dbSet.Include(n => n.Category);
        }

        public IEnumerable<Note> FilterByName(string name)
        {
            return dbSet.Where(n => n.UserName == name);
        }
    }
}
