using Domain;

namespace Presentation.Views
{
    public partial class PasswordInputUC : UserControl
    {
        public PasswordInputUC()
        {
            InitializeComponent();
        }

        public string PasswordText
        {
            get
            {
                return textBoxPassword.Text;
            }
            set
            {
                textBoxPassword.Text = value;
            }
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

        private void generatePassButton_Click(object sender, EventArgs e)
        {
            PasswordGenerator generator = new PasswordGenerator();
            generator.IncludeUppercase().IncludeDigits();
            textBoxPassword.Text = generator.Generate(new Random().Next(8, 16));
        }
    }
}
