using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading;

using HCI.Foundation;
using HCI.Model;
using Microsoft.Reporting.WinForms;

namespace HCI.Forms
{
    public partial class InvoiceContainer : LoggedInForm
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
            // Pre-enter print layout for ignoring normal layout collpse
            rv_Invoice.SetDisplayMode(DisplayMode.PrintLayout);
            rv_Invoice.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
