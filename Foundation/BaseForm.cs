using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using HCI.Forms;

namespace HCI.Foundation
{
    public partial class BaseForm : Form
    {
        public BaseForm Prev { get; set; }
        private DropShadow Shadow;

        public BaseForm()
        {
            InitializeComponent();
            Initialize();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // allow drag window by clicking on BaseWindowActions
        private void BaseWindowActions_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // drag shadow too
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084 /*WM_NCHITTEST*/)
            {
                m.Result = (IntPtr)2;   // HTCLIENT
                return;
            }
            base.WndProc(ref m);
        }

        // setup shadow
        private void BaseForm_Load(object sender, EventArgs e)
        {
            Shadow = new DropShadow(this)
            {
                ShadowBlur = 16,
                ShadowColor = Color.FromArgb(80, 0, 0, 0)
            };
            Shadow.RefreshShadow();
        }

        // window control

        private void BaseButtonCloseWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Root.Close();
        }

        private void BaseButtonHideWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Initialize()
        {
            // hide previous form for backing
            if (Prev != null)
                Prev.Hide();

            // update title and add delegate if backable
            string title = (Prev != null ? "‹  " : "") + BaseNavigationText.Text;
            BaseNavigationText.Text = title;
            if (Prev != null)
            {
                BaseNavigationText.Click += (sender, e) =>
                {
                    Prev.Show();
                    this.Close();
                };
            }
        }

        /* * * * * * * * * * * * *\
         *     public methods    *
        \* * * * * * * * * * * * */
    }
}
