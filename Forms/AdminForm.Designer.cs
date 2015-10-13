namespace HCI.Forms
{
    partial class AdminForm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Administration Menu";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(720, 487);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.btn_del);
            this.BaseContentWrapper.Controls.Add(this.btn_modify);
            this.BaseContentWrapper.Controls.Add(this.btn_search);
            this.BaseContentWrapper.Controls.Add(this.btn_view);
            this.BaseContentWrapper.Controls.Add(this.btn_add);
            this.BaseContentWrapper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BaseContentWrapper.Size = new System.Drawing.Size(720, 433);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_add.Location = new System.Drawing.Point(173, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(375, 73);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add Details";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_view
            // 
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Location = new System.Drawing.Point(173, 86);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(375, 73);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View Course Details";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(173, 166);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(375, 73);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search Courses";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Location = new System.Drawing.Point(173, 246);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(375, 73);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "Modify Details";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_del
            // 
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(173, 326);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(375, 73);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "Delete Details";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 531);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_add;
    }
}