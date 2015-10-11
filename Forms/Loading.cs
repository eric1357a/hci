using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HCI.Forms
{
    public partial class Loading : Form
    {
        // http://stackoverflow.com/questions/10674228
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Loading()
        {
            InitializeComponent();

            Timer animation = new Timer();
            animation.Interval = 60;
            animation.Tick += (sender, e) =>
            {
                if (lb_Loading.Text.Length > 0)
                    switch (lb_Loading.Text[lb_Loading.Text.Length - 1])
                    {
                        case '/':
                            changeLastChar(lb_Loading, '—');
                            break;
                        case '—':
                            changeLastChar(lb_Loading, '\\');
                            break;
                        case '\\':
                            changeLastChar(lb_Loading, '|');
                            break;
                        case '|':
                            changeLastChar(lb_Loading, '/');
                            break;
                    }
            };
            animation.Start();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 16));
        }

        private void changeLastChar(Control control, char c)
        {
            control.Text = control.Text.Substring(0, control.Text.Length - 1) + c;
        }
    }
}
