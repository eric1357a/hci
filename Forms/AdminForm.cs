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
    public partial class AdminForm : LoggedInForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new AddDetails() { Prev = this }.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            new CourseSelection() { Prev = this }.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new SearchCourse() { Prev = this }.Show();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            new ModifyDetails() { Prev = this }.Show();
        }
    }
}