using Domain;
using Infrastructure.Repositories;

namespace Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }

        public IEnumerable<Note> GetAllWithCategories()
        {
            return noteRepository.GetAllWithCategories();
        }

        public Note? FindById(Guid id)
        {
            return noteRepository.GetById(id);
        }

        public IEnumerable<Note> FilterByName(string name)
        {
            return noteRepository.FilterByName(name);
        }
    }
}
