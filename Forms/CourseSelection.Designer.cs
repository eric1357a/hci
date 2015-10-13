namespace HCI.Forms
{
    partial class CourseSelection
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
            this.GroupTable = new System.Windows.Forms.TableLayoutPanel();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.Location = new System.Drawing.Point(191, 18);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(439, 10);
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Course Selection";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(989, 548);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(989, 54);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.GroupTable);
            this.BaseContentWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BaseContentWrapper.Size = new System.Drawing.Size(989, 494);
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Location = new System.Drawing.Point(453, 0);
            this.BaseNavigationAction.Size = new System.Drawing.Size(536, 54);
            // 
            // GroupTable
            // 
            this.GroupTable.BackColor = System.Drawing.Color.Transparent;
            this.GroupTable.ColumnCount = 1;
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GroupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupTable.Location = new System.Drawing.Point(0, 0);
            this.GroupTable.Margin = new System.Windows.Forms.Padding(0);
            this.GroupTable.Name = "GroupTable";
            this.GroupTable.RowCount = 1;
            this.GroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GroupTable.Size = new System.Drawing.Size(989, 494);
            this.GroupTable.TabIndex = 3;
            // 
            // CourseSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(989, 592);
            this.Name = "CourseSelection";
            this.Text = "CourseSelection";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel GroupTable;
    }
}