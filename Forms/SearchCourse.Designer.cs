namespace HCI.Forms
{
    partial class SearchCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lb_nofavailplace = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_place = new System.Windows.Forms.TextBox();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Search Course";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.tb_place);
            this.BaseContentWrapper.Controls.Add(this.tb_price);
            this.BaseContentWrapper.Controls.Add(this.lb_nofavailplace);
            this.BaseContentWrapper.Controls.Add(this.btn_Search);
            this.BaseContentWrapper.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price(Monthly):";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(544, 265);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 44);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lb_nofavailplace
            // 
            this.lb_nofavailplace.AutoSize = true;
            this.lb_nofavailplace.Location = new System.Drawing.Point(108, 154);
            this.lb_nofavailplace.Name = "lb_nofavailplace";
            this.lb_nofavailplace.Size = new System.Drawing.Size(228, 21);
            this.lb_nofavailplace.TabIndex = 8;
            this.lb_nofavailplace.Text = "Number of available places:";
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_price.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_price.Location = new System.Drawing.Point(364, 82);
            this.tb_price.Margin = new System.Windows.Forms.Padding(0);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(151, 32);
            this.tb_price.TabIndex = 12;
            // 
            // tb_place
            // 
            this.tb_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tb_place.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_place.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_place.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_place.Location = new System.Drawing.Point(364, 154);
            this.tb_place.Margin = new System.Windows.Forms.Padding(0);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(151, 32);
            this.tb_place.TabIndex = 13;
            // 
            // SearchCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "SearchCourse";
            this.Text = "SearchCourse";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseContentWrapper.PerformLayout();
            this.BaseNavigationAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lb_nofavailplace;
        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.TextBox tb_price;
    }
}