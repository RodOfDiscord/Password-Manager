using Domain;

namespace Presentation.Views
{
    public partial class AddCategoryForm : Form, IAddCategoryView
    {
        public event EventHandler<Category>? AddCategory;

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) && string.IsNullOrEmpty(DescriptionRichTextBox.Text))
            {
                MessageBox.Show("Name and Description must be not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Category category = new Category();
            category.Name = nameTextBox.Text;
            category.Description = DescriptionRichTextBox.Text;
            AddCategory?.Invoke(this, category);
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
