using Domain;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        EditNotePresenter editNotePresenter;
        public MainPresenter(IMainView view, EditNotePresenter editNotePresenter, Profile profile) : base(view)
        {
            view.SetAttributes(profile.Name);
            view.FillDataGridView(profile.Notes);
            View.EditNote += onEditNote;
            this.editNotePresenter = editNotePresenter;
        }

        private void onEditNote(object? sender, Guid id)
        {
            editNotePresenter.SetNoteId(id);
            editNotePresenter.Run();
        }
    }
}
