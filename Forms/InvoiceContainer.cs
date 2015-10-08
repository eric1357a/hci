using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCI.Foundation;
using HCI.Model;
using Microsoft.Reporting.WinForms;

namespace HCI.Forms
{
    public partial class InvoiceContainer : BaseForm
    {
        public InvoiceContainer(Invoice invoice)
        {
            InitializeComponent();

            rv_Invoice.LocalReport.DataSources.Add(
                new ReportDataSource("InvoiceDataSet", new[] { invoice })
            );
        }

        private void InvoiceContainer_Load(object sender, EventArgs e)
        {
            this.rv_Invoice.RefreshReport();
        }
    }
}
