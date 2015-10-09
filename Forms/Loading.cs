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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();

            Timer animation = new Timer();
            animation.Interval = 50;
            animation.Tick += (sender, e) =>
            {
                if (lb_Loading.Text.Length > 0)
                    switch (lb_Loading.Text[lb_Loading.Text.Length - 1])
                    {
                        case '-':
                            changeLastChar(lb_Loading, '\\');
                            break;
                        case '\\':
                            changeLastChar(lb_Loading, '|');
                            break;
                        case '|':
                            changeLastChar(lb_Loading, '/');
                            break;
                        case '/':
                            changeLastChar(lb_Loading, '-');
                            break;
                    }
            };
            animation.Start();
        }

        private void changeLastChar(Control control, char c)
        {
            control.Text = control.Text.Substring(0, control.Text.Length - 1) + c;
        }
    }
}
