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
        public event EventHandler? NoteSaved;
        Note? note;
        NoteFormUC formUC = new NoteFormUC("Save");

        public EditNotePresenter(IEditNoteView view, INoteService noteService, ICategoryService categoryService, IEncryptionService encryptionService) : base(view)
        {
            View.SetForm(formUC);
            formUC.SubmitButtonClick += Save;
            this.noteService = noteService;
            this.categoryService = categoryService;
            this.encryptionService = encryptionService;
        }

        private void Save(object? sender, Note note)
        {
            noteService.UpdateNote(note);
            View.Close();
            NoteSaved?.Invoke(this, EventArgs.Empty);
        }

        public void SetNoteData(Guid id)
        {
            formUC.PopulateCategoriesComboBox(categoryService.GetAll().ToList());
            note = noteService.FindById(id);
            string decryptedPassword = encryptionService.Decrypt(note.Password);
            formUC.PopulateNoteData(note, decryptedPassword);
        }
    }
}