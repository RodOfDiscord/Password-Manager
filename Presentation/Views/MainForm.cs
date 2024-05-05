using Presentation.Views;

namespace Presentation
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public void SetAttributes(string profileName)
        {
            profileNameLabel.Text = profileName;
        }
    }
}
