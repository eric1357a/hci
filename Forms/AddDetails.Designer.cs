﻿namespace HCI.Forms
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
            this.lb_Course = new System.Windows.Forms.Label();
            this.lb_Desc = new System.Windows.Forms.Label();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.lb_Day = new System.Windows.Forms.Label();
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.tb_Desc = new System.Windows.Forms.RichTextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.BaseContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Add Details";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaseContentPanel.Controls.Add(this.tb_Cost);
            this.BaseContentPanel.Controls.Add(this.tb_Course);
            this.BaseContentPanel.Controls.Add(this.btn_Cancel);
            this.BaseContentPanel.Controls.Add(this.btn_Submit);
            this.BaseContentPanel.Controls.Add(this.tb_Desc);
            this.BaseContentPanel.Controls.Add(this.tb_Day);
            this.BaseContentPanel.Controls.Add(this.lb_Day);
            this.BaseContentPanel.Controls.Add(this.lb_Cost);
            this.BaseContentPanel.Controls.Add(this.lb_Desc);
            this.BaseContentPanel.Controls.Add(this.lb_Course);
            // 
            // lb_Course
            // 
            this.lb_Course.AutoSize = true;
            this.lb_Course.Location = new System.Drawing.Point(174, 25);
            this.lb_Course.Name = "lb_Course";
            this.lb_Course.Size = new System.Drawing.Size(66, 20);
            this.lb_Course.TabIndex = 0;
            this.lb_Course.Text = "Course:";
            // 
            // lb_Desc
            // 
            this.lb_Desc.AutoSize = true;
            this.lb_Desc.Location = new System.Drawing.Point(145, 178);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(99, 20);
            this.lb_Desc.TabIndex = 2;
            this.lb_Desc.Text = "Description:";
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.Location = new System.Drawing.Point(193, 78);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(47, 20);
            this.lb_Cost.TabIndex = 3;
            this.lb_Cost.Text = "Cost:";
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(198, 125);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(42, 20);
            this.lb_Day.TabIndex = 4;
            this.lb_Day.Text = "Day:";
            // 
            // tb_Day
            // 
            this.tb_Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tb_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Day.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Day.Location = new System.Drawing.Point(246, 121);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(154, 32);
            this.tb_Day.TabIndex = 6;
            this.tb_Day.Leave += new System.EventHandler(this.tb_Day_Leave);
            // 
            // tb_Desc
            // 
            this.tb_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tb_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Desc.Location = new System.Drawing.Point(246, 175);
            this.tb_Desc.Multiline = false;
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(220, 96);
            this.tb_Desc.TabIndex = 7;
            this.tb_Desc.Text = "";
            this.tb_Desc.Leave += new System.EventHandler(this.tb_Desc_Leave);
            // 
            // btn_Submit
            // 
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Submit.Location = new System.Drawing.Point(202, 294);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 44);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cancel.Location = new System.Drawing.Point(387, 294);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 44);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Course
            // 
            this.tb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tb_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Course.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Course.Location = new System.Drawing.Point(246, 21);
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(154, 32);
            this.tb_Course.TabIndex = 10;
            this.tb_Course.Leave += new System.EventHandler(this.tb_Course_Leave);
            // 
            // tb_Cost
            // 
            this.tb_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tb_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Cost.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tb_Cost.Location = new System.Drawing.Point(246, 74);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(154, 32);
            this.tb_Cost.TabIndex = 11;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_KeyPress);
            this.tb_Cost.Leave += new System.EventHandler(this.tb_Cost_Leave);
            // 
            // AddDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "AddDetails";
            this.Text = "AddDetails";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Course;
        private System.Windows.Forms.Label lb_Desc;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.RichTextBox tb_Desc;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.TextBox tb_Cost;
    }
}