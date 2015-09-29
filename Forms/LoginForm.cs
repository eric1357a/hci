﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HCI.Foundation;

namespace HCI.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm(RootForm root, BaseForm prev)
        {
            InitializeComponent();
            InitializeAttribute(root, prev);
            UpdateNavigation("Login");
        }

        private void LoginButtonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainMenuForm(Root, null).Show();
        }
    }
}
