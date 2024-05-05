namespace Presentation.Views
{
    public partial class AddNoteForm : Form, IAddNoteView
    {
        public AddNoteForm()
        {
            InitializeComponent();
        }
        
        public void SetForm(NoteFormUC noteForm)
        {
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