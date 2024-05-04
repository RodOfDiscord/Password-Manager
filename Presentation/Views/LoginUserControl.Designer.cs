namespace Presentation.Views
{
    partial class LoginUserControl
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
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            groupBox = new GroupBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.Location = new Point(67, 71);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(6, 22);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(188, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(buttonLogin);
            groupBox.Controls.Add(textBoxPassword);
            groupBox.Location = new Point(122, 91);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(200, 100);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "groupBox1";
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "LoginUserControl";
            Size = new Size(449, 319);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxPassword;
        private GroupBox groupBox;
    }
}
