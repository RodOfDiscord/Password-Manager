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
        private readonly ICategoryService categoryService;
        private readonly Profile profile;

        public MainPresenter(IMainView view, EditNotePresenter editNotePresenter, AddNotePresenter addNotePresenter, CategoriesPresenter categoriesPresenter, INoteService noteService,ICategoryService categoryService ,Profile profile) : base(view)
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
            this.categoryService = categoryService;
            this.profile = profile;

            categoriesPresenter.CategoryChanged += (o, e) => RefreshNotes();
            categoriesPresenter.CategoryChanged += (o, e) => RefreshCategories();
            categoriesPresenter.View.AddCategory += (o, e) => RefreshCategories();
            editNotePresenter.NoteSaved += (o, e) => RefreshNotes();
            addNotePresenter.SetProfileId(profile.Id);
            addNotePresenter.NoteAdded += (o, e) => RefreshNotes();
        }

        private void DeleteNote(object? sender, Guid e)
        {
            noteService.DeleteNote(e);
            RefreshNotes();
        }

        private void RefreshNotes()
        {
            View.ClearTable();
            View.FillDataGridView(profile.Notes);
        }

        private void RefreshCategories()
        {
            var categories = categoryService.GetAll().ToList();
            addNotePresenter.NoteForm.PopulateCategoriesComboBox(categories);
            editNotePresenter.NoteForm.PopulateCategoriesComboBox(categories);
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
