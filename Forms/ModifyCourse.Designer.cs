namespace HCI.Forms
{
    partial class ModifyCourse
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
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.cb_Day = new System.Windows.Forms.ComboBox();
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.lb_Courses = new System.Windows.Forms.Label();
            this.lb_Desc = new System.Windows.Forms.Label();
            this.lb_Day = new System.Windows.Forms.Label();
            this.lb_Cost = new System.Windows.Forms.Label();
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
            this.BaseNavigationText.Text = "Modify Course";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.btn_Cancel);
            this.BaseContentWrapper.Controls.Add(this.btn_Submit);
            this.BaseContentWrapper.Controls.Add(this.lb_Desc);
            this.BaseContentWrapper.Controls.Add(this.lb_Day);
            this.BaseContentWrapper.Controls.Add(this.lb_Cost);
            this.BaseContentWrapper.Controls.Add(this.lb_Courses);
            this.BaseContentWrapper.Controls.Add(this.tb_Desc);
            this.BaseContentWrapper.Controls.Add(this.cb_Day);
            this.BaseContentWrapper.Controls.Add(this.tb_Cost);
            this.BaseContentWrapper.Controls.Add(this.tb_Course);
            // 
            // tb_Course
            // 
            this.tb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Course.Location = new System.Drawing.Point(341, 53);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(214, 27);
            this.tb_Course.TabIndex = 15;
            // 
            // tb_Cost
            // 
            this.tb_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Cost.Location = new System.Drawing.Point(341, 103);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(214, 27);
            this.tb_Cost.TabIndex = 16;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_KeyPress);
            // 
            // cb_Day
            // 
            this.cb_Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.cb_Day.FormattingEnabled = true;
            this.cb_Day.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.cb_Day.Location = new System.Drawing.Point(341, 153);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(214, 29);
            this.cb_Day.TabIndex = 20;
            // 
            // tb_Desc
            // 
            this.tb_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Desc.Location = new System.Drawing.Point(341, 203);
            this.tb_Desc.Multiline = true;
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(214, 88);
            this.tb_Desc.TabIndex = 21;
            this.tb_Desc.TextChanged += new System.EventHandler(this.tb_Desc_TextChanged);
            // 
            // lb_Courses
            // 
            this.lb_Courses.AutoSize = true;
            this.lb_Courses.Location = new System.Drawing.Point(191, 53);
            this.lb_Courses.Name = "lb_Courses";
            this.lb_Courses.Size = new System.Drawing.Size(68, 21);
            this.lb_Courses.TabIndex = 22;
            this.lb_Courses.Text = "Course:";
            // 
            // lb_Desc
            // 
            this.lb_Desc.AutoSize = true;
            this.lb_Desc.Location = new System.Drawing.Point(191, 203);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(101, 21);
            this.lb_Desc.TabIndex = 25;
            this.lb_Desc.Text = "Description:";
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(191, 153);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(45, 21);
            this.lb_Day.TabIndex = 24;
            this.lb_Day.Text = "Day:";
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Location = new System.Drawing.Point(191, 103);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(50, 21);
            this.lb_Cost.TabIndex = 23;
            this.lb_Cost.Text = "Cost:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(462, 322);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(93, 31);
            this.btn_Submit.TabIndex = 26;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(341, 322);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 31);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ModifyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "ModifyCourse";
            this.Text = "ModifyCourse";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.ComboBox cb_Day;
        private System.Windows.Forms.TextBox tb_Desc;
        private System.Windows.Forms.Label lb_Courses;
        private System.Windows.Forms.Label lb_Desc;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
    }
}