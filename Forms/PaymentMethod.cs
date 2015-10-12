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

namespace HCI.Forms
{
    public partial class PaymentMethod : LoggedInForm
    {
        private Invoice invoice;

        public PaymentMethod(Invoice invoice)
        {
            this.invoice = invoice;
            InitializeComponent();
        }

        private void pay(double extra)
        {
            if (invoice.discount != 0)
                invoice.discount = (int)(100 - (100 - invoice.discount) * extra);
            else if (extra != 1)
                invoice.discount = Discounts.getCCDiscount();

            invoice.payment = invoice.subTotal * (100 - invoice.discount) / 100 + invoice.lessonMaterial;

            this.Close();
            new InvoiceContainer(invoice) { Prev = this.Prev.Prev.Prev }.Show();
        }

        private void btn_CreditCard_Click(object sender, EventArgs e)
        {
            pay((double)(100 - Discounts.getCCDiscount()) / 100);
        }

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            pay(1);
        }
    }
}
