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
//TODO List: Logout function
{
    public partial class MainMenuForm : LoggedInForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btn_viewcourse_Click(object sender, EventArgs e)
        {
            new CourseSelection() { Prev = this}.Show();
        }


        private void btn_coursesearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Wait for K
        }
    }
}
