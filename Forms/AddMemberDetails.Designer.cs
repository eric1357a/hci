namespace HCI.Forms
{
    partial class AddMemberDetails
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
            this.btn_Course = new System.Windows.Forms.Button();
            this.lb_studentName = new System.Windows.Forms.Label();
            this.tb_studentName = new System.Windows.Forms.TextBox();
            this.lb_ConNo = new System.Windows.Forms.Label();
            this.tb_ContactNo = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_Member = new System.Windows.Forms.Label();
            this.clb_Member = new System.Windows.Forms.CheckedListBox();
            this.lb_staffName = new System.Windows.Forms.Label();
            this.tb_staffName = new System.Windows.Forms.TextBox();
            this.lb_pw = new System.Windows.Forms.Label();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.lb_Position = new System.Windows.Forms.Label();
            this.clb_Position = new System.Windows.Forms.CheckedListBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Add Details";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.btn_Cancel);
            this.BaseContentWrapper.Controls.Add(this.btn_Submit);
            this.BaseContentWrapper.Controls.Add(this.clb_Position);
            this.BaseContentWrapper.Controls.Add(this.lb_Position);
            this.BaseContentWrapper.Controls.Add(this.tb_Pw);
            this.BaseContentWrapper.Controls.Add(this.lb_pw);
            this.BaseContentWrapper.Controls.Add(this.tb_staffName);
            this.BaseContentWrapper.Controls.Add(this.lb_staffName);
            this.BaseContentWrapper.Controls.Add(this.clb_Member);
            this.BaseContentWrapper.Controls.Add(this.lb_Member);
            this.BaseContentWrapper.Controls.Add(this.tb_email);
            this.BaseContentWrapper.Controls.Add(this.lb_email);
            this.BaseContentWrapper.Controls.Add(this.tb_ContactNo);
            this.BaseContentWrapper.Controls.Add(this.lb_ConNo);
            this.BaseContentWrapper.Controls.Add(this.tb_studentName);
            this.BaseContentWrapper.Controls.Add(this.lb_studentName);
            this.BaseContentWrapper.Controls.Add(this.btn_Course);
            // 
            // btn_Course
            // 
            this.btn_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course.Location = new System.Drawing.Point(623, 6);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Size = new System.Drawing.Size(86, 36);
            this.btn_Course.TabIndex = 13;
            this.btn_Course.Text = "Course";
            this.btn_Course.UseVisualStyleBackColor = true;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click);
            // 
            // lb_studentName
            // 
            this.lb_studentName.AutoSize = true;
            this.lb_studentName.Location = new System.Drawing.Point(45, 52);
            this.lb_studentName.Name = "lb_studentName";
            this.lb_studentName.Size = new System.Drawing.Size(129, 21);
            this.lb_studentName.TabIndex = 14;
            this.lb_studentName.Text = "Student Name:";
            // 
            // tb_studentName
            // 
            this.tb_studentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_studentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_studentName.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_studentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_studentName.Location = new System.Drawing.Point(182, 52);
            this.tb_studentName.Name = "tb_studentName";
            this.tb_studentName.Size = new System.Drawing.Size(154, 32);
            this.tb_studentName.TabIndex = 15;
            this.tb_studentName.Leave += new System.EventHandler(this.tb_studentName_Leave);
            // 
            // lb_ConNo
            // 
            this.lb_ConNo.AutoSize = true;
            this.lb_ConNo.Location = new System.Drawing.Point(25, 105);
            this.lb_ConNo.Name = "lb_ConNo";
            this.lb_ConNo.Size = new System.Drawing.Size(149, 21);
            this.lb_ConNo.TabIndex = 16;
            this.lb_ConNo.Text = "Contact Number:";
            // 
            // tb_ContactNo
            // 
            this.tb_ContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ContactNo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_ContactNo.Location = new System.Drawing.Point(182, 105);
            this.tb_ContactNo.Name = "tb_ContactNo";
            this.tb_ContactNo.Size = new System.Drawing.Size(154, 32);
            this.tb_ContactNo.TabIndex = 17;
            this.tb_ContactNo.Leave += new System.EventHandler(this.tb_conNo_Leave);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(55, 162);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(121, 21);
            this.lb_email.TabIndex = 18;
            this.lb_email.Text = "Email Address:";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_email.Location = new System.Drawing.Point(182, 162);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(154, 32);
            this.tb_email.TabIndex = 19;
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // lb_Member
            // 
            this.lb_Member.AutoSize = true;
            this.lb_Member.Location = new System.Drawing.Point(94, 207);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(80, 21);
            this.lb_Member.TabIndex = 36;
            this.lb_Member.Text = "Member:";
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
            this.clb_Member.Location = new System.Drawing.Point(182, 207);
            this.clb_Member.Margin = new System.Windows.Forms.Padding(0);
            this.clb_Member.Name = "clb_Member";
            this.clb_Member.Size = new System.Drawing.Size(137, 44);
            this.clb_Member.TabIndex = 37;
            this.clb_Member.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Member_ItemCheck);
            this.clb_Member.Leave += new System.EventHandler(this.clb_Member_Leave);
            // 
            // lb_staffName
            // 
            this.lb_staffName.AutoSize = true;
            this.lb_staffName.Location = new System.Drawing.Point(356, 52);
            this.lb_staffName.Name = "lb_staffName";
            this.lb_staffName.Size = new System.Drawing.Size(102, 21);
            this.lb_staffName.TabIndex = 38;
            this.lb_staffName.Text = "Staff Name:";
            // 
            // tb_staffName
            // 
            this.tb_staffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_staffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_staffName.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_staffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_staffName.Location = new System.Drawing.Point(463, 52);
            this.tb_staffName.Name = "tb_staffName";
            this.tb_staffName.Size = new System.Drawing.Size(154, 32);
            this.tb_staffName.TabIndex = 39;
            this.tb_staffName.Leave += new System.EventHandler(this.tb_staffName_Leave);
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Location = new System.Drawing.Point(371, 105);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(86, 21);
            this.lb_pw.TabIndex = 40;
            this.lb_pw.Text = "Password:";
            // 
            // tb_Pw
            // 
            this.tb_Pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Pw.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Pw.Location = new System.Drawing.Point(463, 102);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(154, 32);
            this.tb_Pw.TabIndex = 41;
            this.tb_Pw.Leave += new System.EventHandler(this.tb_Pw_Leave);
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(385, 162);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(72, 21);
            this.lb_Position.TabIndex = 42;
            this.lb_Position.Text = "Position:";
            // 
            // clb_Position
            // 
            this.clb_Position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.clb_Position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_Position.FormattingEnabled = true;
            this.clb_Position.Items.AddRange(new object[] {
            "Staff",
            "Manager",
            "Admin"});
            this.clb_Position.Location = new System.Drawing.Point(463, 162);
            this.clb_Position.Name = "clb_Position";
            this.clb_Position.Size = new System.Drawing.Size(120, 66);
            this.clb_Position.TabIndex = 43;
            this.clb_Position.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_Position_ItemCheck);
            this.clb_Position.Leave += new System.EventHandler(this.clb_Position_Leave);
            // 
            // btn_Submit
            // 
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(211, 286);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 44);
            this.btn_Submit.TabIndex = 44;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(426, 286);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 44);
            this.btn_Cancel.TabIndex = 45;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AddMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "AddMemberDetails";
            this.Text = "AddMemberDetails";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Course;
        private System.Windows.Forms.Label lb_studentName;
        private System.Windows.Forms.TextBox tb_studentName;
        private System.Windows.Forms.Label lb_ConNo;
        private System.Windows.Forms.TextBox tb_ContactNo;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_Member;
        private System.Windows.Forms.CheckedListBox clb_Member;
        private System.Windows.Forms.TextBox tb_staffName;
        private System.Windows.Forms.Label lb_staffName;
        private System.Windows.Forms.CheckedListBox clb_Position;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.TextBox tb_Pw;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
    }
}