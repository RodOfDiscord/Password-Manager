using Domain;

namespace Presentation.Views
{
    public partial class EditNoteForm : Form, IEditNoteView
    {
        public EditNoteForm()
        {
            InitializeComponent();
        }

        public void PopulateNoteData(Note note, string decryptedPassword)
        {
            textBoxNameNote.Text = note.UserName;
            textBoxPassword.Text = decryptedPassword;
            richTextBoxNoteDescription.Text = note.Description;
        }
    }
}
