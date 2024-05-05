namespace Presentation.Views
{
    partial class NoteFormUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            errorLabel = new Label();
            categoryComboBox = new ComboBox();
            submitButton = new Button();
            pictureBoxClosePassword = new PictureBox();
            pictureBoxOpenPassword = new PictureBox();
            richTextBoxNoteDescription = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxNameNote = new TextBox();
            EmailLabel = new Label();
            emailTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpenPassword).BeginInit();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(29, 345);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(246, 15);
            errorLabel.TabIndex = 60;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(29, 199);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(246, 23);
            categoryComboBox.TabIndex = 59;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(91, 372);
            submitButton.Margin = new Padding(4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(115, 51);
            submitButton.TabIndex = 58;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // pictureBoxClosePassword
            // 
            pictureBoxClosePassword.Location = new Point(251, 146);
            pictureBoxClosePassword.Margin = new Padding(4);
            pictureBoxClosePassword.Name = "pictureBoxClosePassword";
            pictureBoxClosePassword.Size = new Size(24, 23);
            pictureBoxClosePassword.TabIndex = 57;
            pictureBoxClosePassword.TabStop = false;
            // 
            // pictureBoxOpenPassword
            // 
            pictureBoxOpenPassword.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxOpenPassword.Location = new Point(251, 146);
            pictureBoxOpenPassword.Margin = new Padding(4);
            pictureBoxOpenPassword.Name = "pictureBoxOpenPassword";
            pictureBoxOpenPassword.Size = new Size(24, 23);
            pictureBoxOpenPassword.TabIndex = 56;
            pictureBoxOpenPassword.TabStop = false;
            // 
            // richTextBoxNoteDescription
            // 
            richTextBoxNoteDescription.Location = new Point(29, 251);
            richTextBoxNoteDescription.Margin = new Padding(4);
            richTextBoxNoteDescription.Name = "richTextBoxNoteDescription";
            richTextBoxNoteDescription.Size = new Size(246, 84);
            richTextBoxNoteDescription.TabIndex = 55;
            richTextBoxNoteDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 233);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 54;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 181);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 53;
            label6.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 127);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 52;
            label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(29, 146);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(214, 23);
            textBoxPassword.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 50;
            label3.Text = "Username";
            // 
            // textBoxNameNote
            // 
            textBoxNameNote.Location = new Point(29, 42);
            textBoxNameNote.Margin = new Padding(4);
            textBoxNameNote.Name = "textBoxNameNote";
            textBoxNameNote.Size = new Size(246, 23);
            textBoxNameNote.TabIndex = 49;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(29, 74);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 62;
            EmailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(29, 92);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(246, 23);
            emailTextBox.TabIndex = 61;
            // 
            // NoteFormUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EmailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(errorLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(submitButton);
            Controls.Add(pictureBoxClosePassword);
            Controls.Add(pictureBoxOpenPassword);
            Controls.Add(richTextBoxNoteDescription);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxNameNote);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 450);
            Name = "NoteFormUC";
            Size = new Size(300, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpenPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private ComboBox categoryComboBox;
        private Button submitButton;
        private PictureBox pictureBoxClosePassword;
        private PictureBox pictureBoxOpenPassword;
        private RichTextBox richTextBoxNoteDescription;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxNameNote;
        private Label EmailLabel;
        private TextBox emailTextBox;
    }
}
