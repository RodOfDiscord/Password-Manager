using Domain;

namespace Services
{
    public interface INoteService
    {
        IEnumerable<Note> FilterByName(string name);
        Note? FindById(Guid id);
        IEnumerable<Note> GetAllWithCategories();
    }
}