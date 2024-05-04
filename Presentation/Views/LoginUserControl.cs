using Domain;

namespace Presentation.Views
{
    public partial class LoginUserControl : UserControl, ILoginView
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public void SetProfile(Profile profile)
        {
            groupBox.Text = profile.Name;
        }

        public void Close()
        {
            Close();
        }
    }
}
