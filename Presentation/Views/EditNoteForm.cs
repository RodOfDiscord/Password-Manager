using Domain;

namespace Presentation.Views
{
    public partial class EditNoteForm : Form, IEditNoteView
    {
        public event EventHandler<Note>? Save;
        private Note? note;

        public EditNoteForm()
        {
            InitializeComponent();
        }

        public void PopulateNoteData(Note note, string decryptedPassword, List<Category> categories)
        {
            this.note = note;
            textBoxNameNote.Text = note.UserName;
            textBoxPassword.Text = decryptedPassword;
            richTextBoxNoteDescription.Text = note.Description;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = categories;
            categoryComboBox.DataSource = bindingSource;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.SelectedValue = note.CategoryId;
        }

        public new void Show()
        {
            ShowDialog();
        }

        public new void Close()
        {
            DialogResult = DialogResult.Continue;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(note == null)
            {
                MessageBox.Show("Cannot save note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxNameNote.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                errorLabel.Text = "name and password must be not empty";
                return;
            }
            note.UserName = textBoxNameNote.Text;
            note.Description = richTextBoxNoteDescription.Text;
            note.CategoryId = (Guid)categoryComboBox.SelectedValue;
            note.Password = textBoxPassword.Text;
            Save?.Invoke(this, note);
        }
    }
}