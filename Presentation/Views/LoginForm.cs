using Domain;
using Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler<(string, string)> TryLogin;

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
            profilesComboBox.Items.Add(profiles);
        }

        public void OnProfileSelected(object? sender, string name)
        {
        }
    }
}