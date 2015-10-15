namespace HCI.Forms
{
    partial class AddDetails
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Member = new System.Windows.Forms.Button();
            this.lb_Desc = new System.Windows.Forms.Label();
            this.lb_Day = new System.Windows.Forms.Label();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.lb_Course = new System.Windows.Forms.Label();
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.tb_Course = new System.Windows.Forms.TextBox();
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
            this.BaseContentWrapper.Controls.Add(this.tb_Desc);
            this.BaseContentWrapper.Controls.Add(this.btn_Member);
            this.BaseContentWrapper.Controls.Add(this.tb_Cost);
            this.BaseContentWrapper.Controls.Add(this.tb_Course);
            this.BaseContentWrapper.Controls.Add(this.btn_Cancel);
            this.BaseContentWrapper.Controls.Add(this.btn_Submit);
            this.BaseContentWrapper.Controls.Add(this.tb_Day);
            this.BaseContentWrapper.Controls.Add(this.lb_Day);
            this.BaseContentWrapper.Controls.Add(this.lb_Cost);
            this.BaseContentWrapper.Controls.Add(this.lb_Desc);
            this.BaseContentWrapper.Controls.Add(this.lb_Course);
            // 
            // btn_Submit
            // 
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(473, 317);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(93, 31);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(360, 317);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 31);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Member
            // 
            this.btn_Member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Member.Location = new System.Drawing.Point(621, 6);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(86, 36);
            this.btn_Member.TabIndex = 12;
            this.btn_Member.Text = "Member";
            this.btn_Member.UseVisualStyleBackColor = true;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // lb_Desc
            // 
            this.lb_Desc.AutoSize = true;
            this.lb_Desc.Location = new System.Drawing.Point(162, 179);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(101, 21);
            this.lb_Desc.TabIndex = 2;
            this.lb_Desc.Text = "Description:";
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(162, 127);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(45, 21);
            this.lb_Day.TabIndex = 4;
            this.lb_Day.Text = "Day:";
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Location = new System.Drawing.Point(162, 74);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(50, 21);
            this.lb_Cost.TabIndex = 3;
            this.lb_Cost.Text = "Cost:";
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Location = new System.Drawing.Point(162, 24);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(68, 21);
            this.lb_Course.TabIndex = 0;
            this.lb_Course.Text = "Course:";
            // 
            // tb_Desc
            // 
            this.tb_Desc.Location = new System.Drawing.Point(317, 173);
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(249, 27);
            this.tb_Desc.TabIndex = 13;
            // 
            // tb_Day
            // 
            this.tb_Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Day.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Day.Location = new System.Drawing.Point(317, 124);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(249, 32);
            this.tb_Day.TabIndex = 6;
            this.tb_Day.Leave += new System.EventHandler(this.tb_Day_Leave);
            // 
            // tb_Cost
            // 
            this.tb_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Cost.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Cost.Location = new System.Drawing.Point(317, 71);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(249, 32);
            this.tb_Cost.TabIndex = 11;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_KeyPress);
            this.tb_Cost.Leave += new System.EventHandler(this.tb_Cost_Leave);
            // 
            // tb_Course
            // 
            this.tb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Course.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Course.Location = new System.Drawing.Point(317, 21);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(249, 32);
            this.tb_Course.TabIndex = 10;
            this.tb_Course.Leave += new System.EventHandler(this.tb_Course_Leave);
            // 
            // AddDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "AddDetails";
            this.Text = "AddDetails";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Desc;
        private System.Windows.Forms.Button btn_Member;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.Label lb_Desc;
        private System.Windows.Forms.Label lb_Course;

    }
}