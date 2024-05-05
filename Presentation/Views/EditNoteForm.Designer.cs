namespace Presentation.Views
{
    partial class EditNoteForm
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
            buttonAddNote = new Button();
            pictureBoxClosePassword = new PictureBox();
            pictureBoxOpenPassword = new PictureBox();
            richTextBoxNoteDescription = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxNameNote = new TextBox();
            categoryComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpenPassword).BeginInit();
            SuspendLayout();
            // 
            // buttonAddNote
            // 
            buttonAddNote.Location = new Point(80, 291);
            buttonAddNote.Margin = new Padding(4);
            buttonAddNote.Name = "buttonAddNote";
            buttonAddNote.Size = new Size(115, 51);
            buttonAddNote.TabIndex = 34;
            buttonAddNote.Text = "Save";
            buttonAddNote.UseVisualStyleBackColor = true;
            // 
            // pictureBoxClosePassword
            // 
            pictureBoxClosePassword.Location = new Point(270, 79);
            pictureBoxClosePassword.Margin = new Padding(4);
            pictureBoxClosePassword.Name = "pictureBoxClosePassword";
            pictureBoxClosePassword.Size = new Size(24, 23);
            pictureBoxClosePassword.TabIndex = 33;
            pictureBoxClosePassword.TabStop = false;
            // 
            // pictureBoxOpenPassword
            // 
            pictureBoxOpenPassword.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxOpenPassword.Location = new Point(270, 79);
            pictureBoxOpenPassword.Margin = new Padding(4);
            pictureBoxOpenPassword.Name = "pictureBoxOpenPassword";
            pictureBoxOpenPassword.Size = new Size(24, 23);
            pictureBoxOpenPassword.TabIndex = 32;
            pictureBoxOpenPassword.TabStop = false;
            // 
            // richTextBoxNoteDescription
            // 
            richTextBoxNoteDescription.Location = new Point(17, 184);
            richTextBoxNoteDescription.Margin = new Padding(4);
            richTextBoxNoteDescription.Name = "richTextBoxNoteDescription";
            richTextBoxNoteDescription.Size = new Size(246, 84);
            richTextBoxNoteDescription.TabIndex = 31;
            richTextBoxNoteDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 30;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 29;
            label6.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 61);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 27;
            label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(17, 79);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(246, 23);
            textBoxPassword.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 25;
            label3.Text = "Username";
            // 
            // textBoxNameNote
            // 
            textBoxNameNote.Location = new Point(17, 27);
            textBoxNameNote.Margin = new Padding(4);
            textBoxNameNote.Name = "textBoxNameNote";
            textBoxNameNote.Size = new Size(246, 23);
            textBoxNameNote.TabIndex = 24;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(17, 132);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(246, 23);
            categoryComboBox.TabIndex = 35;
            // 
            // EditNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 361);
            Controls.Add(categoryComboBox);
            Controls.Add(buttonAddNote);
            Controls.Add(pictureBoxClosePassword);
            Controls.Add(pictureBoxOpenPassword);
            Controls.Add(richTextBoxNoteDescription);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxNameNote);
            MaximumSize = new Size(320, 400);
            MinimumSize = new Size(320, 400);
            Name = "EditNoteForm";
            Text = "EditNoteForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpenPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddNote;
        private PictureBox pictureBoxClosePassword;
        private PictureBox pictureBoxOpenPassword;
        private RichTextBox richTextBoxNoteDescription;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxNameNote;
        private ComboBox categoryComboBox;
    }
}