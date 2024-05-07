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
            if (textBoxNameNote.Text == string.Empty
                || textBoxPassword.Text == string.Empty
                || emailTextBox.Text == string.Empty
                || categoryComboBox.SelectedItem == null)
            {
                errorLabel.Text = "Name, Password, Email and category must be not empty";
                return;
            }
            note.UserName = textBoxNameNote.Text;
            note.Description = richTextBoxNoteDescription.Text;
            if(categoryComboBox.SelectedItem != null)
            {
                Category category = categoryComboBox.SelectedItem as Category;
                note.CategoryId = category.Id;
            }
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
            categoryComboBox.Items.Clear();
            foreach (Category category in categories)
            {
                categoryComboBox.Items.Add(category);
            }
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            if (note != null)
                categoryComboBox.SelectedIndex = categoryComboBox.Items.IndexOf(note.Category);
        }

        private void passwordVisiblebutton_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                passwordVisiblebutton.BackgroundImage = Resources.show;
            }
            else
            {
                passwordVisiblebutton.BackgroundImage = Resources.hide;
            }
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }
    }
}