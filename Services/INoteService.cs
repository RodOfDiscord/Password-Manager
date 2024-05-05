using Domain;

namespace Services
{
    public interface INoteService
    {
        IEnumerable<Note> FilterByName(string name);
        Note? FindById(Guid id);
        IEnumerable<Note> GetAllWithCategories();
        void UpdateNote(Note note);
        void AddNote(Note note);
        void DeleteNote(Guid id);
    }
}