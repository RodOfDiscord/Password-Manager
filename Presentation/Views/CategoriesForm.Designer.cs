namespace Presentation.Views
{
    partial class CategoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            addButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            nameTextBox = new TextBox();
            categoriesDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(nameTextBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(25, 401);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 37);
            addButton.TabIndex = 3;
            addButton.Text = "Add New";
            addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LightCoral;
            deleteButton.Location = new Point(25, 96);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(145, 37);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.CornflowerBlue;
            updateButton.Location = new Point(25, 53);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(145, 37);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(25, 24);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(145, 23);
            nameTextBox.TabIndex = 0;
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesDataGridView.Dock = DockStyle.Fill;
            categoriesDataGridView.Location = new Point(200, 0);
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.ReadOnly = true;
            categoriesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriesDataGridView.Size = new Size(600, 450);
            categoriesDataGridView.TabIndex = 1;
            categoriesDataGridView.CellClick += categoriesDataGridView_CellClick;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(categoriesDataGridView);
            Controls.Add(panel1);
            Name = "CategoriesForm";
            Text = "CategoriesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox nameTextBox;
        private DataGridView categoriesDataGridView;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
    }
}