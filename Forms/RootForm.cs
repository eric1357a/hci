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
    public partial class RootForm : Form
    {
        // Shared form data
        public Staff loggedIn;

        public RootForm()
        {
            InitializeComponent();
            BaseForm.root = this;
            new LoginForm().Show();
        }
    }
}
