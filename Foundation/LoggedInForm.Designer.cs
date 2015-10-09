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
            this.BaseNavigationAction = new System.Windows.Forms.Panel();
            this.lb_User = new System.Windows.Forms.Label();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Controls.Add(this.BaseNavigationAction);
            this.BaseNavigation.Controls.SetChildIndex(this.BaseNavigationAction, 0);
            this.BaseNavigation.Controls.SetChildIndex(this.BaseNavigationText, 0);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Location = new System.Drawing.Point(613, 10);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(102, 46);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Controls.Add(this.lb_User);
            this.BaseNavigationAction.Controls.Add(this.btn_Logout);
            this.BaseNavigationAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseNavigationAction.Location = new System.Drawing.Point(0, 0);
            this.BaseNavigationAction.Name = "BaseNavigationAction";
            this.BaseNavigationAction.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BaseNavigationAction.Size = new System.Drawing.Size(720, 66);
            this.BaseNavigationAction.TabIndex = 0;
            // 
            // lb_User
            // 
            this.lb_User.AutoEllipsis = true;
            this.lb_User.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_User.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_User.Location = new System.Drawing.Point(459, 10);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(154, 46);
            this.lb_User.TabIndex = 2;
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

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel BaseNavigationAction;
        private System.Windows.Forms.Label lb_User;
    }
}