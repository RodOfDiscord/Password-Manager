using Domain;

namespace Infrastructure.Repositories
{
    public interface INoteRepository : IBaseRepository<Note>
    {
        IEnumerable<Note> FilterByName(string name);
        IEnumerable<Note> GetAllWithCategories();
    }
}