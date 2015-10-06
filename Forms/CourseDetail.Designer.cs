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
            ((System.ComponentModel.ISupportInitialize)(this.CourseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Course Detail";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.CourseImage);
            this.BaseContentPanel.Controls.Add(this.CourseDetails);
            this.BaseContentPanel.Controls.Add(this.CourseRegButton);
            this.BaseContentPanel.Size = new System.Drawing.Size(440, 336);
            // 
            // CourseRegButton
            // 
            this.CourseRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseRegButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.CourseRegButton.Location = new System.Drawing.Point(315, 272);
            this.CourseRegButton.Margin = new System.Windows.Forms.Padding(0);
            this.CourseRegButton.Name = "CourseRegButton";
            this.CourseRegButton.Size = new System.Drawing.Size(101, 36);
            this.CourseRegButton.TabIndex = 5;
            this.CourseRegButton.Text = "Register";
            this.CourseRegButton.UseVisualStyleBackColor = true;
            this.CourseRegButton.Click += new System.EventHandler(this.CourseRegButton_Click);
            // 
            // CourseDetails
            // 
            this.CourseDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseDetails.Location = new System.Drawing.Point(140, 20);
            this.CourseDetails.Margin = new System.Windows.Forms.Padding(0);
            this.CourseDetails.Name = "CourseDetails";
            this.CourseDetails.Size = new System.Drawing.Size(276, 234);
            this.CourseDetails.TabIndex = 6;
            // 
            // CourseImage
            // 
            this.CourseImage.Location = new System.Drawing.Point(25, 20);
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
            this.ClientSize = new System.Drawing.Size(440, 436);
            this.Name = "CourseDetail";
            this.Text = "CourseDetail";
            this.BaseContentPanel.ResumeLayout(false);
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