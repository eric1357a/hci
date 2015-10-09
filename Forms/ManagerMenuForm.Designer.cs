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
            this.ManagerGroupBox = new HCI.Controls.NewGroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.profitMar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseContentPanel.SuspendLayout();
            this.ManagerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.BaseNavigationText.Text = "Staff Menu";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.ManagerGroupBox);
            this.BaseContentPanel.Controls.Add(this.btn_view);
            this.BaseContentPanel.Size = new System.Drawing.Size(896, 540);
            // 
            // btn_view
            // 
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Location = new System.Drawing.Point(212, 53);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(448, 105);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View Course Details";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // ManagerGroupBox
            // 
            this.ManagerGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.ManagerGroupBox.Controls.Add(this.button5);
            this.ManagerGroupBox.Controls.Add(this.button6);
            this.ManagerGroupBox.Controls.Add(this.button7);
            this.ManagerGroupBox.Controls.Add(this.button8);
            this.ManagerGroupBox.Controls.Add(this.profitMar);
            this.ManagerGroupBox.Controls.Add(this.label2);
            this.ManagerGroupBox.Controls.Add(this.button4);
            this.ManagerGroupBox.Controls.Add(this.button3);
            this.ManagerGroupBox.Controls.Add(this.button2);
            this.ManagerGroupBox.Controls.Add(this.button1);
            this.ManagerGroupBox.Controls.Add(this.discount);
            this.ManagerGroupBox.Controls.Add(this.label1);
            this.ManagerGroupBox.LegendPosition = HCI.Controls.Lposition.Center;
            this.ManagerGroupBox.Location = new System.Drawing.Point(49, 205);
            this.ManagerGroupBox.Name = "ManagerGroupBox";
            this.ManagerGroupBox.Size = new System.Drawing.Size(820, 297);
            this.ManagerGroupBox.TabIndex = 3;
            this.ManagerGroupBox.TabStop = false;
            this.ManagerGroupBox.Text = "Manager Area";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(329, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 37);
            this.button5.TabIndex = 11;
            this.button5.Text = "-10%";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(255, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 37);
            this.button6.TabIndex = 10;
            this.button6.Text = "-1%";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(418, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 37);
            this.button7.TabIndex = 9;
            this.button7.Text = "+1%";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(505, 223);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 37);
            this.button8.TabIndex = 8;
            this.button8.Text = "+10%";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // profitMar
            // 
            this.profitMar.AutoSize = true;
            this.profitMar.Location = new System.Drawing.Point(544, 173);
            this.profitMar.Name = "profitMar";
            this.profitMar.Size = new System.Drawing.Size(81, 30);
            this.profitMar.TabIndex = 7;
            this.profitMar.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profit Margin";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(329, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "-10%";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(255, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "-1%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(418, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "+1%";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(505, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "+10%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(544, 51);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(81, 30);
            this.discount.TabIndex = 1;
            this.discount.Text = "label2";
            this.discount.Click += new System.EventHandler(this.discount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Discount To Members";
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 660);
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "ManagerMenuForm";
            this.Text = "SMainMenu";
            this.Load += new System.EventHandler(this.ManagerMenuForm_Load);
            this.BaseContentPanel.ResumeLayout(false);
            this.ManagerGroupBox.ResumeLayout(false);
            this.ManagerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NewGroupBox ManagerGroupBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label profitMar;
        private System.Windows.Forms.Label label2;
    }
}