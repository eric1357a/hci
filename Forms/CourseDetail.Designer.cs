namespace HCI.Forms
{
    partial class CourseDetail
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
            this.CourseRegButton = new System.Windows.Forms.Button();
            this.CourseDetails = new System.Windows.Forms.Label();
            this.CourseImage = new System.Windows.Forms.PictureBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Size = new System.Drawing.Size(76, 42);
            // 
            // lb_User
            // 
            this.lb_User.Size = new System.Drawing.Size(259, 66);
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Size = new System.Drawing.Size(336, 66);
            this.BaseNavigationText.Text = "Course Detail";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(592, 403);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(592, 66);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.btn_Change);
            this.BaseContentWrapper.Controls.Add(this.CourseDetails);
            this.BaseContentWrapper.Controls.Add(this.CourseImage);
            this.BaseContentWrapper.Controls.Add(this.CourseRegButton);
            this.BaseContentWrapper.Location = new System.Drawing.Point(0, 66);
            this.BaseContentWrapper.Size = new System.Drawing.Size(592, 337);
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Location = new System.Drawing.Point(225, 0);
            this.BaseNavigationAction.Size = new System.Drawing.Size(367, 66);
            // 
            // CourseRegButton
            // 
            this.CourseRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseRegButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CourseRegButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CourseRegButton.Location = new System.Drawing.Point(420, 254);
            this.CourseRegButton.Margin = new System.Windows.Forms.Padding(0);
            this.CourseRegButton.Name = "CourseRegButton";
            this.CourseRegButton.Size = new System.Drawing.Size(116, 36);
            this.CourseRegButton.TabIndex = 5;
            this.CourseRegButton.Text = "Register";
            this.CourseRegButton.UseVisualStyleBackColor = true;
            this.CourseRegButton.Click += new System.EventHandler(this.CourseRegButton_Click);
            // 
            // CourseDetails
            // 
            this.CourseDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseDetails.Location = new System.Drawing.Point(159, 32);
            this.CourseDetails.Margin = new System.Windows.Forms.Padding(0);
            this.CourseDetails.Name = "CourseDetails";
            this.CourseDetails.Size = new System.Drawing.Size(398, 208);
            this.CourseDetails.TabIndex = 6;
            // 
            // CourseImage
            // 
            this.CourseImage.Location = new System.Drawing.Point(42, 27);
            this.CourseImage.Margin = new System.Windows.Forms.Padding(0);
            this.CourseImage.Name = "CourseImage";
            this.CourseImage.Size = new System.Drawing.Size(96, 96);
            this.CourseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CourseImage.TabIndex = 7;
            this.CourseImage.TabStop = false;
            // 
            // btn_Change
            // 
            this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Change.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Change.Location = new System.Drawing.Point(255, 254);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(116, 36);
            this.btn_Change.TabIndex = 8;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // CourseDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(592, 447);
            this.Name = "CourseDetail";
            this.Text = "CourseDetail";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseRegButton;
        private System.Windows.Forms.Label CourseDetails;
        private System.Windows.Forms.PictureBox CourseImage;
        private System.Windows.Forms.Button btn_Change;
    }
}