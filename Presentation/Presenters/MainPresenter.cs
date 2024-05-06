using Domain;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        EditNotePresenter editNotePresenter;
        private readonly AddNotePresenter addNotePresenter;
        private readonly CategoriesPresenter categoriesPresenter;
        private readonly Profile profile;

        public MainPresenter(IMainView view, EditNotePresenter editNotePresenter, AddNotePresenter addNotePresenter,CategoriesPresenter categoriesPresenter, Profile profile) : base(view)
        {
            View.SetAttributes(profile.Name);
            View.FillDataGridView(profile.Notes);
            View.EditNote += onEditNote;
            View.AddNote += onAddNote;
            View.ManageCategories += onCategories;
            this.editNotePresenter = editNotePresenter;
            this.addNotePresenter = addNotePresenter;
            this.categoriesPresenter = categoriesPresenter;
            this.profile = profile;

            categoriesPresenter.CategoriesChanged += Refresh;
            editNotePresenter.NoteSaved += Refresh;
            addNotePresenter.SetProfileId(profile.Id);
            addNotePresenter.NoteAdded += Refresh;
        }

        private void Refresh(object? sender, EventArgs e)
        {
            View.ClearTable();
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

        private void onCategories(object? sender, EventArgs eventArgs)
        {
            categoriesPresenter.Run();
        }
    }
}
