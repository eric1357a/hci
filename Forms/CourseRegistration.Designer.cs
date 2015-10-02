namespace HCI.Forms
{
    partial class CourseRegistration
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
            this.GroupCourseAA = new HCI.Controls.NewGroupBox();
            this.GroupCourseBB = new HCI.Controls.NewGroupBox();
            this.GroupTable = new System.Windows.Forms.TableLayoutPanel();
            this.GroupCourseCC = new HCI.Controls.NewGroupBox();
            this.BaseContentPanel.SuspendLayout();
            this.GroupTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Course Registration";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.GroupTable);
            this.BaseContentPanel.Size = new System.Drawing.Size(748, 432);
            // 
            // GroupCourseAA
            // 
            this.GroupCourseAA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.GroupCourseAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupCourseAA.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.GroupCourseAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.GroupCourseAA.Location = new System.Drawing.Point(24, 15);
            this.GroupCourseAA.Name = "GroupCourseAA";
            this.GroupCourseAA.Size = new System.Drawing.Size(214, 392);
            this.GroupCourseAA.TabIndex = 0;
            this.GroupCourseAA.TabStop = false;
            this.GroupCourseAA.Text = "Course AA";
            // 
            // GroupCourseBB
            // 
            this.GroupCourseBB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.GroupCourseBB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupCourseBB.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.GroupCourseBB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.GroupCourseBB.Location = new System.Drawing.Point(265, 15);
            this.GroupCourseBB.Name = "GroupCourseBB";
            this.GroupCourseBB.Size = new System.Drawing.Size(214, 392);
            this.GroupCourseBB.TabIndex = 1;
            this.GroupCourseBB.TabStop = false;
            this.GroupCourseBB.Text = "Course BB";
            // 
            // GroupTable
            // 
            this.GroupTable.ColumnCount = 7;
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.905826F));
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4589F));
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.905826F));
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4589F));
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.905826F));
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4589F));
            this.GroupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.905826F));
            this.GroupTable.Controls.Add(this.GroupCourseCC, 5, 1);
            this.GroupTable.Controls.Add(this.GroupCourseAA, 1, 1);
            this.GroupTable.Controls.Add(this.GroupCourseBB, 3, 1);
            this.GroupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupTable.Location = new System.Drawing.Point(0, 0);
            this.GroupTable.Name = "GroupTable";
            this.GroupTable.RowCount = 3;
            this.GroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.888094F));
            this.GroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.21248F));
            this.GroupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.899433F));
            this.GroupTable.Size = new System.Drawing.Size(748, 432);
            this.GroupTable.TabIndex = 3;
            // 
            // GroupCourseCC
            // 
            this.GroupCourseCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.GroupCourseCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupCourseCC.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(136)));
            this.GroupCourseCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.GroupCourseCC.Location = new System.Drawing.Point(506, 15);
            this.GroupCourseCC.Name = "GroupCourseCC";
            this.GroupCourseCC.Size = new System.Drawing.Size(214, 392);
            this.GroupCourseCC.TabIndex = 2;
            this.GroupCourseCC.TabStop = false;
            this.GroupCourseCC.Text = "Course CC";
            // 
            // CourseRegistration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(748, 532);
            this.Name = "CourseRegistration";
            this.Text = "CourseRegistration";
            this.BaseContentPanel.ResumeLayout(false);
            this.GroupTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HCI.Controls.NewGroupBox GroupCourseBB;
        private HCI.Controls.NewGroupBox GroupCourseAA;
        private System.Windows.Forms.TableLayoutPanel GroupTable;
        private HCI.Controls.NewGroupBox GroupCourseCC;
    }
}