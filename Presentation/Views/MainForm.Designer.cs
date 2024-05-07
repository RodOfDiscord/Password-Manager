namespace Presentation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            profileNameLabel = new Label();
            passwordsDataGridView = new DataGridView();
            textBox1 = new TextBox();
            addButton = new Button();
            operationsMenuStrip = new ContextMenuStrip(components);
            editNoteMenuItem = new ToolStripMenuItem();
            deleteNoteMenuItem = new ToolStripMenuItem();
            categoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)passwordsDataGridView).BeginInit();
            operationsMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // profileNameLabel
            // 
            profileNameLabel.AutoSize = true;
            profileNameLabel.Dock = DockStyle.Top;
            profileNameLabel.Location = new Point(0, 0);
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Size = new Size(0, 20);
            profileNameLabel.TabIndex = 0;
            // 
            // passwordsDataGridView
            // 
            passwordsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            passwordsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passwordsDataGridView.Location = new Point(14, 69);
            passwordsDataGridView.Margin = new Padding(3, 4, 3, 4);
            passwordsDataGridView.Name = "passwordsDataGridView";
            passwordsDataGridView.RowHeadersWidth = 51;
            passwordsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            passwordsDataGridView.Size = new Size(642, 445);
            passwordsDataGridView.TabIndex = 1;
            passwordsDataGridView.MouseClick += PasswordsDataGridView_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(185, 31);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.MaximumSize = new Size(285, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Location = new Point(539, 523);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(117, 64);
            addButton.TabIndex = 3;
            addButton.Text = "Add Note";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // operationsMenuStrip
            // 
            operationsMenuStrip.ImageScalingSize = new Size(20, 20);
            operationsMenuStrip.Items.AddRange(new ToolStripItem[] { editNoteMenuItem, deleteNoteMenuItem });
            operationsMenuStrip.Name = "operationsMenuStrip";
            operationsMenuStrip.Size = new Size(123, 52);
            // 
            // editNoteMenuItem
            // 
            editNoteMenuItem.Name = "editNoteMenuItem";
            editNoteMenuItem.Size = new Size(122, 24);
            editNoteMenuItem.Text = "Edit";
            editNoteMenuItem.Click += EditNoteMenuItem_Click;
            // 
            // deleteNoteMenuItem
            // 
            deleteNoteMenuItem.Name = "deleteNoteMenuItem";
            deleteNoteMenuItem.Size = new Size(122, 24);
            deleteNoteMenuItem.Text = "Delete";
            deleteNoteMenuItem.Click += DeleteNoteMenuItem_Click;
            // 
            // categoryButton
            // 
            categoryButton.Location = new Point(14, 523);
            categoryButton.Margin = new Padding(3, 4, 3, 4);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(117, 64);
            categoryButton.TabIndex = 4;
            categoryButton.Text = "Manage Categories";
            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.Click += categoryButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 603);
            Controls.Add(categoryButton);
            Controls.Add(addButton);
            Controls.Add(textBox1);
            Controls.Add(passwordsDataGridView);
            Controls.Add(profileNameLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)passwordsDataGridView).EndInit();
            operationsMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileNameLabel;
        private DataGridView passwordsDataGridView;
        private TextBox textBox1;
        private Button addButton;
        private ContextMenuStrip operationsMenuStrip;
        private ToolStripMenuItem editNoteMenuItem;
        private ToolStripMenuItem deleteNoteMenuItem;
        private Button categoryButton;
    }
}
