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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
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
            this.BaseContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Course Registration";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.checkedListBox1);
            this.BaseContentPanel.Controls.Add(this.label1);
            this.BaseContentPanel.Controls.Add(this.tb_Email);
            this.BaseContentPanel.Controls.Add(this.btn_Cancel);
            this.BaseContentPanel.Controls.Add(this.btn_Submit);
            this.BaseContentPanel.Controls.Add(this.clb_Month);
            this.BaseContentPanel.Controls.Add(this.lb_Month);
            this.BaseContentPanel.Controls.Add(this.lb_Email);
            this.BaseContentPanel.Controls.Add(this.tb_ContactNo);
            this.BaseContentPanel.Controls.Add(this.lb_852);
            this.BaseContentPanel.Controls.Add(this.lb_ContactNo);
            this.BaseContentPanel.Controls.Add(this.lb_WeekDay);
            this.BaseContentPanel.Controls.Add(this.lb_WeekDayTag);
            this.BaseContentPanel.Controls.Add(this.lb_Course);
            this.BaseContentPanel.Controls.Add(this.lb_CourseTag);
            this.BaseContentPanel.Size = new System.Drawing.Size(738, 455);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Normal",
            "Gold"});
            this.checkedListBox1.Location = new System.Drawing.Point(463, 221);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(100, 58);
            this.checkedListBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Member:";
            // 
            // tb_Email
            // 
            this.tb_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Email.Location = new System.Drawing.Point(282, 156);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(331, 38);
            this.tb_Email.TabIndex = 1;
            this.tb_Email.Leave += new System.EventHandler(this.tb_Email_Leave);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cancel.Location = new System.Drawing.Point(528, 389);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 44);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Submit.Location = new System.Drawing.Point(365, 389);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 44);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // clb_Month
            // 
            this.clb_Month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.clb_Month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Month.CheckOnClick = true;
            this.clb_Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.clb_Month.FormattingEnabled = true;
            this.clb_Month.Items.AddRange(new object[] {
            "June",
            "July",
            "August"});
            this.clb_Month.Location = new System.Drawing.Point(233, 221);
            this.clb_Month.Name = "clb_Month";
            this.clb_Month.Size = new System.Drawing.Size(100, 87);
            this.clb_Month.TabIndex = 2;
            // 
            // lb_Month
            // 
            this.lb_Month.AutoSize = true;
            this.lb_Month.Location = new System.Drawing.Point(133, 221);
            this.lb_Month.Name = "lb_Month";
            this.lb_Month.Size = new System.Drawing.Size(89, 25);
            this.lb_Month.TabIndex = 30;
            this.lb_Month.Text = "Months:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(127, 161);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(149, 25);
            this.lb_Email.TabIndex = 29;
            this.lb_Email.Text = "Email Address:";
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tb_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ContactNo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_ContactNo.Location = new System.Drawing.Point(351, 97);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(154, 38);
            this.tb_ContactNo.TabIndex = 0;
            this.tb_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNo_KeyPress);
            this.tb_ContactNo.Leave += new System.EventHandler(this.tb_ContactNo_Leave);
            // 
            // lb_852
            // 
            this.lb_852.AutoSize = true;
            this.lb_852.Location = new System.Drawing.Point(282, 102);
            this.lb_852.Name = "lb_852";
            this.lb_852.Size = new System.Drawing.Size(63, 25);
            this.lb_852.TabIndex = 27;
            this.lb_852.Text = "+852";
            // 
            // lb_ContactNo
            // 
            this.lb_ContactNo.AutoSize = true;
            this.lb_ContactNo.Location = new System.Drawing.Point(103, 102);
            this.lb_ContactNo.Name = "lb_ContactNo";
            this.lb_ContactNo.Size = new System.Drawing.Size(173, 25);
            this.lb_ContactNo.TabIndex = 26;
            this.lb_ContactNo.Text = "Contact Number:";
            // 
            // lb_WeekDay
            // 
            this.lb_WeekDay.AutoSize = true;
            this.lb_WeekDay.Location = new System.Drawing.Point(282, 21);
            this.lb_WeekDay.Name = "lb_WeekDay";
            this.lb_WeekDay.Size = new System.Drawing.Size(51, 25);
            this.lb_WeekDay.TabIndex = 25;
            this.lb_WeekDay.Text = "XXX";
            // 
            // lb_WeekDayTag
            // 
            this.lb_WeekDayTag.AutoSize = true;
            this.lb_WeekDayTag.Location = new System.Drawing.Point(165, 21);
            this.lb_WeekDayTag.Name = "lb_WeekDayTag";
            this.lb_WeekDayTag.Size = new System.Drawing.Size(111, 25);
            this.lb_WeekDayTag.TabIndex = 24;
            this.lb_WeekDayTag.Text = "Week Day:";
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Location = new System.Drawing.Point(282, 58);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(51, 25);
            this.lb_Course.TabIndex = 23;
            this.lb_Course.Text = "XXX";
            // 
            // lb_CourseTag
            // 
            this.lb_CourseTag.AutoSize = true;
            this.lb_CourseTag.Location = new System.Drawing.Point(194, 58);
            this.lb_CourseTag.Name = "lb_CourseTag";
            this.lb_CourseTag.Size = new System.Drawing.Size(82, 25);
            this.lb_CourseTag.TabIndex = 22;
            this.lb_CourseTag.Text = "Course:";
            // 
            // CourseRegistration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(738, 555);
            this.Name = "CourseRegistration";
            this.Text = "CourseRegistration";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
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
    }
}