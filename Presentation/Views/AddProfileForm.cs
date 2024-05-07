using Domain;

namespace Presentation.Views
{
    public partial class AddProfileForm : Form, IAddProfileView
    {
        public event EventHandler<Profile>? AddProfile;
        private PasswordInputUC passwordUC;
        public AddProfileForm()
        {
            InitializeComponent();
            passwordUC = new PasswordInputUC();
            panel1.Controls.Add(passwordUC);
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Profile newProfile = new Profile();
            if (string.IsNullOrEmpty(passwordUC.PasswordText) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Fill all inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newProfile.Name = textBox1.Text;
            newProfile.Password = passwordUC.PasswordText;
            AddProfile?.Invoke(this, newProfile);
        }
    }
}
