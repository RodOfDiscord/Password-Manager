using Domain;

namespace Presentation.Views
{
    public interface IEditNoteView : IView
    {
        event EventHandler<Note>? Save;
        public void PopulateNoteData(Note note, string decryptedPassword, List<Category> categories);
    }
}
