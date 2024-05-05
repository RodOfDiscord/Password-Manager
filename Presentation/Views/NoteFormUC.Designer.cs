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
            richTextBoxNoteDescription = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxNameNote = new TextBox();
            EmailLabel = new Label();
            emailTextBox = new TextBox();
            passwordVisiblebutton = new Button();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.None;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(5, 326);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(246, 15);
            errorLabel.TabIndex = 60;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.None;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(5, 180);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(246, 23);
            categoryComboBox.TabIndex = 59;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.Location = new Point(67, 351);
            submitButton.Margin = new Padding(4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(115, 51);
            submitButton.TabIndex = 58;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // richTextBoxNoteDescription
            // 
            richTextBoxNoteDescription.Anchor = AnchorStyles.None;
            richTextBoxNoteDescription.Location = new Point(5, 232);
            richTextBoxNoteDescription.Margin = new Padding(4);
            richTextBoxNoteDescription.Name = "richTextBoxNoteDescription";
            richTextBoxNoteDescription.Size = new Size(246, 84);
            richTextBoxNoteDescription.TabIndex = 55;
            richTextBoxNoteDescription.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(1, 214);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 54;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(5, 162);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 53;
            label6.Text = "Category";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(5, 108);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 52;
            label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(5, 127);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(214, 23);
            textBoxPassword.TabIndex = 51;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(5, 4);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 50;
            label3.Text = "Username";
            // 
            // textBoxNameNote
            // 
            textBoxNameNote.Anchor = AnchorStyles.None;
            textBoxNameNote.Location = new Point(5, 23);
            textBoxNameNote.Margin = new Padding(4);
            textBoxNameNote.Name = "textBoxNameNote";
            textBoxNameNote.Size = new Size(246, 23);
            textBoxNameNote.TabIndex = 49;
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.None;
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(5, 55);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 62;
            EmailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(5, 73);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(246, 23);
            emailTextBox.TabIndex = 61;
            // 
            // passwordVisiblebutton
            // 
            passwordVisiblebutton.Anchor = AnchorStyles.None;
            passwordVisiblebutton.BackgroundImage = Resources.hide;
            passwordVisiblebutton.BackgroundImageLayout = ImageLayout.Stretch;
            passwordVisiblebutton.Location = new Point(221, 127);
            passwordVisiblebutton.Name = "passwordVisiblebutton";
            passwordVisiblebutton.Size = new Size(30, 25);
            passwordVisiblebutton.TabIndex = 63;
            passwordVisiblebutton.UseVisualStyleBackColor = true;
            passwordVisiblebutton.Click += passwordVisiblebutton_Click;
            // 
            // NoteFormUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(passwordVisiblebutton);
            Controls.Add(EmailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(errorLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(submitButton);
            Controls.Add(richTextBoxNoteDescription);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxNameNote);
            Name = "NoteFormUC";
            Size = new Size(256, 406);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private ComboBox categoryComboBox;
        private Button submitButton;
        private RichTextBox richTextBoxNoteDescription;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxNameNote;
        private Label EmailLabel;
        private TextBox emailTextBox;
        private Button passwordVisiblebutton;
    }
}
