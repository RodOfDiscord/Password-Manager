namespace Presentation.Views
{
    partial class LoginForm
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
            groupBox = new GroupBox();
            passwordTextBox = new TextBox();
            profilesComboBox = new ComboBox();
            messageLabel = new Label();
            buttonLogin = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.None;
            groupBox.Controls.Add(passwordTextBox);
            groupBox.Controls.Add(profilesComboBox);
            groupBox.Controls.Add(messageLabel);
            groupBox.Controls.Add(buttonLogin);
            groupBox.Location = new Point(203, 90);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(384, 221);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Login";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(99, 66);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(194, 23);
            passwordTextBox.TabIndex = 6;
            // 
            // profilesComboBox
            // 
            profilesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            profilesComboBox.FormattingEnabled = true;
            profilesComboBox.Location = new Point(99, 22);
            profilesComboBox.Name = "profilesComboBox";
            profilesComboBox.Size = new Size(194, 23);
            profilesComboBox.TabIndex = 5;
            // 
            // messageLabel
            // 
            messageLabel.Dock = DockStyle.Bottom;
            messageLabel.Location = new Point(3, 203);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(378, 15);
            messageLabel.TabIndex = 3;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(113, 168);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(159, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 445);
            Controls.Add(groupBox);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label messageLabel;
        private Button buttonLogin;
        private ComboBox profilesComboBox;
        private TextBox passwordTextBox;
    }
}