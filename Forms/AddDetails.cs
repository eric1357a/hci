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
    public partial class AddDetails : LoggedInForm
    {
        private const String Cost_ERR = "No cost entered";
        private const String Day_ERR = "No day entered";
        private const String Desc_ERR = "No description entered";
        private const String Course_ERR = "No course name entered";

        private readonly Color INCORRECT = Color.FromArgb(224, 224, 224);
        private readonly Color CORRECT = Color.FromArgb(243, 244, 248);

        public AddDetails()
        {
            InitializeComponent();
        }

        private void tb_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || ((Control)sender).Text.Length == 8)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 9)
                    e.Handled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            new AdminForm() { Prev = this }.Show();
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            new AddMemberDetails() { Prev = this }.Show();
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

        private void tb_Course_Leave(object sender, EventArgs e)
        {
            checkCourse((Control)sender);
        }

        private void tb_Desc_Leave(object sender, EventArgs e)
        {
            checkDesc((Control)sender);
        }

        private void tb_Cost_Leave(object sender, EventArgs e)
        {
            checkCost((Control)sender);
        }

        private void tb_Day_Leave(object sender, EventArgs e)
        {
            checkDay((Control)sender);
        }

        private bool checkCourse(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, Course_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkDesc(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, Desc_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkCost(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, Cost_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkDay(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, Desc_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (checkCourse(tb_Course) &
                checkDesc(tb_Desc) &
                checkDay(tb_Day) &
                checkCost(tb_Cost))
            {
                string StrCost = tb_Cost.Text;
                int Cost = int.Parse(StrCost);
                new Course(tb_Course.Text,
                    tb_Desc.Text,
                    tb_Day.Text,
                    Cost);
                MessageBox.Show("Registered Successfully!");
                new AddDetails() { Prev = this }.Show();
            } 
        }
    }
}