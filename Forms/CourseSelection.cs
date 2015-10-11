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
    public partial class CourseSelection : LoggedInForm
    {
        private TableLayoutPanel[] courses;
        private GroupBox[] courseCategories;

        private Color orgBorderColor;

        public CourseSelection()
        {
            InitializeComponent();

            // Binding
            courses = new TableLayoutPanel[] 
            {
                TableCourseA1,
                TableCourseA2,
                TableCourseA3,
                TableCourseB1,
                TableCourseB2,
                TableCourseB3,
                TableCourseC1,
                TableCourseC2,
            };

            courseCategories = new GroupBox[]
            {
                GroupCourseAA,
                GroupCourseBB,
                GroupCourseCC,
            };

            orgBorderColor = TableCourseA1.BackColor;

            // Initialize text of tables and groupboxes
            for (int i = 0; i < CourseCollection.Count; i++)
            {
                courseCategories[i].Text = CourseCollection
                    .Programmes
                    .ElementAt(i)
                    .Category;

                for (int j = 0; j < CourseCollection.Programmes.ElementAt(i).Count; j++)
                    courses[i * 3 + j].GetControlFromPosition(1, 0).Text = CourseCollection
                        .Programmes
                        .ElementAt(i)
                        .Courses[j].Name;
            }
        }

        private Control toRootControl(Control control)
        {
            while (control.Parent.Parent.Parent.Parent.Parent.Parent != null)
                control = control.Parent;
            return control;
        }

        private void TableItem_MouseEnter(object sender, EventArgs e)
        {
            toRootControl((Control)sender).BackColor = Color.FromArgb(
                orgBorderColor.R - 15,
                orgBorderColor.G - 15,
                orgBorderColor.B - 15
            );
        }

        private void TableItem_MouseLeave(object sender, EventArgs e)
        {
            toRootControl((Control)sender).BackColor = orgBorderColor;
        }

        private void TableItem_MouseClick(object sender, MouseEventArgs e)
        {
            TableLayoutPanel tlp = (TableLayoutPanel)toRootControl((Control)sender);
            Control label = tlp.GetControlFromPosition(1, 0);
            string key = label.Name.Replace("Label", "");
            string[] array = label.Text.Split('\n');

            string course = array[0];
            new CourseDetail(key) { Prev = this }.Show();
        }
    }
}
