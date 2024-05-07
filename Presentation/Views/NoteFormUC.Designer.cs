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
            errorLabel.Location = new Point(6, 435);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(281, 20);
            errorLabel.TabIndex = 60;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.None;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(6, 240);
            categoryComboBox.Margin = new Padding(3, 4, 3, 4);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(281, 28);
            categoryComboBox.TabIndex = 59;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.Location = new Point(77, 468);
            submitButton.Margin = new Padding(5, 5, 5, 5);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(131, 68);
            submitButton.TabIndex = 58;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // richTextBoxNoteDescription
            // 
            richTextBoxNoteDescription.Anchor = AnchorStyles.None;
            richTextBoxNoteDescription.Location = new Point(6, 309);
            richTextBoxNoteDescription.Margin = new Padding(5, 5, 5, 5);
            richTextBoxNoteDescription.Name = "richTextBoxNoteDescription";
            richTextBoxNoteDescription.Size = new Size(281, 111);
            richTextBoxNoteDescription.TabIndex = 55;
            richTextBoxNoteDescription.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(1, 285);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 54;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(6, 216);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 53;
            label6.Text = "Category";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(6, 144);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 52;
            label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(6, 169);
            textBoxPassword.Margin = new Padding(5, 5, 5, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(244, 27);
            textBoxPassword.TabIndex = 51;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(6, 5);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 50;
            label3.Text = "Username";
            // 
            // textBoxNameNote
            // 
            textBoxNameNote.Anchor = AnchorStyles.None;
            textBoxNameNote.Location = new Point(6, 31);
            textBoxNameNote.Margin = new Padding(5, 5, 5, 5);
            textBoxNameNote.Name = "textBoxNameNote";
            textBoxNameNote.Size = new Size(281, 27);
            textBoxNameNote.TabIndex = 49;
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.None;
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(6, 73);
            EmailLabel.Margin = new Padding(5, 0, 5, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 62;
            EmailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(6, 97);
            emailTextBox.Margin = new Padding(5, 5, 5, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(281, 27);
            emailTextBox.TabIndex = 61;
            // 
            // passwordVisiblebutton
            // 
            passwordVisiblebutton.Anchor = AnchorStyles.None;
            passwordVisiblebutton.BackgroundImage = Resources.hide;
            passwordVisiblebutton.BackgroundImageLayout = ImageLayout.Stretch;
            passwordVisiblebutton.Location = new Point(253, 169);
            passwordVisiblebutton.Margin = new Padding(3, 4, 3, 4);
            passwordVisiblebutton.Name = "passwordVisiblebutton";
            passwordVisiblebutton.Size = new Size(34, 33);
            passwordVisiblebutton.TabIndex = 63;
            passwordVisiblebutton.UseVisualStyleBackColor = true;
            passwordVisiblebutton.Click += passwordVisiblebutton_Click;
            // 
            // NoteFormUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "NoteFormUC";
            Size = new Size(293, 541);
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
