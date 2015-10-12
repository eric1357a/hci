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
            this.clb_Member = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.clb_Month = new System.Windows.Forms.CheckedListBox();
            this.lb_Month = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.tb_ContactNo = new System.Windows.Forms.TextBox();
            this.lb_852 = new System.Windows.Forms.Label();
            this.lb_ContactNo = new System.Windows.Forms.Label();
            this.lb_WeekDay = new System.Windows.Forms.Label();
            this.lb_WeekDayTag = new System.Windows.Forms.Label();
            this.lb_Course = new System.Windows.Forms.Label();
            this.lb_CourseTag = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Size = new System.Drawing.Size(336, 66);
            this.BaseNavigationText.Text = "Course Registration";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.lb_WeekDay);
            this.BaseContentPanel.Controls.Add(this.lb_WeekDayTag);
            this.BaseContentPanel.Size = new System.Drawing.Size(718, 499);
            this.BaseContentPanel.Controls.SetChildIndex(this.lb_WeekDayTag, 0);
            this.BaseContentPanel.Controls.SetChildIndex(this.lb_WeekDay, 0);
            this.BaseContentPanel.Controls.SetChildIndex(this.BaseNavigation, 0);
            this.BaseContentPanel.Controls.SetChildIndex(this.BaseContentWrapper, 0);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(718, 66);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.btn_Cancel);
            this.BaseContentWrapper.Controls.Add(this.tb_Name);
            this.BaseContentWrapper.Controls.Add(this.lb_CourseTag);
            this.BaseContentWrapper.Controls.Add(this.lb_Name);
            this.BaseContentWrapper.Controls.Add(this.lb_Course);
            this.BaseContentWrapper.Controls.Add(this.clb_Member);
            this.BaseContentWrapper.Controls.Add(this.lb_ContactNo);
            this.BaseContentWrapper.Controls.Add(this.label1);
            this.BaseContentWrapper.Controls.Add(this.lb_852);
            this.BaseContentWrapper.Controls.Add(this.tb_Email);
            this.BaseContentWrapper.Controls.Add(this.tb_ContactNo);
            this.BaseContentWrapper.Controls.Add(this.lb_Email);
            this.BaseContentWrapper.Controls.Add(this.btn_Submit);
            this.BaseContentWrapper.Controls.Add(this.lb_Month);
            this.BaseContentWrapper.Controls.Add(this.clb_Month);
            this.BaseContentWrapper.Location = new System.Drawing.Point(0, 66);
            this.BaseContentWrapper.Size = new System.Drawing.Size(718, 433);
            // 
            // BaseNavigationAction
            // 
            this.BaseNavigationAction.Location = new System.Drawing.Point(348, 0);
            this.BaseNavigationAction.Size = new System.Drawing.Size(370, 66);
            // 
            // clb_Member
            // 
            this.clb_Member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.clb_Member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Member.CheckOnClick = true;
            this.clb_Member.ForeColor = System.Drawing.Color.Black;
            this.clb_Member.FormattingEnabled = true;
            this.clb_Member.Items.AddRange(new object[] {
            "Normal",
            "Gold"});
            this.clb_Member.Location = new System.Drawing.Point(431, 223);
            this.clb_Member.Margin = new System.Windows.Forms.Padding(0);
            this.clb_Member.Name = "clb_Member";
            this.clb_Member.Size = new System.Drawing.Size(137, 54);
            this.clb_Member.TabIndex = 6;
            this.clb_Member.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Member_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Member:";
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Email.Location = new System.Drawing.Point(288, 161);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(288, 38);
            this.tb_Email.TabIndex = 4;
            this.tb_Email.Leave += new System.EventHandler(this.tb_Email_Leave);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(431, 347);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 36);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(557, 347);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(94, 36);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // clb_Month
            // 
            this.clb_Month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.clb_Month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Month.CheckOnClick = true;
            this.clb_Month.ForeColor = System.Drawing.Color.Black;
            this.clb_Month.FormattingEnabled = true;
            this.clb_Month.Items.AddRange(new object[] {
            "June",
            "July",
            "August"});
            this.clb_Month.Location = new System.Drawing.Point(215, 223);
            this.clb_Month.Margin = new System.Windows.Forms.Padding(0);
            this.clb_Month.Name = "clb_Month";
            this.clb_Month.Size = new System.Drawing.Size(113, 81);
            this.clb_Month.TabIndex = 5;
            this.clb_Month.Leave += new System.EventHandler(this.clb_Month_Leave);
            // 
            // lb_Month
            // 
            this.lb_Month.AutoSize = true;
            this.lb_Month.Location = new System.Drawing.Point(128, 223);
            this.lb_Month.Name = "lb_Month";
            this.lb_Month.Size = new System.Drawing.Size(84, 23);
            this.lb_Month.TabIndex = 30;
            this.lb_Month.Text = "Months:";
            this.lb_Month.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(128, 167);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(151, 23);
            this.lb_Email.TabIndex = 29;
            this.lb_Email.Text = "Email Address:";
            this.lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ContactNo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ContactNo.Location = new System.Drawing.Point(345, 102);
            this.tb_ContactNo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(240, 38);
            this.tb_ContactNo.TabIndex = 3;
            this.tb_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNo_KeyPress);
            this.tb_ContactNo.Leave += new System.EventHandler(this.tb_ContactNo_Leave);
            // 
            // lb_852
            // 
            this.lb_852.AutoSize = true;
            this.lb_852.Location = new System.Drawing.Point(288, 108);
            this.lb_852.Name = "lb_852";
            this.lb_852.Size = new System.Drawing.Size(54, 23);
            this.lb_852.TabIndex = 27;
            this.lb_852.Text = "+852";
            // 
            // lb_ContactNo
            // 
            this.lb_ContactNo.AutoSize = true;
            this.lb_ContactNo.Location = new System.Drawing.Point(103, 108);
            this.lb_ContactNo.Name = "lb_ContactNo";
            this.lb_ContactNo.Size = new System.Drawing.Size(182, 23);
            this.lb_ContactNo.TabIndex = 26;
            this.lb_ContactNo.Text = "Contact Number:";
            this.lb_ContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_WeekDay
            // 
            this.lb_WeekDay.AutoSize = true;
            this.lb_WeekDay.Location = new System.Drawing.Point(282, 21);
            this.lb_WeekDay.Name = "lb_WeekDay";
            this.lb_WeekDay.Size = new System.Drawing.Size(46, 23);
            this.lb_WeekDay.TabIndex = 0;
            this.lb_WeekDay.Text = "XXX";
            // 
            // lb_WeekDayTag
            // 
            this.lb_WeekDayTag.AutoSize = true;
            this.lb_WeekDayTag.Location = new System.Drawing.Point(165, 21);
            this.lb_WeekDayTag.Name = "lb_WeekDayTag";
            this.lb_WeekDayTag.Size = new System.Drawing.Size(114, 23);
            this.lb_WeekDayTag.TabIndex = 24;
            this.lb_WeekDayTag.Text = "Week Day:";
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Location = new System.Drawing.Point(288, 10);
            this.lb_Course.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(46, 23);
            this.lb_Course.TabIndex = 1;
            this.lb_Course.Text = "XXX";
            // 
            // lb_CourseTag
            // 
            this.lb_CourseTag.AutoSize = true;
            this.lb_CourseTag.Location = new System.Drawing.Point(202, 10);
            this.lb_CourseTag.Name = "lb_CourseTag";
            this.lb_CourseTag.Size = new System.Drawing.Size(83, 23);
            this.lb_CourseTag.TabIndex = 22;
            this.lb_CourseTag.Text = "Course:";
            this.lb_CourseTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(128, 53);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(157, 23);
            this.lb_Name.TabIndex = 36;
            this.lb_Name.Text = "Student Name:";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Name.Location = new System.Drawing.Point(288, 47);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(288, 38);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.Leave += new System.EventHandler(this.tb_Name_Leave);
            // 
            // CourseRegistration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(718, 543);
            this.Name = "CourseRegistration";
            this.Text = "CourseRegistration";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseContentPanel.PerformLayout();
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Member;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.CheckedListBox clb_Month;
        private System.Windows.Forms.Label lb_Month;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox tb_ContactNo;
        private System.Windows.Forms.Label lb_852;
        private System.Windows.Forms.Label lb_ContactNo;
        private System.Windows.Forms.Label lb_WeekDay;
        private System.Windows.Forms.Label lb_WeekDayTag;
        private System.Windows.Forms.Label lb_Course;
        private System.Windows.Forms.Label lb_CourseTag;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
    }
}