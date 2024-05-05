using Domain;

namespace Presentation.Views
{
    public partial class NoteFormUC : UserControl
    {
        private Note? note;
        public event EventHandler<Note>? SubmitButtonClick;
        public NoteFormUC(string ActionButtonText)
        {
            InitializeComponent();
            submitButton.Text = ActionButtonText;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            note ??= new Note();
            if (textBoxNameNote.Text == string.Empty || textBoxPassword.Text == string.Empty || emailTextBox.Text == string.Empty)
            {
                errorLabel.Text = "Name, Password and Email must be not empty";
                return;
            }
            note.UserName = textBoxNameNote.Text;
            note.Description = richTextBoxNoteDescription.Text;
            note.CategoryId = (Guid)categoryComboBox.SelectedValue;
            note.Password = textBoxPassword.Text;
            note.Email = emailTextBox.Text;

            SubmitButtonClick?.Invoke(this, note);
        }

        public void PopulateNoteData(Note note, string decryptedPassword)
        {
            this.note = note;
            textBoxNameNote.Text = note.UserName;
            textBoxPassword.Text = decryptedPassword;
            emailTextBox.Text = note.Email;
            richTextBoxNoteDescription.Text = note.Description;
        }

        public void PopulateCategoriesComboBox(List<Category> categories)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = categories;
            categoryComboBox.DataSource = bindingSource;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            if(note != null)
                categoryComboBox.SelectedValue = note.CategoryId;
        }
    }
}