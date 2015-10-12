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
            this.lb_User = new System.Windows.Forms.Label();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Controls.Add(this.lb_User);
            this.BaseNavigationAction.Controls.Add(this.btn_Logout);
            this.BaseNavigationAction.Location = new System.Drawing.Point(360, 0);
            this.BaseNavigationAction.Size = new System.Drawing.Size(360, 54);
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(263, 10);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(94, 38);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lb_User
            // 
            this.lb_User.Location = new System.Drawing.Point(15, 18);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(242, 23);
            this.lb_User.TabIndex = 1;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_User;
        public System.Windows.Forms.Button btn_Logout;
    }
}