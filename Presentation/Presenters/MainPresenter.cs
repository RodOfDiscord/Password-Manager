using Domain;
using Presentation.Views;
using Services;

namespace Presentation.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        EditNotePresenter editNotePresenter;
        private readonly AddNotePresenter addNotePresenter;
        private readonly CategoriesPresenter categoriesPresenter;
        private readonly INoteService noteService;
        private readonly Profile profile;

        public MainPresenter(IMainView view, EditNotePresenter editNotePresenter, AddNotePresenter addNotePresenter, CategoriesPresenter categoriesPresenter, INoteService noteService, Profile profile) : base(view)
        {
            View.SetAttributes(profile.Name);
            View.FillDataGridView(profile.Notes);
            View.EditNote += onEditNote;
            View.AddNote += onAddNote;
            View.DeleteNote += DeleteNote;
            View.ManageCategories += onCategories;
            this.editNotePresenter = editNotePresenter;
            this.addNotePresenter = addNotePresenter;
            this.categoriesPresenter = categoriesPresenter;
            this.noteService = noteService;
            this.profile = profile;

            categoriesPresenter.CategoriesChanged += (o, e) => Refresh();
            editNotePresenter.NoteSaved += (o, e) => Refresh();
            addNotePresenter.SetProfileId(profile.Id);
            addNotePresenter.NoteAdded += (o, e) => Refresh();
        }

        private void DeleteNote(object? sender, Guid e)
        {
            noteService.DeleteNote(e);
            Refresh();
        }

        private void Refresh()
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
