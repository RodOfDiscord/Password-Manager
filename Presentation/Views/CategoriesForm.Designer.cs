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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 600);
            panel1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(29, 535);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(166, 49);
            addButton.TabIndex = 3;
            addButton.Text = "Add New";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LightCoral;
            deleteButton.Location = new Point(29, 128);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(166, 49);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.CornflowerBlue;
            updateButton.Location = new Point(29, 71);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(166, 49);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(29, 32);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(165, 27);
            nameTextBox.TabIndex = 0;
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesDataGridView.Dock = DockStyle.Fill;
            categoriesDataGridView.Location = new Point(229, 0);
            categoriesDataGridView.Margin = new Padding(3, 4, 3, 4);
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.ReadOnly = true;
            categoriesDataGridView.RowHeadersWidth = 51;
            categoriesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriesDataGridView.Size = new Size(685, 600);
            categoriesDataGridView.TabIndex = 1;
            categoriesDataGridView.CellClick += categoriesDataGridView_CellClick;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(categoriesDataGridView);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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