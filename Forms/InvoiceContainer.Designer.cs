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
            this.SuspendLayout();
            // 
            // BaseNavigationText
            // 
            this.BaseNavigationText.Text = "Invoice";
            // 
            // BaseContentPanel
            // 
            this.BaseContentPanel.Controls.Add(this.rv_Invoice);
            this.BaseContentPanel.Size = new System.Drawing.Size(1189, 643);
            // 
            // rv_Invoice
            // 
            this.rv_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.rv_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Invoice.LocalReport.ReportEmbeddedResource = "HCI.Invoice.rdlc";
            this.rv_Invoice.Location = new System.Drawing.Point(0, 0);
            this.rv_Invoice.Name = "rv_Invoice";
            this.rv_Invoice.Size = new System.Drawing.Size(1189, 643);
            this.rv_Invoice.TabIndex = 0;
            // 
            // InvoiceContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 743);
            this.Name = "InvoiceContainer";
            this.Text = "InvoiceContainer";
            this.Load += new System.EventHandler(this.InvoiceContainer_Load);
            this.BaseContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_Invoice;
    }
}