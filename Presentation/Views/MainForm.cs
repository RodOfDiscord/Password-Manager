using Domain;
using Presentation.Views;

namespace Presentation
{
    public partial class MainForm : Form, IMainView
    {
        DataGridViewRow? selectedRow;
        public event EventHandler<Guid>? DeleteNote;
        public event EventHandler<Guid>? EditNote;
        public event EventHandler? AddNote;
        public event EventHandler? ManageCategories;

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

        public void FillDataGridView(IEnumerable<Note> notes)
        {
            if (notes is not null)
            {
                var noteDtoList = notes.Select(n => new
                {
                    n.UserName,
                    n.Email,
                    n.Description,
                    n.CreatedAt,
                    Category = n.Category?.Name,
                    n.Id
                });

                var source = new BindingSource
                {
                    DataSource = noteDtoList.ToList()
                };
                passwordsDataGridView.AutoGenerateColumns = true;
                passwordsDataGridView.DataSource = source;
                passwordsDataGridView.Columns["Id"].Visible = false;
            }
        }

        private void PasswordsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = passwordsDataGridView.HitTest(e.X, e.Y).RowIndex;
                passwordsDataGridView.ClearSelection();
                if (currentMouseOverRow != -1)
                {
                    operationsMenuStrip.Show(passwordsDataGridView, new Point(e.X, e.Y));
                    selectedRow = passwordsDataGridView.Rows[currentMouseOverRow];
                    selectedRow.Selected = true;
                }
            }
        }

        private void EditNoteMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                Guid noteId = (Guid)selectedRow.Cells["Id"].Value;
                EditNote?.Invoke(sender, noteId);
            }

        }

        private void DeleteNoteMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                Guid noteId = (Guid)selectedRow.Cells["Id"].Value;
                DeleteNote?.Invoke(sender, noteId);
            }
        }

        public void ClearTable()
        {
            passwordsDataGridView.Rows.Clear();
            passwordsDataGridView.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNote?.Invoke(this, EventArgs.Empty);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            ManageCategories?.Invoke(this, EventArgs.Empty);
        }
    }
}
