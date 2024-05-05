using Domain;

namespace Presentation.Views
{
    public interface IEditNoteView : IView
    {
        public void PopulateNoteData(Note note, string decryptedPassword);
    }
}
