namespace HCI.Forms
{
    partial class Maintain
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
            this.tb_maintain = new System.Windows.Forms.TabControl();
            this.tbp_Course = new System.Windows.Forms.TabPage();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Day = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.lb_Desc = new System.Windows.Forms.Label();
            this.lb_Day = new System.Windows.Forms.Label();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.lb_Courses = new System.Windows.Forms.Label();
            this.lB_Course = new System.Windows.Forms.ListBox();
            this.tbp_Student = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clb_Member = new System.Windows.Forms.CheckedListBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_ContactNo = new System.Windows.Forms.TextBox();
            this.tb_studentName = new System.Windows.Forms.TextBox();
            this.lb_Member = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_ConNo = new System.Windows.Forms.Label();
            this.lb_studentName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tbp_Staff = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.clb_Position = new System.Windows.Forms.CheckedListBox();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.tb_staffName = new System.Windows.Forms.TextBox();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.lb_staffName = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.tb_maintain.SuspendLayout();
            this.tbp_Course.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbp_Student.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbp_Staff.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Maintain Info";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.tb_maintain);
            // 
            // tb_maintain
            // 
            this.tb_maintain.Controls.Add(this.tbp_Course);
            this.tb_maintain.Controls.Add(this.tbp_Student);
            this.tb_maintain.Controls.Add(this.tbp_Staff);
            this.tb_maintain.Location = new System.Drawing.Point(0, 3);
            this.tb_maintain.Name = "tb_maintain";
            this.tb_maintain.SelectedIndex = 0;
            this.tb_maintain.Size = new System.Drawing.Size(720, 429);
            this.tb_maintain.TabIndex = 0;
            // 
            // tbp_Course
            // 
            this.tbp_Course.Controls.Add(this.btn_Delete);
            this.tbp_Course.Controls.Add(this.panel1);
            this.tbp_Course.Controls.Add(this.lB_Course);
            this.tbp_Course.Location = new System.Drawing.Point(4, 30);
            this.tbp_Course.Name = "tbp_Course";
            this.tbp_Course.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Course.Size = new System.Drawing.Size(712, 395);
            this.tbp_Course.TabIndex = 0;
            this.tbp_Course.Text = "Course";
            this.tbp_Course.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(122, 301);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 36);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_Day);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.tb_Desc);
            this.panel1.Controls.Add(this.tb_Cost);
            this.panel1.Controls.Add(this.tb_Course);
            this.panel1.Controls.Add(this.lb_Desc);
            this.panel1.Controls.Add(this.lb_Day);
            this.panel1.Controls.Add(this.lb_Cost);
            this.panel1.Controls.Add(this.lb_Courses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(336, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 389);
            this.panel1.TabIndex = 2;
            // 
            // cb_Day
            // 
            this.cb_Day.FormattingEnabled = true;
            this.cb_Day.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.cb_Day.Location = new System.Drawing.Point(136, 105);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(121, 29);
            this.cb_Day.TabIndex = 19;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(153, 298);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 36);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Desc
            // 
            this.tb_Desc.Location = new System.Drawing.Point(136, 145);
            this.tb_Desc.Multiline = true;
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(214, 88);
            this.tb_Desc.TabIndex = 17;
            this.tb_Desc.Leave += new System.EventHandler(this.tb_Desc_Leave);
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(136, 65);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(214, 27);
            this.tb_Cost.TabIndex = 15;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_KeyPress);
            this.tb_Cost.Leave += new System.EventHandler(this.tb_Cost_Leave);
            // 
            // tb_Course
            // 
            this.tb_Course.Location = new System.Drawing.Point(136, 25);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(214, 27);
            this.tb_Course.TabIndex = 14;
            this.tb_Course.Leave += new System.EventHandler(this.tb_Course_Leave);
            // 
            // lb_Desc
            // 
            this.lb_Desc.AutoSize = true;
            this.lb_Desc.Location = new System.Drawing.Point(23, 145);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(101, 21);
            this.lb_Desc.TabIndex = 6;
            this.lb_Desc.Text = "Description:";
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(23, 105);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(45, 21);
            this.lb_Day.TabIndex = 5;
            this.lb_Day.Text = "Day:";
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Location = new System.Drawing.Point(23, 65);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(50, 21);
            this.lb_Cost.TabIndex = 4;
            this.lb_Cost.Text = "Cost:";
            // 
            // lb_Courses
            // 
            this.lb_Courses.AutoSize = true;
            this.lb_Courses.Location = new System.Drawing.Point(23, 25);
            this.lb_Courses.Name = "lb_Courses";
            this.lb_Courses.Size = new System.Drawing.Size(68, 21);
            this.lb_Courses.TabIndex = 1;
            this.lb_Courses.Text = "Course:";
            // 
            // lB_Course
            // 
            this.lB_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lB_Course.Dock = System.Windows.Forms.DockStyle.Left;
            this.lB_Course.FormattingEnabled = true;
            this.lB_Course.ItemHeight = 21;
            this.lB_Course.Location = new System.Drawing.Point(3, 3);
            this.lB_Course.Name = "lB_Course";
            this.lB_Course.Size = new System.Drawing.Size(333, 389);
            this.lB_Course.TabIndex = 1;
            // 
            // tbp_Student
            // 
            this.tbp_Student.Controls.Add(this.button3);
            this.tbp_Student.Controls.Add(this.panel3);
            this.tbp_Student.Controls.Add(this.listBox2);
            this.tbp_Student.Location = new System.Drawing.Point(4, 30);
            this.tbp_Student.Name = "tbp_Student";
            this.tbp_Student.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Student.Size = new System.Drawing.Size(712, 395);
            this.tbp_Student.TabIndex = 1;
            this.tbp_Student.Text = "Student";
            this.tbp_Student.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(122, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clb_Member);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.tb_ContactNo);
            this.panel3.Controls.Add(this.tb_studentName);
            this.panel3.Controls.Add(this.lb_Member);
            this.panel3.Controls.Add(this.lb_email);
            this.panel3.Controls.Add(this.lb_ConNo);
            this.panel3.Controls.Add(this.lb_studentName);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(336, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 389);
            this.panel3.TabIndex = 1;
            // 
            // clb_Member
            // 
            this.clb_Member.BackColor = System.Drawing.Color.White;
            this.clb_Member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Member.CheckOnClick = true;
            this.clb_Member.ForeColor = System.Drawing.Color.Black;
            this.clb_Member.FormattingEnabled = true;
            this.clb_Member.Items.AddRange(new object[] {
            "Normal",
            "Gold"});
            this.clb_Member.Location = new System.Drawing.Point(179, 145);
            this.clb_Member.Margin = new System.Windows.Forms.Padding(0);
            this.clb_Member.Name = "clb_Member";
            this.clb_Member.Size = new System.Drawing.Size(137, 44);
            this.clb_Member.TabIndex = 41;
            this.clb_Member.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Member_ItemCheck);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(179, 105);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(173, 27);
            this.tb_email.TabIndex = 40;
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.Location = new System.Drawing.Point(179, 65);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(173, 27);
            this.tb_ContactNo.TabIndex = 39;
            this.tb_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNo_KeyPress);
            this.tb_ContactNo.Leave += new System.EventHandler(this.tb_conNo_Leave);
            // 
            // tb_studentName
            // 
            this.tb_studentName.Location = new System.Drawing.Point(179, 25);
            this.tb_studentName.Name = "tb_studentName";
            this.tb_studentName.Size = new System.Drawing.Size(173, 27);
            this.tb_studentName.TabIndex = 38;
            this.tb_studentName.Leave += new System.EventHandler(this.tb_studentName_Leave);
            // 
            // lb_Member
            // 
            this.lb_Member.AutoSize = true;
            this.lb_Member.Location = new System.Drawing.Point(23, 145);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(80, 21);
            this.lb_Member.TabIndex = 37;
            this.lb_Member.Text = "Member:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(23, 105);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(121, 21);
            this.lb_email.TabIndex = 22;
            this.lb_email.Text = "Email Address:";
            // 
            // lb_ConNo
            // 
            this.lb_ConNo.AutoSize = true;
            this.lb_ConNo.Location = new System.Drawing.Point(23, 65);
            this.lb_ConNo.Name = "lb_ConNo";
            this.lb_ConNo.Size = new System.Drawing.Size(149, 21);
            this.lb_ConNo.TabIndex = 21;
            this.lb_ConNo.Text = "Contact Number:";
            // 
            // lb_studentName
            // 
            this.lb_studentName.AutoSize = true;
            this.lb_studentName.Location = new System.Drawing.Point(23, 25);
            this.lb_studentName.Name = "lb_studentName";
            this.lb_studentName.Size = new System.Drawing.Size(129, 21);
            this.lb_studentName.TabIndex = 20;
            this.lb_studentName.Text = "Student Name:";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(153, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(333, 389);
            this.listBox2.TabIndex = 0;
            // 
            // tbp_Staff
            // 
            this.tbp_Staff.Controls.Add(this.button2);
            this.tbp_Staff.Controls.Add(this.panel4);
            this.tbp_Staff.Controls.Add(this.listBox3);
            this.tbp_Staff.Location = new System.Drawing.Point(4, 30);
            this.tbp_Staff.Name = "tbp_Staff";
            this.tbp_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Staff.Size = new System.Drawing.Size(712, 395);
            this.tbp_Staff.TabIndex = 2;
            this.tbp_Staff.Text = "Staff";
            this.tbp_Staff.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(122, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.clb_Position);
            this.panel4.Controls.Add(this.tb_Pw);
            this.panel4.Controls.Add(this.tb_staffName);
            this.panel4.Controls.Add(this.lb_Position);
            this.panel4.Controls.Add(this.lb_pw);
            this.panel4.Controls.Add(this.lb_staffName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(336, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 389);
            this.panel4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(153, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_add3_Click);
            // 
            // clb_Position
            // 
            this.clb_Position.BackColor = System.Drawing.Color.White;
            this.clb_Position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Position.FormattingEnabled = true;
            this.clb_Position.Items.AddRange(new object[] {
            "Staff",
            "Manager",
            "Admin"});
            this.clb_Position.Location = new System.Drawing.Point(144, 105);
            this.clb_Position.Name = "clb_Position";
            this.clb_Position.Size = new System.Drawing.Size(120, 66);
            this.clb_Position.TabIndex = 46;
            this.clb_Position.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Position_ItemCheck);
            this.clb_Position.Leave += new System.EventHandler(this.clb_Position_Leave);
            // 
            // tb_Pw
            // 
            this.tb_Pw.Location = new System.Drawing.Point(144, 65);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(173, 27);
            this.tb_Pw.TabIndex = 45;
            this.tb_Pw.Leave += new System.EventHandler(this.tb_Pw_Leave);
            // 
            // tb_staffName
            // 
            this.tb_staffName.Location = new System.Drawing.Point(144, 25);
            this.tb_staffName.Name = "tb_staffName";
            this.tb_staffName.Size = new System.Drawing.Size(173, 27);
            this.tb_staffName.TabIndex = 44;
            this.tb_staffName.Leave += new System.EventHandler(this.tb_staffName_Leave);
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(23, 105);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(72, 21);
            this.lb_Position.TabIndex = 43;
            this.lb_Position.Text = "Position:";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Location = new System.Drawing.Point(23, 65);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(86, 21);
            this.lb_pw.TabIndex = 41;
            this.lb_pw.Text = "Password:";
            // 
            // lb_staffName
            // 
            this.lb_staffName.AutoSize = true;
            this.lb_staffName.Location = new System.Drawing.Point(23, 25);
            this.lb_staffName.Name = "lb_staffName";
            this.lb_staffName.Size = new System.Drawing.Size(102, 21);
            this.lb_staffName.TabIndex = 39;
            this.lb_staffName.Text = "Staff Name:";
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(3, 3);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(333, 389);
            this.listBox3.TabIndex = 0;
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "Maintain";
            this.Text = "Maintain";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            this.tb_maintain.ResumeLayout(false);
            this.tbp_Course.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbp_Student.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbp_Staff.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb_maintain;
        private System.Windows.Forms.TabPage tbp_Course;
        private System.Windows.Forms.TabPage tbp_Student;
        private System.Windows.Forms.ListBox lB_Course;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tbp_Staff;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_Courses;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.Label lb_Desc;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TextBox tb_Desc;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_Day;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_studentName;
        private System.Windows.Forms.Label lb_ConNo;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_Member;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_ContactNo;
        private System.Windows.Forms.TextBox tb_studentName;
        private System.Windows.Forms.CheckedListBox clb_Member;
        private System.Windows.Forms.Label lb_staffName;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.TextBox tb_Pw;
        private System.Windows.Forms.TextBox tb_staffName;
        private System.Windows.Forms.CheckedListBox clb_Position;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}