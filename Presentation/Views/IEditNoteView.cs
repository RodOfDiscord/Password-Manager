using Domain;

namespace Presentation.Views
{
    public interface IEditNoteView : IView
    {
        void SetForm(NoteFormUC noteForm);
    }
}
