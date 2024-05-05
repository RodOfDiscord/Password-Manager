using Domain;
using Domain.Cipher;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class EditNotePresenter : BasePresenter<IEditNoteView>
    {
        private readonly INoteService noteService;
        private readonly ICategoryService categoryService;
        private readonly IEncryptionService encryptionService;
        Note? note;

        public EditNotePresenter(IEditNoteView view, INoteService noteService, ICategoryService categoryService, IEncryptionService encryptionService) : base(view)
        {
            this.noteService = noteService;
            this.categoryService = categoryService;
            this.encryptionService = encryptionService;
            view.Save += Save;
        }

        private void Save(object? sender, Note note)
        {
            noteService.UpdateNote(note);
            View.Close();
        }

        public void SetNoteData(Guid id)
        {
            note = noteService.FindById(id);
            List<Category> categories = categoryService.GetAll().ToList();
            if (note != null)
            {
                string decryptedPassword = encryptionService.Decrypt(note.Password);
                View.PopulateNoteData(note, decryptedPassword, categories);
            }
        }
    }
}