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
            LoginUsername.Text = "peter";
            Timer alan = new Timer();
            Timer peter = new Timer();
            alan.Tick += (send, e) =>
            {
                LoginUsername.Text = "alan";
            };
            alan.Interval = 2000;
            alan.Start();
            peter.Tick += (send, e) =>
            {
                LoginUsername.Text = "peter";
            };
            peter.Interval = 2000;
            System.Threading.Thread.Sleep(1000);
            peter.Start();
            LoginPassword.Text = "1234";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Member m = MemberCollection.Login(LoginUsername.Text, LoginPassword.Text);
            if (m != null)
            {
                if (m.Staff)
                    //new StaffMenuForm() { Prev = null }.Show();
                    new CourseSelection() { Prev = null }.Show();
                else
                    //new MainMenuForm() { Prev = null }.Show();
                    new CourseSelection() { Prev = null }.Show();
                this.Close();
            }
            else MessageBox.Show("Incorrect username or password");
        }
    }
}
