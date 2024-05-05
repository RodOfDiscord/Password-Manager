using Domain;
using System.ComponentModel;

namespace Presentation.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler<(string, string)>? TryLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void DisplayErrorMessage(string message)
        {
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.Red;
        }

        public void DisplayProfiles(IEnumerable<Profile> profiles)
        {
            foreach (var profile in profiles)
            {
                profilesComboBox.Items.Add(profile.Name);
            }
            profilesComboBox.SelectedText = profiles.First().Name;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (profilesComboBox.SelectedItem is string username)
            {
                TryLogin?.Invoke(this, (username, passwordTextBox.Text));
            }
        }

        public void SetDialogResult(DialogResult dialogResult)
        {
            DialogResult = dialogResult;
            Close();
        }

        public DialogResult GetDialogResult()
        {
            return DialogResult;
        }
    }
}