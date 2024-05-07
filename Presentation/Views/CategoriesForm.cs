using Domain;

namespace Presentation.Views
{
    public partial class CategoriesForm : Form, ICategoriesView
    {
        private Guid selectedCategoryId;
        public CategoriesForm()
        {
            InitializeComponent();
        }

        public event EventHandler<Guid>? DeleteCategory;

        public event EventHandler<(Guid, string)>? UpdateCategory;
        public event EventHandler? AddCategory;

        public void PopulateCategories(List<Category> categories)
        {
            if (categories is not null)
            {
                var noteDtoList = categories.Select(c => new
                {
                    c.Name,
                    c.Description,
                    c.Id
                });

                var source = new BindingSource
                {
                    DataSource = noteDtoList.ToList()
                };
                categoriesDataGridView.AutoGenerateColumns = true;
                categoriesDataGridView.DataSource = source;
                categoriesDataGridView.Columns["Id"].Visible = false;
            }
        }

        private void categoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nameTextBox.Text = categoriesDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                selectedCategoryId = (Guid)categoriesDataGridView.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || selectedCategoryId == Guid.Empty)
            {
                MessageBox.Show("Category is not selected to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateCategory?.Invoke(this, (selectedCategoryId, nameTextBox.Text));
            ResetInputs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteCategory?.Invoke(this, selectedCategoryId);
            ResetInputs();
        }

        private void ResetInputs()
        {
            nameTextBox.Text = string.Empty;
            selectedCategoryId = Guid.Empty;
            categoriesDataGridView.ClearSelection();
        }

        public void ClearTable()
        {
            categoriesDataGridView.Rows.Clear();
            categoriesDataGridView.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCategory?.Invoke(this, EventArgs.Empty);
        }
    }
}