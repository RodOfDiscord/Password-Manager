using Domain;

namespace Presentation.Views
{
    public partial class EditNoteForm : Form, IEditNoteView
    {
        public EditNoteForm()
        {
            InitializeComponent();
        }

        public void SetForm(NoteFormUC noteForm)
        {
            noteForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(noteForm);
        }

        public new void Show()
        {
            ShowDialog();
        }

        public new void Close()
        {
            DialogResult = DialogResult.Continue;
        }
    }
}