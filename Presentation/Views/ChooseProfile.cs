using Domain;
using Presentation.Views;

namespace Presentation
{
    public partial class ChooseProfile : Form, IChooseProfileView
    {
        public event EventHandler<string>? ProfileSelected;
        public event EventHandler<UserControl>? DisplayLoginView;
        public ChooseProfile()
        {
            InitializeComponent();
        }

        public void DisplayProfiles(IEnumerable<Profile> profiles)
        {
            flowLayoutProfilePanel.Controls.Clear();
            foreach (var p in profiles)
            {
                Button button = new Button
                {
                    Text = p.Name,
                    AutoSize = true,
                };
                button.Click += (s, e) => ProfileSelected?.Invoke(this, p.Name);
                flowLayoutProfilePanel.Controls.Add(button);
            }
        }

        public void DisplayLoginUC(UserControl userControl)
        {
            loginPanel.Controls.Clear();
            loginPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        public new void Show()
        {
            this.ShowDialog();
        }
    }
}