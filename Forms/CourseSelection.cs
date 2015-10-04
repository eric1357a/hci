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
    public partial class CourseSelection : BaseForm
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
                    .courses
                    .ElementAt(i)
                    .category;

                for (int j = 0; j < CourseCollection.courses.ElementAt(i).Count; j++)
                    courses[i * 3 + j].GetControlFromPosition(1, 0).Text = CourseCollection
                        .courses
                        .ElementAt(i)
                        .courses[j] + "\n\n" +
                        courses[i * 3 + j].GetControlFromPosition(1, 0).Text;
            }
        }

        private void TableItem_MouseEnter(object sender, EventArgs e)
        {
            ((TableLayoutPanel)
                ((Control)sender).Parent
            ).BackColor = Color.FromArgb(
                orgBorderColor.R + 20,
                orgBorderColor.G + 20,
                orgBorderColor.B + 20
            );          
        }

        private void TableItem_MouseLeave(object sender, EventArgs e)
        {
            ((TableLayoutPanel)
                ((Control)sender).Parent
            ).BackColor = orgBorderColor;
        }

        private void TableItem_MouseClick(object sender, MouseEventArgs e)
        {
            String[] stringArray = (
                (TableLayoutPanel)
                ((Control)sender)
                .Parent
            ).GetControlFromPosition(1, 0)
            .Text.Split('\n');

            String course = stringArray[0];
            String weekday = stringArray[stringArray.Length - 1]
                .Substring(
                    1,
                    stringArray[stringArray.Length - 1].Length - 1
                );

            if (new Random().Next(4) == 0)
                // If course is not available by random
                MessageBox.Show("Course \"" + course + "\" is full right now");
            else
                new CourseRegistration(course, weekday) { Prev = this }.Show();
        }
    }
}
