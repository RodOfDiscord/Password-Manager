using Domain;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        void ClearDataGridView();
        event EventHandler<Guid> DeleteNote;
        event EventHandler<Guid> EditNote;
        public event EventHandler? AddNote;
        void SetAttributes(string profileName);
        void FillDataGridView(IEnumerable<Note> notes);
    }
}
