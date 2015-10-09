namespace HCI.Foundation
{
    partial class LoggedInForm
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.LogoutPanel = new System.Windows.Forms.Panel();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.LogoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Controls.Add(this.LogoutPanel);
            this.BaseNavigation.Controls.SetChildIndex(this.BaseNavigationText, 0);
            this.BaseNavigation.Controls.SetChildIndex(this.LogoutPanel, 0);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Location = new System.Drawing.Point(5, 10);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(97, 46);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // LogoutPanel
            // 
            this.LogoutPanel.Controls.Add(this.btn_Logout);
            this.LogoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutPanel.Location = new System.Drawing.Point(613, 0);
            this.LogoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.LogoutPanel.Name = "LogoutPanel";
            this.LogoutPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.LogoutPanel.Size = new System.Drawing.Size(107, 66);
            this.LogoutPanel.TabIndex = 0;
            // 
            // LoggedInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "LoggedInForm";
            this.Text = "LoggedIn";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.LogoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel LogoutPanel;
    }
}