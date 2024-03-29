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
    public partial class Maintain : LoggedInForm
    {
        private const String Cost_ERR = "No cost entered";
        private const String Day_ERR = "No day selected";
        private const String Desc_ERR = "No description entered";
        private const String Course_ERR = "No course name entered";
        private const String staff_ERR = "No staff name entered";
        private const String student_ERR = "No student name entered";
        private const String pw_ERR = "No password entered";
        private const String conNo_ERR = "No contact number entered";
        private const String email_ERR = "No email address entered";
        private const String member_ERR = "No member selected";
        private const String position_ERR = "No position selected";
        private const String teachName_ERR = "No teacher name entered";
        private const String tel_ERR = "No tell entered";
        private const String title_ERR = "No title name entered";

        private readonly Color INCORRECT = Color.FromArgb(224, 224, 224);
        private readonly Color CORRECT = Color.FromArgb(243, 244, 248);
       
        private Student Students;
        
        private String  orgCourse = "",orgStud="";
        public Maintain()
        {
            InitializeComponent();
            /*tb_studentName.Text = Students.name;
            orgStud = Students.name;
            tb_ContactNo.Text = Students.contactNo;
            tb_email.Text = Students.email;*/
          
            // add course records
            SetupList(lb_Course, CourseCollection.GetCourses());
            SetupList(lb_Student, StudentCollection.GetStudents());
            SetupList(lb_Staff, StaffCollection.GetStaffs());
            SetupList(lb_Teacher, TeacherCollection.GetTeachers());
        }

        private void SetupList<T>(ListBox lb, LinkedList<T> list)
        {
            object[] obj = new object[list.Count];
            int i = 0;
            foreach (ICommonAttr el in list)
            {
                ListItem item = new ListItem(el.GetName(), el);
                obj[i] = item;
                i++;
            }
            lb.Items.Clear();
            // Add placeholder for unselecting items
            lb.Items.Add("( Press here to ADD Item )");
            lb.Items.AddRange(obj);
            if (list.Count > 0) lb.SelectedIndex = 0;
        }

        private void BindDelete(ListBox lb, LinkedList<string> deletedRef)
        {
            if (lb.Items.Count > 0)
            {
                ListItem obj = (ListItem)lb.Items[lb.SelectedIndex];
                deletedRef.AddLast(obj.Text);
                lb.Items.RemoveAt(lb.SelectedIndex);
                if (lb.Items.Count > 0) lb.SelectedIndex = 0;
            }
        }

        private void btn_Course_Delete_Click(object sender, EventArgs e)
        {
            BindDelete(lb_Course, CourseCollection.Deleted);
        }


        private void btn_Student_Delete_Click(object sender, EventArgs e)
        {
            BindDelete(lb_Student, StudentCollection.Deleted);
        }

        private void btn_Staff_Delete_Click(object sender, EventArgs e)
        {
            BindDelete(lb_Staff, StaffCollection.Deleted);
        }

        private void btn_Teacher_Delete_Click(object sender, EventArgs e)
        {
            //BindDelete(lb_Teacher, TeacherCollection.Deleted);
        }

        private void tb_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || ((Control)sender).Text.Length == 8)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 9)
                    e.Handled = true;
        }

        private void tb_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || ((Control)sender).Text.Length == 8)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 9)
                    e.Handled = true;
        }

        private void tb_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || ((Control)sender).Text.Length == 8)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 9)
                    e.Handled = true;
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

        private void tb_Desc_TextChanged(object sender, EventArgs e)
        {
            tb_Desc.ScrollBars = ScrollBars.Both;
        }

        private void clb_Position_Leave(object sender, EventArgs e)
        {
            checkPosition((Control)sender);
        }

        private void tb_teachername_Leave(object sender, EventArgs e)
        {
            checkTeacherName((Control)sender);
        }

        private void clb_Title_Leave(object sender, EventArgs e)
        {
            checkTitle((Control)sender);
        }

        private void tb_Tel_Leave(object sender, EventArgs e)
        {
            checkTel((Control)sender);
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

        private bool checkTeacherName(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, teachName_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkTel(Control sender)
        {
            if (sender.Text.Length == 0)
            {
                // Show tooltip for invalid email type
                showToolTip(sender, tel_ERR);
                sender.BackColor = INCORRECT;
                return false;
            }
            sender.BackColor = CORRECT;
            return true;
        }

        private bool checkTitle(Control sender)
        {
            if (((CheckedListBox)sender).CheckedItems.Count == 0)
            {
                // Show tooltip for no month selected
                showToolTip(sender, title_ERR);
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
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
                    if (e.Index != i)
                        ((CheckedListBox)sender).SetItemChecked(i, false);
        }

        private void clb_Title_ItemCheck(object sender, ItemCheckEventArgs e)
        {
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

        private void clb_Position_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
                    if (e.Index != i)
                        ((CheckedListBox)sender).SetItemChecked(i, false);
        }

        private void lb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Course.SelectedIndex > 0)
            {
                btn_add.Text = "Change";
            }
            else
            {
                resetAllControls(panel_Course);
                btn_add.Text = "Add";
            }
        }

        private void resetAllControls(Panel p)
        {
            foreach (Control c in p.Controls)
                if (c.GetType().IsSubclassOf(typeof(ListBox)))
                    ((ListBox)c).ClearSelected();
                else if (c.GetType().IsSubclassOf(typeof(ListControl)))
                    ((ListControl)c).SelectedIndex = -1;
                else if (c.GetType().IsSubclassOf(typeof(TextBoxBase)))
                    c.Text = "";
        }

        private void lb_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Student.SelectedIndex > 0)
            {
                btn_add2.Text = "Change";
            }
            else
            {
                resetAllControls(panel_Student);
                btn_add2.Text = "Add";
            }
        }

        private void lb_Staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Staff.SelectedIndex > 0)
            {
                btn_add3.Text = "Change";
            }
            else
            {
                resetAllControls(panel_Staff);
                btn_add3.Text = "Add";
            }
        }

        private void lb_Teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Teacher.SelectedIndex > 0)
            {
                btn_add3.Text = "Change";
            }
            else
            {
                resetAllControls(panel_Teacher);
                btn_add3.Text = "Add";
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkCourse(tb_Course) &
                checkDesc(tb_Desc) &
                checkCost(tb_Cost))
            {
                if (btn_add.Text == "Add")
                {
                    int Cost = int.Parse(tb_Cost.Text);
                    Course c = new Course(tb_Course.Text,
                        tb_Desc.Text,
                        cb_Day.Text,
                        Cost);
                    CourseCollection.Add(tb_CourseNo.Text, c);
                    MessageBox.Show("Registered Successfully!");
                    new AdminForm() { Prev = this }.Show();
                }
                else if (btn_add.Text == "Change")
                {
                    
                    MessageBox.Show("Changed!");

                }
            }
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            if (checkStudent(tb_studentName) &
                checkConNo(tb_ContactNo) &
                checkEmail(tb_email))
            {
                if (btn_add.Text == "Add")
                {
                    Membership m = StudentCollection.ToMembership(
                        clb_Member.CheckedItems.Count > 0 ? clb_Member.CheckedItems[0].ToString() : "None");

                    StudentCollection.Add(tb_studentName.Text,
                         tb_ContactNo.Text,
                         tb_email.Text,
                         m);
                    MessageBox.Show("Registered Successfully!");
                    new AdminForm() { Prev = this }.Show();
                }
            }
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            if (checkStaff(tb_staffName) &
                       checkPw(tb_Pw) &
                       checkPosition(clb_Position))
            {
                JobPosition m = StaffCollection.ToJobPosition(
                     clb_Position.CheckedItems.Count > 0 ? clb_Position.CheckedItems[0].ToString() : "None");
                Staff s = new Staff(tb_staffName.Text,
                    tb_Pw.Text,
                    m);
                StaffCollection.Add(s);
                MessageBox.Show("Registered Successfully!");
                new AdminForm() { Prev = this }.Show();
            }
        }

        private void btn_add4_Click(object sender, EventArgs e)
        {
            if (checkTeacherName(tb_TeacherName) &
                       checkTel(tb_Tel) &
                       checkTitle(clb_Title))
            {
                Teacher t = new Teacher(tb_TeacherName.Text,
                    tb_Tel.Text,
                    clb_Title.Text);
                TeacherCollection.Add(t);
                MessageBox.Show("Registered Successfully!");
                new AdminForm() { Prev = this }.Show();
            }
        }

    }
}

