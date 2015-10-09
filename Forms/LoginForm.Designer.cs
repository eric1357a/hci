namespace HCI.Forms
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
            this.LoginLabelUsername = new System.Windows.Forms.Label();
            this.LoginLabelPassword = new System.Windows.Forms.Label();
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Login";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(480, 266);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(480, 66);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.LoginPassword);
            this.BaseContentWrapper.Controls.Add(this.LoginLabelUsername);
            this.BaseContentWrapper.Controls.Add(this.LoginButton);
            this.BaseContentWrapper.Controls.Add(this.LoginLabelPassword);
            this.BaseContentWrapper.Controls.Add(this.LoginUsername);
            this.BaseContentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseContentWrapper.Size = new System.Drawing.Size(480, 200);
            // 
            // LoginLabelUsername
            // 
            this.LoginLabelUsername.AutoSize = true;
            this.LoginLabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabelUsername.Location = new System.Drawing.Point(78, 31);
            this.LoginLabelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.LoginLabelUsername.Name = "LoginLabelUsername";
            this.LoginLabelUsername.Size = new System.Drawing.Size(107, 25);
            this.LoginLabelUsername.TabIndex = 0;
            this.LoginLabelUsername.Text = "Username";
            this.LoginLabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginLabelPassword
            // 
            this.LoginLabelPassword.AutoSize = true;
            this.LoginLabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabelPassword.Location = new System.Drawing.Point(78, 75);
            this.LoginLabelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LoginLabelPassword.Name = "LoginLabelPassword";
            this.LoginLabelPassword.Size = new System.Drawing.Size(102, 25);
            this.LoginLabelPassword.TabIndex = 1;
            this.LoginLabelPassword.Text = "Password";
            this.LoginLabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginUsername
            // 
            this.LoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.LoginUsername.Location = new System.Drawing.Point(210, 31);
            this.LoginUsername.Margin = new System.Windows.Forms.Padding(0);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(179, 27);
            this.LoginUsername.TabIndex = 2;
            // 
            // LoginPassword
            // 
            this.LoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.LoginPassword.Location = new System.Drawing.Point(210, 75);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '．';
            this.LoginPassword.Size = new System.Drawing.Size(179, 27);
            this.LoginPassword.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.LoginButton.Location = new System.Drawing.Point(307, 127);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(82, 36);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.TextBox LoginUsername;
        private System.Windows.Forms.Label LoginLabelPassword;
        private System.Windows.Forms.Label LoginLabelUsername;
        private System.Windows.Forms.Button LoginButton;

    }
}