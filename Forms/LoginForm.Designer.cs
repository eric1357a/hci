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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoginButtonLogin = new System.Windows.Forms.Button();
            this.LoginLabelPassword = new System.Windows.Forms.Label();
            this.LoginLabelUsername = new System.Windows.Forms.Label();
            this.LoginControlsWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginControlsWrapper
            // 
            this.LoginControlsWrapper.Controls.Add(this.textBox2);
            this.LoginControlsWrapper.Controls.Add(this.textBox1);
            this.LoginControlsWrapper.Controls.Add(this.LoginButtonLogin);
            this.LoginControlsWrapper.Controls.Add(this.LoginLabelPassword);
            this.LoginControlsWrapper.Controls.Add(this.LoginLabelUsername);
            this.LoginControlsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginControlsWrapper.Location = new System.Drawing.Point(0, 80);
            this.LoginControlsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.LoginControlsWrapper.Name = "LoginControlsWrapper";
            this.LoginControlsWrapper.Size = new System.Drawing.Size(480, 240);
            this.LoginControlsWrapper.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.textBox2.Location = new System.Drawing.Point(212, 87);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.textBox1.Location = new System.Drawing.Point(212, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 3;
            // 
            // LoginButtonLogin
            // 
            this.LoginButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButtonLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.LoginButtonLogin.Location = new System.Drawing.Point(321, 152);
            this.LoginButtonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButtonLogin.Name = "LoginButtonLogin";
            this.LoginButtonLogin.Size = new System.Drawing.Size(80, 31);
            this.LoginButtonLogin.TabIndex = 2;
            this.LoginButtonLogin.Text = "Login";
            this.LoginButtonLogin.UseVisualStyleBackColor = true;
            this.LoginButtonLogin.Click += new System.EventHandler(this.LoginButtonLogin_Click);
            // 
            // LoginLabelPassword
            // 
            this.LoginLabelPassword.AutoSize = true;
            this.LoginLabelPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoginLabelPassword.Location = new System.Drawing.Point(75, 87);
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
            this.LoginLabelUsername.Location = new System.Drawing.Point(75, 42);
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
        private System.Windows.Forms.Button LoginButtonLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}