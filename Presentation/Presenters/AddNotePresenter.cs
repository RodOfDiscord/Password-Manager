using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class AddNotePresenter : BasePresenter<IAddNoteView>
    {
        private readonly INoteService noteService;
        public event EventHandler? NoteAdded;
        private Guid ProfileId;
        public AddNotePresenter(IAddNoteView view, INoteService noteService, ICategoryService categoryService) : base(view)
        {
            NoteFormUC form = new NoteFormUC("Add");
            form.PopulateCategoriesComboBox(categoryService.GetAll().ToList());
            View.SetForm(form);

            form.SubmitButtonClick += AddNote;
            this.noteService = noteService;
        }

        public void SetProfileId(Guid profileId)
        {
            ProfileId = profileId;
        }

        private void AddNote(object? sender, Note note)
        {
            note.CreatedAt = DateTime.Now;
            note.ProfileId = ProfileId;
            noteService.AddNote(note);
            View.Close();
            NoteAdded?.Invoke(this, EventArgs.Empty);
        }
    }
}