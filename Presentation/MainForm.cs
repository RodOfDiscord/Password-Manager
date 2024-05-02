using Domain.Cipher;

namespace Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EncryptionService cipher = new EncryptionService(EncryptionKeyGenerator.Generate());
            string text = "sayronXD";
            MessageBox.Show(cipher.Decrypt(cipher.Encrypt(text)));
        }
    }
}
