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
            addButton = new Button();
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
            groupBox.Controls.Add(addButton);
            groupBox.Controls.Add(passwordTextBox);
            groupBox.Controls.Add(profilesComboBox);
            groupBox.Controls.Add(messageLabel);
            groupBox.Controls.Add(buttonLogin);
            groupBox.Location = new Point(232, 120);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(439, 295);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Login";
            // 
            // addButton
            // 
            addButton.Location = new Point(155, 228);
            addButton.Name = "addButton";
            addButton.Size = new Size(131, 29);
            addButton.TabIndex = 4;
            addButton.Text = "Add new Profile";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(113, 88);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(221, 27);
            passwordTextBox.TabIndex = 6;
            // 
            // profilesComboBox
            // 
            profilesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            profilesComboBox.FormattingEnabled = true;
            profilesComboBox.Location = new Point(113, 29);
            profilesComboBox.Margin = new Padding(3, 4, 3, 4);
            profilesComboBox.Name = "profilesComboBox";
            profilesComboBox.Size = new Size(221, 28);
            profilesComboBox.TabIndex = 5;
            // 
            // messageLabel
            // 
            messageLabel.Dock = DockStyle.Bottom;
            messageLabel.Location = new Point(3, 271);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(433, 20);
            messageLabel.TabIndex = 3;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(129, 173);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(182, 31);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 593);
            Controls.Add(groupBox);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button addButton;
    }
}