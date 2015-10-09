namespace HCI.Forms
{
    partial class InvoiceContainer
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
            this.rv_Invoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaseContentPanel.SuspendLayout();
            this.BaseNavigation.SuspendLayout();
            this.BaseContentWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Invoice";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Size = new System.Drawing.Size(900, 846);
            // 
            // BaseNavigation
            // 
            this.BaseNavigation.Size = new System.Drawing.Size(900, 66);
            // 
            // BaseContentWrapper
            // 
            this.BaseContentWrapper.Controls.Add(this.rv_Invoice);
            this.BaseContentWrapper.Size = new System.Drawing.Size(900, 780);
            // 
            // rv_Invoice
            // 
            this.rv_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.rv_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Invoice.DocumentMapWidth = 394;
            this.rv_Invoice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rv_Invoice.LocalReport.ReportEmbeddedResource = "HCI.Invoice.rdlc";
            this.rv_Invoice.Location = new System.Drawing.Point(0, 0);
            this.rv_Invoice.Name = "rv_Invoice";
            this.rv_Invoice.Size = new System.Drawing.Size(900, 780);
            this.rv_Invoice.TabIndex = 0;
            // 
            // InvoiceContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Name = "InvoiceContainer";
            this.Text = "InvoiceContainer";
            this.Load += new System.EventHandler(this.InvoiceContainer_Load);
            this.BaseContentPanel.ResumeLayout(false);
            this.BaseNavigation.ResumeLayout(false);
            this.BaseContentWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_Invoice;
    }
}