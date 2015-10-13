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
  
    public partial class AddMemberDetails : LoggedInForm
    {
        private const String staff_ERR = "No staff name entered";
        private const String student_ERR = "No student name entered";
        private const String pw_ERR = "No password entered";
        private const String conNo_ERR = "No contact number entered";
        private const String email_ERR = "No email address entered";
        private const String member_ERR = "No member selected";
        private const String position_ERR = "No position selected";
        private readonly Color INCORRECT = Color.FromArgb(224, 224, 224);
        private readonly Color CORRECT = Color.FromArgb(243, 244, 248);

        public AddMemberDetails()
        {
            InitializeComponent();
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            new AddDetails() { Prev = this }.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            new AdminForm() { Prev = this }.Show();
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

        private void tb_staffName_Leave(object sender, EventArgs e)
        {
            checkStaff((Control)sender);
        }

        private void tb_studentName_Leave(object sender, EventArgs e)
        {
            checkStudent((Control)sender);
        }

        private void tb_Pw_Leave(object sender, EventArgs e)
        {
            checkPw((Control)sender);
        }

        private void tb_conNo_Leave(object sender, EventArgs e)
        {
            checkConNo((Control)sender);
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            checkEmail((Control)sender);
        }

        private void clb_Position_Leave(object sender, EventArgs e)
        {
            checkPosition((Control)sender);
        }

        private void clb_Member_Leave(object sender, EventArgs e)
        {
            checkMember((Control)sender);
        }

        private bool checkStaff(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, staff_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkStudent(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, student_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkPw(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, pw_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkConNo(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, conNo_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkEmail(Control sender)
        {
            if (!sender.Text.Contains("@"))
            {
                // Show tooltip for invalid email type
                showToolTip(sender, email_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
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

        private bool checkPosition(Control sender)
        {
            if (((CheckedListBox)sender).CheckedItems.Count == 0)
            {
                // Show tooltip for no month selected
                showToolTip(sender, position_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkMember(Control sender)
        {
            if (((CheckedListBox)sender).CheckedItems.Count == 0)
            {
                // Show tooltip for no month selected
                showToolTip(sender, member_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private void clb_Position_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // One tick only
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
                    if (e.Index != i)
                        ((CheckedListBox)sender).SetItemChecked(i, false);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (checkStudent(tb_studentName) &
                checkConNo(tb_ContactNo) &
                checkEmail(tb_email) &
                checkMember(clb_Member)){     
                Membership m = StudentCollection.ToMembership(
                    clb_Member.CheckedItems.Count > 0 ? clb_Member.CheckedItems[0].ToString() : "None");
              
               StudentCollection.Add(tb_studentName.Text,
                    tb_ContactNo.Text,
                    tb_email.Text,
                    m);
                MessageBox.Show("Registered Successfully!");
                new AddDetails() { Prev = this }.Show();
               }else if(checkStaff(tb_staffName)&
                       checkPw(tb_Pw)&
                       checkPosition(clb_Position)){
                      /* JobPosition m= StudentCollection.ToMembership(
                    clb_Position.CheckedItems.Count > 0 ? clb_Position.CheckedItems[0].ToString() : "None");
                   new Staff(tb_staffName.Text,
                       tb_Pw.Text,
                       m);*/
                       MessageBox.Show("Registered Successfully!");
                       new AddDetails() { Prev = this }.Show();
            }
        }
            
        }

    }

