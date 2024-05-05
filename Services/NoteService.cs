using Domain;
using Domain.Cipher;
using Infrastructure.Repositories;

namespace Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository noteRepository;
        private readonly IEncryptionService encryptionService;

        public NoteService(INoteRepository noteRepository, IEncryptionService encryptionService)
        {
            this.noteRepository = noteRepository;
            this.encryptionService = encryptionService;
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

        public void UpdateNote(Note note)
        {
            note.Password = encryptionService.Encrypt(note.Password);
            noteRepository.Update(note);
        }

        public void AddNote(Note note)
        {
            note.Password = encryptionService.Encrypt(note.Password);
            noteRepository.Create(note);
        }

        public void DeleteNote(Guid id)
        {
            noteRepository.DeleteById(id);
        }
    }
}
