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
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Size = new System.Drawing.Size(592, 66);
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
            this.BaseContentWrapper.Controls.Add(this.CourseDetails);
            this.BaseContentWrapper.Controls.Add(this.CourseImage);
            this.BaseContentWrapper.Controls.Add(this.CourseRegButton);
            this.BaseContentWrapper.Location = new System.Drawing.Point(0, 66);
            this.BaseContentWrapper.Size = new System.Drawing.Size(592, 337);
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
            // CourseDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(592, 447);
            this.Name = "CourseDetail";
            this.Text = "CourseDetail";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseRegButton;
        private System.Windows.Forms.Label CourseDetails;
        private System.Windows.Forms.PictureBox CourseImage;
    }
}