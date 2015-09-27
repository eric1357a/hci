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
            this.LoginControlsWrapper = new System.Windows.Forms.Panel();
            this.LoginLabelPassword = new System.Windows.Forms.Label();
            this.LoginLabelUsername = new System.Windows.Forms.Label();
            this.LoginControlsWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginControlsWrapper
            // 
            this.LoginControlsWrapper.Controls.Add(this.LoginLabelPassword);
            this.LoginControlsWrapper.Controls.Add(this.LoginLabelUsername);
            this.LoginControlsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginControlsWrapper.Location = new System.Drawing.Point(0, 80);
            this.LoginControlsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.LoginControlsWrapper.Name = "LoginControlsWrapper";
            this.LoginControlsWrapper.Size = new System.Drawing.Size(480, 240);
            this.LoginControlsWrapper.TabIndex = 1;
            // 
            // LoginLabelPassword
            // 
            this.LoginLabelPassword.AutoSize = true;
            this.LoginLabelPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoginLabelPassword.Location = new System.Drawing.Point(89, 124);
            this.LoginLabelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.LoginLabelPassword.Name = "LoginLabelPassword";
            this.LoginLabelPassword.Size = new System.Drawing.Size(80, 20);
            this.LoginLabelPassword.TabIndex = 1;
            this.LoginLabelPassword.Text = "Password";
            this.LoginLabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginLabelUsername
            // 
            this.LoginLabelUsername.AutoSize = true;
            this.LoginLabelUsername.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoginLabelUsername.Location = new System.Drawing.Point(89, 76);
            this.LoginLabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabelUsername.Name = "LoginLabelUsername";
            this.LoginLabelUsername.Size = new System.Drawing.Size(86, 20);
            this.LoginLabelUsername.TabIndex = 0;
            this.LoginLabelUsername.Text = "Username";
            this.LoginLabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.LoginControlsWrapper);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Controls.SetChildIndex(this.LoginControlsWrapper, 0);
            this.LoginControlsWrapper.ResumeLayout(false);
            this.LoginControlsWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginControlsWrapper;
        private System.Windows.Forms.Label LoginLabelUsername;
        private System.Windows.Forms.Label LoginLabelPassword;
    }
}