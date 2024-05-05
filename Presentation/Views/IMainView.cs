using Domain;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        event EventHandler<Guid> DeleteNote;
        event EventHandler<Guid> EditNote;
        void SetAttributes(string profileName);
        void FillDataGridView(IEnumerable<Note> notes);
    }
}
