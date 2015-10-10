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
            this.lbmemberdiscount = new System.Windows.Forms.Label();
            this.btndiscountUp = new System.Windows.Forms.Button();
            this.btnDiscountDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProfitUp = new System.Windows.Forms.Button();
            this.btnProfitDown = new System.Windows.Forms.Button();
            this.btnCCUp = new System.Windows.Forms.Button();
            this.discountBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCCDown = new System.Windows.Forms.Button();
            this.profitBar = new System.Windows.Forms.TrackBar();
            this.Creditbar = new System.Windows.Forms.TrackBar();
            this.tbdiscount = new System.Windows.Forms.TextBox();
            this.tbprofit = new System.Windows.Forms.TextBox();
            this.tbCCDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManagerGroupBox = new HCI.Controls.NewGroupBox();
            this.btnNormalMember = new System.Windows.Forms.RadioButton();
            this.btnGoldMember = new System.Windows.Forms.RadioButton();
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
            // lbmemberdiscount
            // 
            this.lbmemberdiscount.AutoSize = true;
            this.lbmemberdiscount.Location = new System.Drawing.Point(285, 48);
            this.lbmemberdiscount.Name = "lbmemberdiscount";
            this.lbmemberdiscount.Size = new System.Drawing.Size(144, 20);
            this.lbmemberdiscount.TabIndex = 0;
            this.lbmemberdiscount.Text = "Member Discount";
            // 
            // btndiscountUp
            // 
            this.btndiscountUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiscountUp.Location = new System.Drawing.Point(619, 107);
            this.btndiscountUp.Name = "btndiscountUp";
            this.btndiscountUp.Size = new System.Drawing.Size(81, 37);
            this.btndiscountUp.TabIndex = 3;
            this.btndiscountUp.Text = "+1%";
            this.btndiscountUp.UseVisualStyleBackColor = true;
            this.btndiscountUp.Click += new System.EventHandler(this.memberup_Click);
            // 
            // btnDiscountDown
            // 
            this.btnDiscountDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountDown.Location = new System.Drawing.Point(49, 107);
            this.btnDiscountDown.Name = "btnDiscountDown";
            this.btnDiscountDown.Size = new System.Drawing.Size(68, 37);
            this.btnDiscountDown.TabIndex = 4;
            this.btnDiscountDown.Text = "-1%";
            this.btnDiscountDown.UseVisualStyleBackColor = true;
            this.btnDiscountDown.Click += new System.EventHandler(this.memberdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profit Margin";
            // 
            // btnProfitUp
            // 
            this.btnProfitUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfitUp.Location = new System.Drawing.Point(619, 336);
            this.btnProfitUp.Name = "btnProfitUp";
            this.btnProfitUp.Size = new System.Drawing.Size(81, 37);
            this.btnProfitUp.TabIndex = 9;
            this.btnProfitUp.Text = "+1%";
            this.btnProfitUp.UseVisualStyleBackColor = true;
            this.btnProfitUp.Click += new System.EventHandler(this.btnProfitUp_Click);
            // 
            // btnProfitDown
            // 
            this.btnProfitDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfitDown.Location = new System.Drawing.Point(49, 336);
            this.btnProfitDown.Name = "btnProfitDown";
            this.btnProfitDown.Size = new System.Drawing.Size(68, 37);
            this.btnProfitDown.TabIndex = 10;
            this.btnProfitDown.Text = "-1%";
            this.btnProfitDown.UseVisualStyleBackColor = true;
            this.btnProfitDown.Click += new System.EventHandler(this.btnProfitDown_Click);
            // 
            // btnCCUp
            // 
            this.btnCCUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCUp.Location = new System.Drawing.Point(619, 213);
            this.btnCCUp.Name = "btnCCUp";
            this.btnCCUp.Size = new System.Drawing.Size(81, 37);
            this.btnCCUp.TabIndex = 57;
            this.btnCCUp.Text = "+1%";
            this.btnCCUp.UseVisualStyleBackColor = true;
            this.btnCCUp.Click += new System.EventHandler(this.CCUp_Click);
            // 
            // discountBar
            // 
            this.discountBar.LargeChange = 10;
            this.discountBar.Location = new System.Drawing.Point(123, 95);
            this.discountBar.Maximum = 100;
            this.discountBar.Name = "discountBar";
            this.discountBar.Size = new System.Drawing.Size(490, 45);
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
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Credit Card Discount";
            // 
            // btnCCDown
            // 
            this.btnCCDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCDown.Location = new System.Drawing.Point(49, 213);
            this.btnCCDown.Name = "btnCCDown";
            this.btnCCDown.Size = new System.Drawing.Size(68, 37);
            this.btnCCDown.TabIndex = 58;
            this.btnCCDown.Text = "-1%";
            this.btnCCDown.UseVisualStyleBackColor = true;
            this.btnCCDown.Click += new System.EventHandler(this.CCDown_Click);
            // 
            // profitBar
            // 
            this.profitBar.LargeChange = 10;
            this.profitBar.Location = new System.Drawing.Point(127, 335);
            this.profitBar.Maximum = 100;
            this.profitBar.Name = "profitBar";
            this.profitBar.Size = new System.Drawing.Size(490, 45);
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
            this.Creditbar.Size = new System.Drawing.Size(490, 45);
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
            this.tbdiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tbdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tbdiscount.Location = new System.Drawing.Point(500, 45);
            this.tbdiscount.MaxLength = 3;
            this.tbdiscount.Name = "tbdiscount";
            this.tbdiscount.Size = new System.Drawing.Size(50, 29);
            this.tbdiscount.TabIndex = 51;
            this.tbdiscount.Text = "100";
            this.tbdiscount.TextChanged += new System.EventHandler(this.tbdiscount_TextChanged);
            // 
            // tbprofit
            // 
            this.tbprofit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tbprofit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbprofit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tbprofit.Location = new System.Drawing.Point(500, 283);
            this.tbprofit.MaxLength = 3;
            this.tbprofit.Name = "tbprofit";
            this.tbprofit.Size = new System.Drawing.Size(50, 29);
            this.tbprofit.TabIndex = 54;
            this.tbprofit.Text = "100";
            this.tbprofit.TextChanged += new System.EventHandler(this.tbprofit_TextChanged);
            // 
            // tbCCDiscount
            // 
            this.tbCCDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.tbCCDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCCDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.tbCCDiscount.Location = new System.Drawing.Point(500, 160);
            this.tbCCDiscount.MaxLength = 3;
            this.tbCCDiscount.Name = "tbCCDiscount";
            this.tbCCDiscount.Size = new System.Drawing.Size(50, 29);
            this.tbCCDiscount.TabIndex = 60;
            this.tbCCDiscount.Text = "100";
            this.tbCCDiscount.TextChanged += new System.EventHandler(this.tbCCD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "%";
            // 
            // ManagerGroupBox
            // 
            this.ManagerGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ManagerGroupBox.Controls.Add(this.btnNormalMember);
            this.ManagerGroupBox.Controls.Add(this.btnGoldMember);
            this.ManagerGroupBox.Controls.Add(this.label3);
            this.ManagerGroupBox.Controls.Add(this.label5);
            this.ManagerGroupBox.Controls.Add(this.label4);
            this.ManagerGroupBox.Controls.Add(this.tbCCDiscount);
            this.ManagerGroupBox.Controls.Add(this.tbprofit);
            this.ManagerGroupBox.Controls.Add(this.tbdiscount);
            this.ManagerGroupBox.Controls.Add(this.Creditbar);
            this.ManagerGroupBox.Controls.Add(this.profitBar);
            this.ManagerGroupBox.Controls.Add(this.btnCCDown);
            this.ManagerGroupBox.Controls.Add(this.label6);
            this.ManagerGroupBox.Controls.Add(this.discountBar);
            this.ManagerGroupBox.Controls.Add(this.btnCCUp);
            this.ManagerGroupBox.Controls.Add(this.btnProfitDown);
            this.ManagerGroupBox.Controls.Add(this.btnProfitUp);
            this.ManagerGroupBox.Controls.Add(this.label2);
            this.ManagerGroupBox.Controls.Add(this.btnDiscountDown);
            this.ManagerGroupBox.Controls.Add(this.btndiscountUp);
            this.ManagerGroupBox.Controls.Add(this.lbmemberdiscount);
            this.ManagerGroupBox.LegendPosition = HCI.Controls.Lposition.Center;
            this.ManagerGroupBox.Location = new System.Drawing.Point(44, 151);
            this.ManagerGroupBox.Name = "ManagerGroupBox";
            this.ManagerGroupBox.Size = new System.Drawing.Size(807, 409);
            this.ManagerGroupBox.TabIndex = 3;
            this.ManagerGroupBox.TabStop = false;
            this.ManagerGroupBox.Text = "Manager Area";
            // 
            // btnNormalMember
            // 
            this.btnNormalMember.AutoSize = true;
            this.btnNormalMember.Location = new System.Drawing.Point(49, 60);
            this.btnNormalMember.Name = "btnNormalMember";
            this.btnNormalMember.Size = new System.Drawing.Size(84, 24);
            this.btnNormalMember.TabIndex = 63;
            this.btnNormalMember.TabStop = true;
            this.btnNormalMember.Text = "Normal";
            this.btnNormalMember.UseVisualStyleBackColor = true;
            this.btnNormalMember.Click += new System.EventHandler(this.btnNormalMember_Click);
            // 
            // btnGoldMember
            // 
            this.btnGoldMember.AutoSize = true;
            this.btnGoldMember.ForeColor = System.Drawing.Color.Yellow;
            this.btnGoldMember.Location = new System.Drawing.Point(49, 29);
            this.btnGoldMember.Name = "btnGoldMember";
            this.btnGoldMember.Size = new System.Drawing.Size(63, 24);
            this.btnGoldMember.TabIndex = 62;
            this.btnGoldMember.TabStop = true;
            this.btnGoldMember.Text = "Gold";
            this.btnGoldMember.UseVisualStyleBackColor = true;
            this.btnGoldMember.Click += new System.EventHandler(this.btnGoldMember_Click);
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
        private System.Windows.Forms.Button btnCCDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar discountBar;
        private System.Windows.Forms.Button btnCCUp;
        private System.Windows.Forms.Button btnProfitDown;
        private System.Windows.Forms.Button btnProfitUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDiscountDown;
        private System.Windows.Forms.Button btndiscountUp;
        private System.Windows.Forms.Label lbmemberdiscount;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.RadioButton btnNormalMember;
        private System.Windows.Forms.RadioButton btnGoldMember;
    }
}