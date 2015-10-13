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
            // Update discount of invoice with extra 5%(default) from credit card payment
            if (invoice.discount != 0)
                invoice.discount = (int)(100 - (100 - invoice.discount) * extra);
            else if (extra != 1)
                invoice.discount = Discounts.getCCDiscount();

            // Update payment to fit with total price
            // Making change to zero
            invoice.payment = invoice.subTotal * (100 - invoice.discount) / 100 + invoice.lessonMaterial;

            // Update number of seat left for registered course
            CourseCollection.FindProgramme(invoice.key).Find(invoice.key).Seats--;

            // Student course actual registration
            bool[] monthTable =
            {
                invoice.months.Contains("Jun"),
                invoice.months.Contains("Jul"),
                invoice.months.Contains("Aug")
            };
            Membership m = StudentCollection.ToMembership(invoice.membership);
            StudentCollection.ElementAt(invoice.studentName, m).register(invoice.weekDay, monthTable);

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
