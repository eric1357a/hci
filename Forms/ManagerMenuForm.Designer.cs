namespace HCI.Forms
{
    partial class ManagerMenuForm
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
            this.btn_view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.discountBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.profitBar = new System.Windows.Forms.TrackBar();
            this.Creditbar = new System.Windows.Forms.TrackBar();
            this.tbdiscount = new System.Windows.Forms.TextBox();
            this.tbprofit = new System.Windows.Forms.TextBox();
            this.tbCCDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManagerGroupBox = new HCI.Controls.NewGroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditbar)).BeginInit();
            this.ManagerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.BaseNavigationText.Text = "Manager Menu";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(896, 695);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(896, 66);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.btn_view);
            this.BaseContentWrapper.Controls.Add(this.ManagerGroupBox);
            this.BaseContentWrapper.Controls.Add(this.btnSearch);
            this.BaseContentWrapper.Size = new System.Drawing.Size(896, 629);
            // 
            // btn_view
            // 
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Location = new System.Drawing.Point(44, 27);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(324, 105);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View Course Details";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Discount";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(619, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "+1%";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(49, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "-1%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.memberdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profit Margin";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(619, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 37);
            this.button7.TabIndex = 9;
            this.button7.Text = "+1%";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(49, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 37);
            this.button6.TabIndex = 10;
            this.button6.Text = "-1%";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(619, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 37);
            this.button4.TabIndex = 57;
            this.button4.Text = "+1%";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CCUp_Click);
            // 
            // discountBar
            // 
            this.discountBar.LargeChange = 10;
            this.discountBar.Location = new System.Drawing.Point(123, 95);
            this.discountBar.Maximum = 100;
            this.discountBar.Name = "discountBar";
            this.discountBar.Size = new System.Drawing.Size(490, 56);
            this.discountBar.SmallChange = 10;
            this.discountBar.TabIndex = 50;
            this.discountBar.TickFrequency = 10;
            this.discountBar.Value = 50;
            this.discountBar.ValueChanged += new System.EventHandler(this.discountBar_ValueChanged);
            this.discountBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountBar_KeyDown);
            this.discountBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.discountBar_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Credit Card Discount";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(49, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 37);
            this.button1.TabIndex = 58;
            this.button1.Text = "-1%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CCDown_Click);
            // 
            // profitBar
            // 
            this.profitBar.LargeChange = 10;
            this.profitBar.Location = new System.Drawing.Point(127, 335);
            this.profitBar.Maximum = 100;
            this.profitBar.Name = "profitBar";
            this.profitBar.Size = new System.Drawing.Size(490, 56);
            this.profitBar.SmallChange = 10;
            this.profitBar.TabIndex = 13;
            this.profitBar.TickFrequency = 10;
            this.profitBar.Value = 40;
            this.profitBar.ValueChanged += new System.EventHandler(this.profitBar_ValueChanged);
            this.profitBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.profitBar_KeyDown);
            this.profitBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.profitBar_MouseUp);
            // 
            // Creditbar
            // 
            this.Creditbar.LargeChange = 10;
            this.Creditbar.Location = new System.Drawing.Point(127, 212);
            this.Creditbar.Maximum = 100;
            this.Creditbar.Name = "Creditbar";
            this.Creditbar.Size = new System.Drawing.Size(490, 56);
            this.Creditbar.SmallChange = 10;
            this.Creditbar.TabIndex = 59;
            this.Creditbar.TickFrequency = 10;
            this.Creditbar.Value = 5;
            this.Creditbar.ValueChanged += new System.EventHandler(this.Creditbar_ValueChanged);
            this.Creditbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Creditbar_KeyDown);
            this.Creditbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Creditbar_MouseUp);
            // 
            // tbdiscount
            // 
            this.tbdiscount.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbdiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tbdiscount.Location = new System.Drawing.Point(500, 45);
            this.tbdiscount.MaxLength = 3;
            this.tbdiscount.Name = "tbdiscount";
            this.tbdiscount.Size = new System.Drawing.Size(50, 34);
            this.tbdiscount.TabIndex = 51;
            this.tbdiscount.Text = "100";
            this.tbdiscount.TextChanged += new System.EventHandler(this.tbdiscount_TextChanged);
            // 
            // tbprofit
            // 
            this.tbprofit.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbprofit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tbprofit.Location = new System.Drawing.Point(500, 283);
            this.tbprofit.MaxLength = 3;
            this.tbprofit.Name = "tbprofit";
            this.tbprofit.Size = new System.Drawing.Size(50, 34);
            this.tbprofit.TabIndex = 54;
            this.tbprofit.Text = "100";
            this.tbprofit.TextChanged += new System.EventHandler(this.tbprofit_TextChanged);
            // 
            // tbCCDiscount
            // 
            this.tbCCDiscount.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbCCDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tbCCDiscount.Location = new System.Drawing.Point(500, 160);
            this.tbCCDiscount.MaxLength = 3;
            this.tbCCDiscount.Name = "tbCCDiscount";
            this.tbCCDiscount.Size = new System.Drawing.Size(50, 34);
            this.tbCCDiscount.TabIndex = 60;
            this.tbCCDiscount.Text = "100";
            this.tbCCDiscount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "%";
            // 
            // ManagerGroupBox
            // 
            this.ManagerGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ManagerGroupBox.Controls.Add(this.label3);
            this.ManagerGroupBox.Controls.Add(this.label5);
            this.ManagerGroupBox.Controls.Add(this.label4);
            this.ManagerGroupBox.Controls.Add(this.tbCCDiscount);
            this.ManagerGroupBox.Controls.Add(this.tbprofit);
            this.ManagerGroupBox.Controls.Add(this.tbdiscount);
            this.ManagerGroupBox.Controls.Add(this.Creditbar);
            this.ManagerGroupBox.Controls.Add(this.profitBar);
            this.ManagerGroupBox.Controls.Add(this.button1);
            this.ManagerGroupBox.Controls.Add(this.label6);
            this.ManagerGroupBox.Controls.Add(this.discountBar);
            this.ManagerGroupBox.Controls.Add(this.button4);
            this.ManagerGroupBox.Controls.Add(this.button6);
            this.ManagerGroupBox.Controls.Add(this.button7);
            this.ManagerGroupBox.Controls.Add(this.label2);
            this.ManagerGroupBox.Controls.Add(this.button3);
            this.ManagerGroupBox.Controls.Add(this.button2);
            this.ManagerGroupBox.Controls.Add(this.label1);
            this.ManagerGroupBox.LegendPosition = HCI.Controls.Lposition.Center;
            this.ManagerGroupBox.Location = new System.Drawing.Point(44, 151);
            this.ManagerGroupBox.Name = "ManagerGroupBox";
            this.ManagerGroupBox.Size = new System.Drawing.Size(807, 409);
            this.ManagerGroupBox.TabIndex = 3;
            this.ManagerGroupBox.TabStop = false;
            this.ManagerGroupBox.Text = "Manager Area";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(527, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(324, 105);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Courses";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(896, 749);
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "ManagerMenuForm";
            this.Text = "SMainMenu";
            this.Load += new System.EventHandler(this.ManagerMenuForm_Load);
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discountBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Creditbar)).EndInit();
            this.ManagerGroupBox.ResumeLayout(false);
            this.ManagerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private Controls.NewGroupBox ManagerGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCCDiscount;
        private System.Windows.Forms.TextBox tbprofit;
        private System.Windows.Forms.TextBox tbdiscount;
        private System.Windows.Forms.TrackBar Creditbar;
        private System.Windows.Forms.TrackBar profitBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar discountBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_view;
    }
}