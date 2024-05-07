namespace Presentation.Views
{
    partial class AddCategoryForm
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
            nameTextBox = new TextBox();
            addButton = new Button();
            DescriptionRichTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 37);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(316, 27);
            nameTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(85, 190);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 51);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(12, 100);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(316, 84);
            DescriptionRichTextBox.TabIndex = 2;
            DescriptionRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Descroption";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(addButton);
            Controls.Add(nameTextBox);
            MaximumSize = new Size(357, 308);
            MinimumSize = new Size(357, 308);
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Button addButton;
        private RichTextBox DescriptionRichTextBox;
        private Label label1;
        private Label label2;
    }
}