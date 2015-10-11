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
            this.BaseNavigationAction = new System.Windows.Forms.Panel();
            this.lb_User = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Controls.Add(this.BaseNavigationAction);
            this.BaseNavigation.Controls.SetChildIndex(this.BaseNavigationAction, 0);
            this.BaseNavigation.Controls.SetChildIndex(this.BaseNavigationText, 0);
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Controls.Add(this.lb_User);
            this.BaseNavigationAction.Controls.Add(this.panel1);
            this.BaseNavigationAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseNavigationAction.Location = new System.Drawing.Point(0, 0);
            this.BaseNavigationAction.Margin = new System.Windows.Forms.Padding(0);
            this.BaseNavigationAction.Name = "BaseNavigationAction";
            this.BaseNavigationAction.Size = new System.Drawing.Size(720, 54);
            this.BaseNavigationAction.TabIndex = 0;
            // 
            // lb_User
            // 
            this.lb_User.AutoEllipsis = true;
            this.lb_User.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_User.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lb_User.Location = new System.Drawing.Point(447, 0);
            this.lb_User.Margin = new System.Windows.Forms.Padding(0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lb_User.Size = new System.Drawing.Size(172, 54);
            this.lb_User.TabIndex = 6;
            this.lb_User.Text = "XXX(YYY)";
            this.lb_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 12, 16, 12);
            this.panel1.Size = new System.Drawing.Size(101, 54);
            this.panel1.TabIndex = 5;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(4, 12);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(81, 30);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel BaseNavigationAction;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
    }
}