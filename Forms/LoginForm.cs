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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();

            LoginUsername.Text = "Ada";
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => 
            {
                switch (LoginUsername.Text)
                {
                    case "Ada":
                        LoginUsername.Text = "Peter";
                        break;
                    case "Peter":
                        LoginUsername.Text = "Alan";
                        break;
                    case "Alan":
                        LoginUsername.Text = "Ada";
                        break;
                }
            };
            timer.Start();
            LoginPassword.Text = "1234";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Staff m = StaffCollection.Login(LoginUsername.Text, LoginPassword.Text);
            if (m != null)
            {                
                root.loggedIn = m;

                if (m.Role == JobPosition.Manager)
                    new ManagerMenuForm() { Prev = null }.Show();
                else if (m.Role == JobPosition.Staff)
                    new MainMenuForm() { Prev = null }.Show();
                else
                    new AdminForm() { Prev = null }.Show();

                this.Close();
            }
            else MessageBox.Show("Incorrect username or password");
        }
    }
}
