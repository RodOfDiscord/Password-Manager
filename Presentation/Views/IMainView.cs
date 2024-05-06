using Domain;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        void ClearTable();
        event EventHandler<Guid> DeleteNote;
        event EventHandler<Guid> EditNote;
        event EventHandler ManageCategories;
        event EventHandler AddNote;
        void SetAttributes(string profileName);
        void FillDataGridView(IEnumerable<Note> notes);
    }
}
