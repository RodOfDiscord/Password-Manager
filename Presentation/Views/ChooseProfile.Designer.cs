namespace Presentation
{
    partial class ChooseProfile
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
            loginPanel = new Panel();
            flowLayoutProfilePanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(784, 450);
            loginPanel.TabIndex = 1;
            // 
            // flowLayoutProfilePanel
            // 
            flowLayoutProfilePanel.AutoSize = true;
            flowLayoutProfilePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutProfilePanel.Location = new Point(0, 0);
            flowLayoutProfilePanel.Name = "flowLayoutProfilePanel";
            flowLayoutProfilePanel.Size = new Size(0, 0);
            flowLayoutProfilePanel.TabIndex = 2;
            // 
            // ChooseProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(flowLayoutProfilePanel);
            Controls.Add(loginPanel);
            Name = "ChooseProfile";
            Text = "ProfileLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel loginPanel;
        private FlowLayoutPanel flowLayoutProfilePanel;
    }
}