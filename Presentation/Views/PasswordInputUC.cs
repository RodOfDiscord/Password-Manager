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
            get => textBoxPassword.Text;
            set => textBoxPassword.Text = value;
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
            textBoxPassword.Text = new PasswordGenerator().IncludeUppercase()
                                                          .IncludeDigits()
                                                          .IncludeSpecialSymbols()
                                                          .Generate(new Random().Next(8, 16));
        }
    }
}   
