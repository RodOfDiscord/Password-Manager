namespace Presentation.Views
{
    partial class PasswordInputUC
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
            passwordVisiblebutton = new Button();
            label4 = new Label();
            textBoxPassword = new TextBox();
            generatePassButton = new Button();
            SuspendLayout();
            // 
            // passwordVisiblebutton
            // 
            passwordVisiblebutton.Anchor = AnchorStyles.None;
            passwordVisiblebutton.BackgroundImage = Resources.hide;
            passwordVisiblebutton.BackgroundImageLayout = ImageLayout.Stretch;
            passwordVisiblebutton.Location = new Point(257, 28);
            passwordVisiblebutton.Margin = new Padding(3, 4, 3, 4);
            passwordVisiblebutton.Name = "passwordVisiblebutton";
            passwordVisiblebutton.Size = new Size(34, 33);
            passwordVisiblebutton.TabIndex = 66;
            passwordVisiblebutton.UseVisualStyleBackColor = true;
            passwordVisiblebutton.Click += passwordVisiblebutton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(8, 3);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 65;
            label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(11, 30);
            textBoxPassword.Margin = new Padding(5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(244, 27);
            textBoxPassword.TabIndex = 64;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // generatePassButton
            // 
            generatePassButton.Anchor = AnchorStyles.None;
            generatePassButton.BackgroundImage = Resources.dice;
            generatePassButton.BackgroundImageLayout = ImageLayout.Stretch;
            generatePassButton.Location = new Point(297, 28);
            generatePassButton.Margin = new Padding(3, 4, 3, 4);
            generatePassButton.Name = "generatePassButton";
            generatePassButton.Size = new Size(34, 33);
            generatePassButton.TabIndex = 67;
            generatePassButton.UseVisualStyleBackColor = true;
            generatePassButton.Click += generatePassButton_Click;
            // 
            // PasswordInputUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(generatePassButton);
            Controls.Add(passwordVisiblebutton);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Name = "PasswordInputUC";
            Size = new Size(339, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button passwordVisiblebutton;
        private Label label4;
        private TextBox textBoxPassword;
        private Button generatePassButton;
    }
}
