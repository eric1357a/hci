namespace HCI.Forms
{
    partial class ModifyDetails
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
            this.lb_Course = new System.Windows.Forms.Label();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.lb_Day = new System.Windows.Forms.Label();
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.lb_Desc = new System.Windows.Forms.Label();
            this.tb_Desc = new System.Windows.Forms.RichTextBox();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Modify Details";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.tb_Desc);
            this.BaseContentWrapper.Controls.Add(this.lb_Desc);
            this.BaseContentWrapper.Controls.Add(this.tb_Day);
            this.BaseContentWrapper.Controls.Add(this.lb_Day);
            this.BaseContentWrapper.Controls.Add(this.tb_Cost);
            this.BaseContentWrapper.Controls.Add(this.tb_Course);
            this.BaseContentWrapper.Controls.Add(this.lb_Cost);
            this.BaseContentWrapper.Controls.Add(this.lb_Course);
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Location = new System.Drawing.Point(60, 17);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(68, 21);
            this.lb_Course.TabIndex = 1;
            this.lb_Course.Text = "Course:";
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Location = new System.Drawing.Point(60, 65);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(50, 21);
            this.lb_Cost.TabIndex = 4;
            this.lb_Cost.Text = "Cost:";
            // 
            // tb_Course
            // 
            this.tb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Course.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Course.Location = new System.Drawing.Point(159, 17);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(154, 32);
            this.tb_Course.TabIndex = 11;
            // 
            // tb_Cost
            // 
            this.tb_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Cost.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Cost.Location = new System.Drawing.Point(159, 62);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(154, 32);
            this.tb_Cost.TabIndex = 12;
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(60, 108);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(45, 21);
            this.lb_Day.TabIndex = 13;
            this.lb_Day.Text = "Day:";
            // 
            // tb_Day
            // 
            this.tb_Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Day.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Day.Location = new System.Drawing.Point(159, 108);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(154, 32);
            this.tb_Day.TabIndex = 14;
            // 
            // lb_Desc
            // 
            this.lb_Desc.AutoSize = true;
            this.lb_Desc.Location = new System.Drawing.Point(60, 153);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(101, 21);
            this.lb_Desc.TabIndex = 15;
            this.lb_Desc.Text = "Description:";
            // 
            // tb_Desc
            // 
            this.tb_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Desc.Location = new System.Drawing.Point(159, 153);
            this.tb_Desc.Multiline = false;
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(220, 96);
            this.tb_Desc.TabIndex = 16;
            this.tb_Desc.Text = "";
            // 
            // ModifyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "ModifyDetails";
            this.Text = "ModifyDetails";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Course;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.Label lb_Desc;
        private System.Windows.Forms.RichTextBox tb_Desc;
    }
}