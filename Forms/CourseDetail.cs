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
    public partial class CourseDetail : LoggedInForm
    {
        private Course course;
        private String key;

        public CourseDetail(string key)
        {
            InitializeComponent();
            if (root.loggedIn.Role == JobPosition.Admin)
            {
                btn_Change.Show();
            }
            else
            {
                btn_Change.Hide();
            }
            this.key = key;
            course = CourseCollection.FindProgramme(key).Find(key);
            BaseNavigationText.Text = course.Name;
            CourseDetails.Text =
                course.Desc + "\n\nCost: HK$" + course.Cost + " monthly\n" +
                "Day: " + course.Day + " every week\n\n" +
                course.Seats + " seat(s) left";
            CourseImage.Image = (Bitmap) Properties.Resources.ResourceManager.GetObject(key, null);
        }
        private void btn_Change_Click(object sender, EventArgs e)
        {
            new ModifyCourse(key) { Prev = this }.Show();
        }

        private void CourseRegButton_Click(object sender, EventArgs e)
        {
            string weekday = course.Day;
            if (course.Seats == 0)
                // If course is not available
                MessageBox.Show("Course \"" + course.Name + "\" is full right now");
            else
                new CourseRegistration(key, weekday) { Prev = this }.Show();
        }
    }
}
