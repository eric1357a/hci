using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCI.Forms;

namespace HCI.Foundation
{
    public partial class LoggedInForm : BaseForm
    {
        public LoggedInForm()
        {
            InitializeComponent();

            // Initialize lb_User
            if (root != null && root.loggedIn != null)
                lb_User.Text = root.loggedIn.User + " (" + root.loggedIn.Role + ")";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
