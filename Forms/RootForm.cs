using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI.Forms
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
            LoginForm form = new LoginForm(this, null);
            form.Show();
        }
    }
}
