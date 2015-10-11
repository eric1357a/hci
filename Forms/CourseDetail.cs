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

            this.key = key;
            course = CourseCollection.FindProgramme(key).Find(key);
            BaseNavigationText.Text = course.Name;
            CourseDetails.Text =
                course.Desc + "\n\nCost: HK$" + course.Cost + " monthly\n" +
                "Day: " + course.Day + " every week";
            CourseImage.Image = (Bitmap) Properties.Resources.ResourceManager.GetObject(key, null);
        }

        private void CourseRegButton_Click(object sender, EventArgs e)
        {
            string weekday = course.Day;
            if (new Random().Next(4) == 0)
                // If course is not available by random
                MessageBox.Show("Course \"" + course.Name + "\" is full right now");
            else
                new CourseRegistration(key, weekday) { Prev = this }.Show();
        }
    }
}
