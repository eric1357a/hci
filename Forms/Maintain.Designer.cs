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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbp_Course = new System.Windows.Forms.TabPage();
            this.divider1 = new System.Windows.Forms.Panel();
            this.btn_Course_Delete = new System.Windows.Forms.Button();
            this.panel_Course = new System.Windows.Forms.Panel();
            this.lb_ProgramNo = new System.Windows.Forms.Label();
            this.tb_CourseNo = new System.Windows.Forms.TextBox();
            this.cb_Day = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.lb_Desc = new System.Windows.Forms.Label();
            this.lb_Day = new System.Windows.Forms.Label();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.lb_Courses = new System.Windows.Forms.Label();
            this.lb_Course = new System.Windows.Forms.ListBox();
            this.tbp_Student = new System.Windows.Forms.TabPage();
            this.divider2 = new System.Windows.Forms.Panel();
            this.btn_Student_Delete = new System.Windows.Forms.Button();
            this.panel_Student = new System.Windows.Forms.Panel();
            this.clb_Member = new System.Windows.Forms.CheckedListBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_ContactNo = new System.Windows.Forms.TextBox();
            this.tb_studentName = new System.Windows.Forms.TextBox();
            this.lb_Member = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_ConNo = new System.Windows.Forms.Label();
            this.lb_studentName = new System.Windows.Forms.Label();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.lb_Student = new System.Windows.Forms.ListBox();
            this.tbp_Staff = new System.Windows.Forms.TabPage();
            this.divider3 = new System.Windows.Forms.Panel();
            this.btn_Staff_Delete = new System.Windows.Forms.Button();
            this.panel_Staff = new System.Windows.Forms.Panel();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.clb_Position = new System.Windows.Forms.CheckedListBox();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.tb_staffName = new System.Windows.Forms.TextBox();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.lb_staffName = new System.Windows.Forms.Label();
            this.lb_Staff = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tbp_Course.SuspendLayout();
            this.panel_Course.SuspendLayout();
            this.tbp_Student.SuspendLayout();
            this.panel_Student.SuspendLayout();
            this.tbp_Staff.SuspendLayout();
            this.panel_Staff.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Maintain Info";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(720, 442);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.tabControl);
            this.BaseContentWrapper.Size = new System.Drawing.Size(720, 388);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbp_Course);
            this.tabControl.Controls.Add(this.tbp_Student);
            this.tabControl.Controls.Add(this.tbp_Staff);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(720, 373);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.lb_Staff_SelectedIndexChanged);
            // 
            // tbp_Course
            // 
            this.tbp_Course.Controls.Add(this.divider1);
            this.tbp_Course.Controls.Add(this.btn_Course_Delete);
            this.tbp_Course.Controls.Add(this.panel_Course);
            this.tbp_Course.Controls.Add(this.lb_Course);
            this.tbp_Course.Location = new System.Drawing.Point(4, 32);
            this.tbp_Course.Name = "tbp_Course";
            this.tbp_Course.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Course.Size = new System.Drawing.Size(712, 337);
            this.tbp_Course.TabIndex = 0;
            this.tbp_Course.Text = "Course";
            this.tbp_Course.UseVisualStyleBackColor = true;
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.Silver;
            this.divider1.Dock = System.Windows.Forms.DockStyle.Right;
            this.divider1.Location = new System.Drawing.Point(335, 3);
            this.divider1.Margin = new System.Windows.Forms.Padding(0);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(1, 331);
            this.divider1.TabIndex = 15;
            // 
            // btn_Course_Delete
            // 
            this.btn_Course_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Course_Delete.Location = new System.Drawing.Point(115, 282);
            this.btn_Course_Delete.Name = "btn_Course_Delete";
            this.btn_Course_Delete.Size = new System.Drawing.Size(86, 36);
            this.btn_Course_Delete.TabIndex = 14;
            this.btn_Course_Delete.Text = "Delete";
            this.btn_Course_Delete.UseVisualStyleBackColor = true;
            this.btn_Course_Delete.Click += new System.EventHandler(this.btn_Course_Delete_Click);
            // 
            // panel_Course
            // 
            this.panel_Course.Controls.Add(this.lb_ProgramNo);
            this.panel_Course.Controls.Add(this.tb_CourseNo);
            this.panel_Course.Controls.Add(this.cb_Day);
            this.panel_Course.Controls.Add(this.btn_add);
            this.panel_Course.Controls.Add(this.tb_Desc);
            this.panel_Course.Controls.Add(this.tb_Cost);
            this.panel_Course.Controls.Add(this.tb_Course);
            this.panel_Course.Controls.Add(this.lb_Desc);
            this.panel_Course.Controls.Add(this.lb_Day);
            this.panel_Course.Controls.Add(this.lb_Cost);
            this.panel_Course.Controls.Add(this.lb_Courses);
            this.panel_Course.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Course.Location = new System.Drawing.Point(336, 3);
            this.panel_Course.Name = "panel_Course";
            this.panel_Course.Size = new System.Drawing.Size(373, 331);
            this.panel_Course.TabIndex = 2;
            // 
            // lb_ProgramNo
            // 
            this.lb_ProgramNo.AutoSize = true;
            this.lb_ProgramNo.Location = new System.Drawing.Point(23, 32);
            this.lb_ProgramNo.Name = "lb_ProgramNo";
            this.lb_ProgramNo.Size = new System.Drawing.Size(132, 23);
            this.lb_ProgramNo.TabIndex = 21;
            this.lb_ProgramNo.Text = "Program No:";
            // 
            // tb_CourseNo
            // 
            this.tb_CourseNo.Location = new System.Drawing.Point(136, 29);
            this.tb_CourseNo.Name = "tb_CourseNo";
            this.tb_CourseNo.Size = new System.Drawing.Size(57, 32);
            this.tb_CourseNo.TabIndex = 20;
            // 
            // cb_Day
            // 
            this.cb_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Day.FormattingEnabled = true;
            this.cb_Day.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.cb_Day.Location = new System.Drawing.Point(136, 146);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(214, 31);
            this.cb_Day.TabIndex = 19;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(153, 279);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 36);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Desc
            // 
            this.tb_Desc.Location = new System.Drawing.Point(136, 188);
            this.tb_Desc.Multiline = true;
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(214, 64);
            this.tb_Desc.TabIndex = 17;
            this.tb_Desc.TextChanged += new System.EventHandler(this.tb_Desc_TextChanged);
            this.tb_Desc.Leave += new System.EventHandler(this.tb_Desc_Leave);
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(136, 109);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(103, 32);
            this.tb_Cost.TabIndex = 15;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_KeyPress);
            this.tb_Cost.Leave += new System.EventHandler(this.tb_Cost_Leave);
            // 
            // tb_Course
            // 
            this.tb_Course.Location = new System.Drawing.Point(136, 71);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(214, 32);
            this.tb_Course.TabIndex = 14;
            this.tb_Course.Leave += new System.EventHandler(this.tb_Course_Leave);
            // 
            // lb_Desc
            // 
            this.lb_Desc.AutoSize = true;
            this.lb_Desc.Location = new System.Drawing.Point(23, 188);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(122, 23);
            this.lb_Desc.TabIndex = 6;
            this.lb_Desc.Text = "Description:";
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(23, 149);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(55, 23);
            this.lb_Day.TabIndex = 5;
            this.lb_Day.Text = "Day:";
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Location = new System.Drawing.Point(23, 112);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(59, 23);
            this.lb_Cost.TabIndex = 4;
            this.lb_Cost.Text = "Cost:";
            // 
            // lb_Courses
            // 
            this.lb_Courses.AutoSize = true;
            this.lb_Courses.Location = new System.Drawing.Point(23, 74);
            this.lb_Courses.Name = "lb_Courses";
            this.lb_Courses.Size = new System.Drawing.Size(83, 23);
            this.lb_Courses.TabIndex = 1;
            this.lb_Courses.Text = "Course:";
            // 
            // lb_Course
            // 
            this.lb_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Course.FormattingEnabled = true;
            this.lb_Course.ItemHeight = 23;
            this.lb_Course.Location = new System.Drawing.Point(3, 3);
            this.lb_Course.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(333, 230);
            this.lb_Course.TabIndex = 1;
            this.lb_Course.SelectedIndexChanged += new System.EventHandler(this.lb_Course_SelectedIndexChanged);
            // 
            // tbp_Student
            // 
            this.tbp_Student.Controls.Add(this.divider2);
            this.tbp_Student.Controls.Add(this.btn_Student_Delete);
            this.tbp_Student.Controls.Add(this.panel_Student);
            this.tbp_Student.Controls.Add(this.lb_Student);
            this.tbp_Student.Location = new System.Drawing.Point(4, 32);
            this.tbp_Student.Name = "tbp_Student";
            this.tbp_Student.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Student.Size = new System.Drawing.Size(712, 337);
            this.tbp_Student.TabIndex = 1;
            this.tbp_Student.Text = "Student";
            this.tbp_Student.UseVisualStyleBackColor = true;
            // 
            // divider2
            // 
            this.divider2.BackColor = System.Drawing.Color.Silver;
            this.divider2.Dock = System.Windows.Forms.DockStyle.Right;
            this.divider2.Location = new System.Drawing.Point(335, 3);
            this.divider2.Margin = new System.Windows.Forms.Padding(0);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(1, 331);
            this.divider2.TabIndex = 16;
            // 
            // btn_Student_Delete
            // 
            this.btn_Student_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Student_Delete.Location = new System.Drawing.Point(115, 282);
            this.btn_Student_Delete.Name = "btn_Student_Delete";
            this.btn_Student_Delete.Size = new System.Drawing.Size(86, 36);
            this.btn_Student_Delete.TabIndex = 15;
            this.btn_Student_Delete.Text = "Delete";
            this.btn_Student_Delete.UseVisualStyleBackColor = true;
            this.btn_Student_Delete.Click += new System.EventHandler(this.btn_Student_Delete_Click);
            // 
            // panel_Student
            // 
            this.panel_Student.Controls.Add(this.clb_Member);
            this.panel_Student.Controls.Add(this.tb_email);
            this.panel_Student.Controls.Add(this.tb_ContactNo);
            this.panel_Student.Controls.Add(this.tb_studentName);
            this.panel_Student.Controls.Add(this.lb_Member);
            this.panel_Student.Controls.Add(this.lb_email);
            this.panel_Student.Controls.Add(this.lb_ConNo);
            this.panel_Student.Controls.Add(this.lb_studentName);
            this.panel_Student.Controls.Add(this.btn_add2);
            this.panel_Student.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Student.Location = new System.Drawing.Point(336, 3);
            this.panel_Student.Name = "panel_Student";
            this.panel_Student.Size = new System.Drawing.Size(373, 331);
            this.panel_Student.TabIndex = 1;
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
            this.clb_Member.Size = new System.Drawing.Size(137, 27);
            this.clb_Member.TabIndex = 41;
            this.clb_Member.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Member_ItemCheck);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(179, 105);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(173, 32);
            this.tb_email.TabIndex = 40;
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.Location = new System.Drawing.Point(179, 65);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(173, 32);
            this.tb_ContactNo.TabIndex = 39;
            this.tb_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ContactNo_KeyPress);
            this.tb_ContactNo.Leave += new System.EventHandler(this.tb_conNo_Leave);
            // 
            // tb_studentName
            // 
            this.tb_studentName.Location = new System.Drawing.Point(179, 25);
            this.tb_studentName.Name = "tb_studentName";
            this.tb_studentName.Size = new System.Drawing.Size(173, 32);
            this.tb_studentName.TabIndex = 38;
            this.tb_studentName.Leave += new System.EventHandler(this.tb_studentName_Leave);
            // 
            // lb_Member
            // 
            this.lb_Member.AutoSize = true;
            this.lb_Member.Location = new System.Drawing.Point(23, 145);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(97, 23);
            this.lb_Member.TabIndex = 37;
            this.lb_Member.Text = "Member:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(23, 105);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(151, 23);
            this.lb_email.TabIndex = 22;
            this.lb_email.Text = "Email Address:";
            // 
            // lb_ConNo
            // 
            this.lb_ConNo.AutoSize = true;
            this.lb_ConNo.Location = new System.Drawing.Point(23, 65);
            this.lb_ConNo.Name = "lb_ConNo";
            this.lb_ConNo.Size = new System.Drawing.Size(182, 23);
            this.lb_ConNo.TabIndex = 21;
            this.lb_ConNo.Text = "Contact Number:";
            // 
            // lb_studentName
            // 
            this.lb_studentName.AutoSize = true;
            this.lb_studentName.Location = new System.Drawing.Point(23, 25);
            this.lb_studentName.Name = "lb_studentName";
            this.lb_studentName.Size = new System.Drawing.Size(157, 23);
            this.lb_studentName.TabIndex = 20;
            this.lb_studentName.Text = "Student Name:";
            // 
            // btn_add2
            // 
            this.btn_add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add2.ForeColor = System.Drawing.Color.Black;
            this.btn_add2.Location = new System.Drawing.Point(153, 279);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(86, 36);
            this.btn_add2.TabIndex = 19;
            this.btn_add2.Text = "Add";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // lb_Student
            // 
            this.lb_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Student.FormattingEnabled = true;
            this.lb_Student.ItemHeight = 23;
            this.lb_Student.Location = new System.Drawing.Point(3, 3);
            this.lb_Student.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Student.Name = "lb_Student";
            this.lb_Student.Size = new System.Drawing.Size(333, 230);
            this.lb_Student.TabIndex = 0;
            this.lb_Student.SelectedIndexChanged += new System.EventHandler(this.lb_Student_SelectedIndexChanged);
            // 
            // tbp_Staff
            // 
            this.tbp_Staff.Controls.Add(this.divider3);
            this.tbp_Staff.Controls.Add(this.btn_Staff_Delete);
            this.tbp_Staff.Controls.Add(this.panel_Staff);
            this.tbp_Staff.Controls.Add(this.lb_Staff);
            this.tbp_Staff.Location = new System.Drawing.Point(4, 32);
            this.tbp_Staff.Name = "tbp_Staff";
            this.tbp_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Staff.Size = new System.Drawing.Size(712, 337);
            this.tbp_Staff.TabIndex = 2;
            this.tbp_Staff.Text = "Staff";
            this.tbp_Staff.UseVisualStyleBackColor = true;
            // 
            // divider3
            // 
            this.divider3.BackColor = System.Drawing.Color.Silver;
            this.divider3.Dock = System.Windows.Forms.DockStyle.Right;
            this.divider3.Location = new System.Drawing.Point(335, 3);
            this.divider3.Margin = new System.Windows.Forms.Padding(0);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(1, 331);
            this.divider3.TabIndex = 17;
            // 
            // btn_Staff_Delete
            // 
            this.btn_Staff_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Staff_Delete.Location = new System.Drawing.Point(115, 282);
            this.btn_Staff_Delete.Name = "btn_Staff_Delete";
            this.btn_Staff_Delete.Size = new System.Drawing.Size(86, 36);
            this.btn_Staff_Delete.TabIndex = 16;
            this.btn_Staff_Delete.Text = "Delete";
            this.btn_Staff_Delete.UseVisualStyleBackColor = true;
            this.btn_Staff_Delete.Click += new System.EventHandler(this.btn_Staff_Delete_Click);
            // 
            // panel_Staff
            // 
            this.panel_Staff.Controls.Add(this.btn_add3);
            this.panel_Staff.Controls.Add(this.clb_Position);
            this.panel_Staff.Controls.Add(this.tb_Pw);
            this.panel_Staff.Controls.Add(this.tb_staffName);
            this.panel_Staff.Controls.Add(this.lb_Position);
            this.panel_Staff.Controls.Add(this.lb_pw);
            this.panel_Staff.Controls.Add(this.lb_staffName);
            this.panel_Staff.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Staff.Location = new System.Drawing.Point(336, 3);
            this.panel_Staff.Name = "panel_Staff";
            this.panel_Staff.Size = new System.Drawing.Size(373, 331);
            this.panel_Staff.TabIndex = 1;
            // 
            // btn_add3
            // 
            this.btn_add3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add3.ForeColor = System.Drawing.Color.Black;
            this.btn_add3.Location = new System.Drawing.Point(153, 279);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(86, 36);
            this.btn_add3.TabIndex = 47;
            this.btn_add3.Text = "Add";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add3_Click);
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
            this.clb_Position.Size = new System.Drawing.Size(120, 54);
            this.clb_Position.TabIndex = 46;
            this.clb_Position.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Position_ItemCheck);
            this.clb_Position.Leave += new System.EventHandler(this.clb_Position_Leave);
            // 
            // tb_Pw
            // 
            this.tb_Pw.Location = new System.Drawing.Point(144, 65);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.PasswordChar = '．';
            this.tb_Pw.Size = new System.Drawing.Size(173, 32);
            this.tb_Pw.TabIndex = 45;
            this.tb_Pw.Leave += new System.EventHandler(this.tb_Pw_Leave);
            // 
            // tb_staffName
            // 
            this.tb_staffName.Location = new System.Drawing.Point(144, 25);
            this.tb_staffName.Name = "tb_staffName";
            this.tb_staffName.Size = new System.Drawing.Size(173, 32);
            this.tb_staffName.TabIndex = 44;
            this.tb_staffName.Leave += new System.EventHandler(this.tb_staffName_Leave);
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(23, 105);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(86, 23);
            this.lb_Position.TabIndex = 43;
            this.lb_Position.Text = "Position:";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Location = new System.Drawing.Point(23, 65);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(108, 23);
            this.lb_pw.TabIndex = 41;
            this.lb_pw.Text = "Password:";
            // 
            // lb_staffName
            // 
            this.lb_staffName.AutoSize = true;
            this.lb_staffName.Location = new System.Drawing.Point(23, 25);
            this.lb_staffName.Name = "lb_staffName";
            this.lb_staffName.Size = new System.Drawing.Size(125, 23);
            this.lb_staffName.TabIndex = 39;
            this.lb_staffName.Text = "Staff Name:";
            // 
            // lb_Staff
            // 
            this.lb_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Staff.FormattingEnabled = true;
            this.lb_Staff.ItemHeight = 23;
            this.lb_Staff.Location = new System.Drawing.Point(3, 3);
            this.lb_Staff.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Staff.Name = "lb_Staff";
            this.lb_Staff.Size = new System.Drawing.Size(333, 230);
            this.lb_Staff.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(712, 337);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Teacher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(5, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 230);
            this.listBox1.TabIndex = 2;
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 486);
            this.Name = "Maintain";
            this.Text = "Maintain";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tbp_Course.ResumeLayout(false);
            this.panel_Course.ResumeLayout(false);
            this.panel_Course.PerformLayout();
            this.tbp_Student.ResumeLayout(false);
            this.panel_Student.ResumeLayout(false);
            this.panel_Student.PerformLayout();
            this.tbp_Staff.ResumeLayout(false);
            this.panel_Staff.ResumeLayout(false);
            this.panel_Staff.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbp_Course;
        private System.Windows.Forms.TabPage tbp_Student;
        private System.Windows.Forms.ListBox lb_Course;
        private System.Windows.Forms.Panel panel_Course;
        private System.Windows.Forms.Panel panel_Student;
        private System.Windows.Forms.TabPage tbp_Staff;
        private System.Windows.Forms.ListBox lb_Staff;
        private System.Windows.Forms.Panel panel_Staff;
        private System.Windows.Forms.Label lb_Courses;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.Label lb_Desc;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TextBox tb_Desc;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.Button btn_Course_Delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_Day;
        private System.Windows.Forms.Button btn_Student_Delete;
        private System.Windows.Forms.Button btn_add2;
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
        private System.Windows.Forms.Button btn_Staff_Delete;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.Panel divider2;
        private System.Windows.Forms.Panel divider3;
        private System.Windows.Forms.ListBox lb_Student;
        private System.Windows.Forms.Label lb_ProgramNo;
        private System.Windows.Forms.TextBox tb_CourseNo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
    }
}