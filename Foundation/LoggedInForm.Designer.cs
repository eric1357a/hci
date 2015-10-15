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
            this.btn_Panel = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lb_User = new System.Windows.Forms.Label();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.btn_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Controls.Add(this.lb_User);
            this.BaseNavigationAction.Controls.Add(this.btn_Panel);
            this.BaseNavigationAction.Location = new System.Drawing.Point(360, 0);
            this.BaseNavigationAction.Margin = new System.Windows.Forms.Padding(0);
            this.BaseNavigationAction.Size = new System.Drawing.Size(360, 54);
            // 
            // btn_Panel
            // 
            this.btn_Panel.Controls.Add(this.btn_Logout);
            this.btn_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Panel.Location = new System.Drawing.Point(252, 0);
            this.btn_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Panel.Name = "btn_Panel";
            this.btn_Panel.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.btn_Panel.Size = new System.Drawing.Size(108, 54);
            this.btn_Panel.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(16, 12);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(76, 30);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lb_User
            // 
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_User.Location = new System.Drawing.Point(0, 0);
            this.lb_User.Margin = new System.Windows.Forms.Padding(0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(252, 54);
            this.lb_User.TabIndex = 5;
            this.lb_User.Text = "XXX(YYY)";
            this.lb_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoggedInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "LoggedInForm";
            this.Text = "LoggedIn";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            this.btn_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btn_Panel;
        public System.Windows.Forms.Button btn_Logout;
        public System.Windows.Forms.Label lb_User;
    }
}