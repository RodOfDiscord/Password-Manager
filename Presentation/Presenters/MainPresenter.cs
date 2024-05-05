using Domain;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        EditNotePresenter editNotePresenter;
        private readonly AddNotePresenter addNotePresenter;
        private readonly Profile profile;

        public MainPresenter(IMainView view, EditNotePresenter editNotePresenter, AddNotePresenter addNotePresenter, Profile profile) : base(view)
        {
            View.SetAttributes(profile.Name);
            View.FillDataGridView(profile.Notes);
            View.EditNote += onEditNote;
            View.AddNote += onAddNote;
            this.editNotePresenter = editNotePresenter;
            this.addNotePresenter = addNotePresenter;
            this.profile = profile;

            editNotePresenter.NoteSaved += Refresh;
            addNotePresenter.SetProfileId(profile.Id);
            addNotePresenter.NoteAdded += Refresh;
        }

        private void Refresh(object? sender, EventArgs e)
        {
            View.ClearDataGridView();
            View.FillDataGridView(profile.Notes);
        }

        private void onEditNote(object? sender, Guid id)
        {
            editNotePresenter.SetNoteData(id);
            editNotePresenter.Run();
        }

        private void onAddNote(object? sender, EventArgs eventArgs)
        {

            addNotePresenter.Run();
        }
    }
}
