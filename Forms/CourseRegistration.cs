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
        private const String PHONE_ERR = "Invalid phone number";
        private const String EMAIL_ERR = "Invalid email";
        private const String MONTH_ERR = "No month selected";
        private const String NAME_ERR = "No student name entered";

        private readonly Color DARK_RED = Color.FromArgb(40, 32, 32);
        private readonly Color DARK_PURPLE = Color.FromArgb(34, 36, 39);

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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Prev.Show();
            this.Hide();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (checkEmail(tb_Email) &
                checkMonth(clb_Month) &
                checkContactNo(tb_ContactNo) &
                checkName(tb_Name))
            {
                // If all validation pass
                if (new Random().Next(4) == 0)
                    // Random course collision for student
                    MessageBox.Show("This timeslot has been registered with another course");
                else
                {
                    MessageBox.Show("Registered Successfully!");
                    btn_Cancel_Click(sender, e);
                }
            }
        }

        private void showToolTip(object sender, String message)
        {
            ToolTip hint = new ToolTip();
            hint.OwnerDraw = true;
            hint.Draw += new DrawToolTipEventHandler((snder, evnt) =>
            {
                SizeF tSize = evnt.Graphics.MeasureString(evnt.ToolTipText, evnt.Font);
                Rectangle rect = new Rectangle(
                    0,
                    0,
                    (int)Math.Ceiling(tSize.Width),
                    (int)Math.Ceiling(tSize.Height)
                );

                evnt.DrawBackground();
                evnt.DrawBorder();
                evnt.Graphics.DrawString(
                    evnt.ToolTipText,
                    evnt.Font,
                    new SolidBrush(hint.ForeColor),
                    rect
                );
            });
            hint.BackColor = Color.FromArgb(40, 32, 32);
            hint.ForeColor = Color.LightPink;
            hint.Show(string.Empty, ((Control)sender), 0, 0, 3000);
            hint.Show(" " + message + " ", ((Control)sender));
        }

        private void tb_ContactNo_Leave(object sender, EventArgs e)
        {
            checkContactNo((Control)sender);
        }

        private void clb_Month_Leave(object sender, EventArgs e)
        {
            checkMonth((Control)sender);
        }

        private void tb_Email_Leave(object sender, EventArgs e)
        {
            checkEmail((Control)sender);
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            checkName((Control)sender);
        }

        private bool checkName(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, NAME_ERR);
                sender.BackColor = DARK_RED;
                return false;
            }
            sender.BackColor = DARK_PURPLE;
            return true;
        }

        private bool checkEmail(Control sender)
        {
            if (!sender.Text.Contains("@"))
            {
                // Show tooltip for invalid email type
                showToolTip(sender, EMAIL_ERR);
                sender.BackColor = DARK_RED;
                return false;
            }
            sender.BackColor = DARK_PURPLE;
            return true;
        }

        private bool checkContactNo(Control sender)
        {
            if (sender.Text.Length != 8)
            {
                // Show tooltip for empty phone
                showToolTip(sender, PHONE_ERR);
                sender.BackColor = DARK_RED;
                return false;
            }
            sender.BackColor = DARK_PURPLE;
            return true;
        }

        private bool checkMonth(Control sender)
        {
            if (((CheckedListBox)sender).CheckedItems.Count == 0)
            {
                // Show tooltip for no month selected
                showToolTip(sender, MONTH_ERR);
                sender.BackColor = DARK_RED;
                return false;
            }
            sender.BackColor = DARK_PURPLE;
            return true;
        }
    }
}
