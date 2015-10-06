using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCI.Foundation;

namespace HCI.Forms
{
    public partial class CourseRegistration : BaseForm
    {
        public CourseRegistration(String course, String weekDay)
        {
            InitializeComponent();

            lb_Course.Text = course;
            lb_WeekDay.Text = weekDay;
        }

        private void tb_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || ((Control) sender).Text.Length == 8)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 9)
                        e.Handled = true;
        }

        private void tb_Email_Leave(object sender, EventArgs e)
        {
            if (!((Control)sender).Text.Contains("@"))
                // Show tooltip for invalid email type
                showToolTip(sender, "Invalid email!");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Prev.Show();
            this.Hide();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            String errMsg = "";

            if (tb_ContactNo.Text.Length != 8)
                errMsg = "Please input a valid phone number";

            if (tb_Email.Text.Length == 0 || !tb_Email.Text.Contains("@"))
                errMsg = "Please input a valid email";

            if (clb_Month.SelectedItems.Count == 0)
                errMsg = "Please select at least a month";

            if (errMsg.Length != 0)
                MessageBox.Show(errMsg);
            else if (new Random().Next(4) == 0)
                // Random course collision for student
                MessageBox.Show("This timeslot has been registered with another course");
            else
            {
                MessageBox.Show("Registered Successfully!");
                btn_Cancel_Click(sender, e);
            }
        }

        private void showToolTip(object sender, String message)
        {
            ToolTip hint = new ToolTip();
            hint.OwnerDraw = true;
            hint.Draw += new DrawToolTipEventHandler((snder, evnt) =>
            {
                evnt.DrawBackground();
                evnt.DrawBorder();
                evnt.Graphics.DrawString(
                    evnt.ToolTipText,
                    new Font(evnt.Font.FontFamily, 12f),
                    new SolidBrush(hint.ForeColor),
                    new PointF()
                );
            });
            hint.BackColor = BackColor;
            hint.ForeColor = lb_852.ForeColor;
            hint.Show(string.Empty, ((Control)sender), 0, 0, 3000);
            hint.Show(" " + message + " ", ((Control)sender));
        }

        private void tb_ContactNo_Leave(object sender, EventArgs e)
        {
            if (((Control) sender).Text.Length != 8)
                // Show tooltip for empty phone
                showToolTip(sender, "Invalid phone number!");
        }
    }
}
