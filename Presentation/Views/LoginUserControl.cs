using Domain;

namespace Presentation.Views
{
    public partial class LoginUserControl : UserControl, ILoginView
    {
        public event EventHandler<(string, string)>? TryLogin;
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public void SetUserName(string username)
        {
            groupBox.Text = username;
        }

        public void Close()
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            TryLogin?.Invoke(this, (groupBox.Text, textBoxPassword.Text));
        }

        public void DisplayErrorMessage(string message)
        {
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.Red;
        }
    }
}