namespace HCI.Forms
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            this.PaymentTable = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_CreditCard = new System.Windows.Forms.Button();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.BaseNavigationAction.SuspendLayout();
            this.PaymentTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Payment Method";
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.PaymentTable);
            // 
            // PaymentTable
            // 
            this.PaymentTable.ColumnCount = 2;
            this.PaymentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PaymentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PaymentTable.Controls.Add(this.btn_Cash, 1, 0);
            this.PaymentTable.Controls.Add(this.btn_CreditCard, 0, 0);
            this.PaymentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentTable.Location = new System.Drawing.Point(0, 0);
            this.PaymentTable.Name = "PaymentTable";
            this.PaymentTable.RowCount = 1;
            this.PaymentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PaymentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.PaymentTable.Size = new System.Drawing.Size(720, 382);
            this.PaymentTable.TabIndex = 0;
            // 
            // btn_Cash
            // 
            this.btn_Cash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btn_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cash.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cash.Image = global::HCI.Properties.Resources.Banknotes_100;
            this.btn_Cash.Location = new System.Drawing.Point(360, 0);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(360, 382);
            this.btn_Cash.TabIndex = 1;
            this.btn_Cash.Text = "By Cash";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_CreditCard
            // 
            this.btn_CreditCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CreditCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.btn_CreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreditCard.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(183)))));
            this.btn_CreditCard.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreditCard.Image")));
            this.btn_CreditCard.Location = new System.Drawing.Point(0, 0);
            this.btn_CreditCard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CreditCard.Name = "btn_CreditCard";
            this.btn_CreditCard.Size = new System.Drawing.Size(360, 382);
            this.btn_CreditCard.TabIndex = 0;
            this.btn_CreditCard.Text = "By Credit Card";
            this.btn_CreditCard.UseVisualStyleBackColor = true;
            this.btn_CreditCard.Click += new System.EventHandler(this.btn_CreditCard_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Name = "PaymentMethod";
            this.Text = "PaymentMethod";
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.BaseNavigationAction.ResumeLayout(false);
            this.PaymentTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PaymentTable;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_CreditCard;
    }
}