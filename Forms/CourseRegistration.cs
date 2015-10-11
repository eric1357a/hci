﻿using System;
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
    public partial class CourseRegistration : LoggedInForm
    {
        private const String PHONE_ERR = "Invalid phone number";
        private const String EMAIL_ERR = "Invalid email";
        private const String MONTH_ERR = "No month selected";
        private const String NAME_ERR = "No student name entered";

        private readonly Color DARK_RED = Color.FromArgb(224, 224, 224);
        private readonly Color DARK_PURPLE = Color.FromArgb(243, 244, 248);

        private Course course;
        private Programme programme;

        public CourseRegistration(String key, String weekDay)
        {
            programme = CourseCollection.FindProgramme(key);
            course = CourseCollection.FindProgramme(key).Find(key);

            InitializeComponent();

            lb_Course.Text = "(" + programme.Category + ")" + " " + course.Name;
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
                    this.Hide();

                    String membership = "N/A";
                    if (clb_Member.CheckedItems.Count != 0)
                        membership = clb_Member.CheckedItems[0].ToString();

                    int discount = 0;
                    switch (membership)
                    {
                        case "Normal":
                            discount = Discounts.getDiscount();
                            break;
                        case "Gold":
                            discount = Discounts.getGoldDiscount();
                            break;
                    }

                    new InvoiceContainer(
                        // Parameter passing to rdlc via Invoice object
                        new Invoice()
                        {
                            staffName = root.loggedIn.User,

                            studentName = tb_Name.Text,
                            contactNo = tb_ContactNo.Text,
                            email = tb_Email.Text,
                            membership = membership,

                            category = programme.Category,
                            course = course.Name,
                            weekDay = lb_WeekDay.Text,
                            months = getCheckedMonths(),
                            subTotal = course.Cost,

                            discount = discount,
                            lessonMaterial = programme.materialFee,
                            payment = 1000
                        }
                    ) { Prev = this.Prev.Prev }.Show();
                }
            }
        }

        private String getCheckedMonths()
        {
            String retn = "";
            for (int i = 0; i < clb_Month.CheckedItems.Count; i++)
                retn += clb_Month.CheckedItems[i].ToString().Substring(0, 3) + ",";
            return retn.Substring(0, retn.Length - 1);
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
            hint.BackColor = Color.FromArgb(255, 255, 255);
            hint.ForeColor = Color.FromArgb(8, 127, 183);
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

        private void clb_Member_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // One tick only
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
                    if (e.Index != i)
                        ((CheckedListBox)sender).SetItemChecked(i, false);
        }
    }
}
