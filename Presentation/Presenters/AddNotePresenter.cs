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
        public NoteFormUC NoteForm {  get; private set; }
        public AddNotePresenter(IAddNoteView view, INoteService noteService, ICategoryService categoryService) : base(view)
        {
            NoteForm = new NoteFormUC("Add");
            NoteForm.PopulateCategoriesComboBox(categoryService.GetAll().ToList());
            View.SetForm(NoteForm);

            NoteForm.SubmitButtonClick += AddNote;
            this.noteService = noteService;
        }

        public void SetProfileId(Guid profileId)
        {
            ProfileId = profileId;
        }

        private void AddNote(object? sender, Note note)
        {
            note.Id = Guid.Empty;
            note.CreatedAt = DateTime.Now;
            note.ProfileId = ProfileId;
            noteService.AddNote(note);
            View.Close();
            NoteAdded?.Invoke(this, EventArgs.Empty);
        }
    }
}