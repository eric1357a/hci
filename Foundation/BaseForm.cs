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
using Transitions;

namespace HCI.Foundation
{
    public partial class BaseForm : Form
    {
        // Making rootForm accessible as a warehouse of form data
        public static RootForm root;

        public BaseForm Prev
        {
            get { return _prev; }
            set
            {
                _prev = value;
                Initialize();
            }
        }

        private BaseForm _prev;
        private DropShadow Shadow;

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

        public BaseForm()
        {
            InitializeComponent();
            this.Activated += FormActivated;
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
            // this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        // window control

        delegate void CloseProgramCallback();

        private void CloseProgram()
        {
            if (Program.Root.InvokeRequired)
            {
                CloseProgramCallback d = new CloseProgramCallback(CloseProgram);
                this.Invoke(d, new object[] {});
            }
            else Program.Root.Close();
        }


        private void BaseButtonCloseWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnimateClose((sndr, evnt) =>
            {
                CloseProgram();
            });
        }

        private void BaseButtonHideWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnimateClose((sndr, evnt) =>
            {
                this.WindowState = FormWindowState.Minimized;
            });
        }

        private void FormActivated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            AnimateShow();
        }

        /* @Override */

        public void Show()
        {
            this.CenterToScreen();
            this.Opacity = 0;
            this.Top += 48;
            base.Show();
            AnimateShow();
        }

        /* animation */
        private void AnimateShow()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(100));
            int tempY = this.Location.Y;
            this.CenterToScreen();
            int centerY = this.Location.Y;
            this.Top = tempY;
            t.add(this, "Top", centerY);
            t.add(this, "Opacity", 1.0);
            t.run();
        }

        private void AnimateClose(EventHandler<Transition.Args> handler)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(100));
            t.add(this, "Top", this.Location.Y + 48);
            t.add(this, "Opacity", 0.0);
            t.TransitionCompletedEvent += handler;
            t.run();
        }

        private void Initialize()
        {
            // hide previous form for backing
            if (_prev != null)
                _prev.Hide();

            // update title and add delegate if backable
            string title = (_prev != null ? "‹  " : "") + BaseNavigationText.Text;
            BaseNavigationText.Text = title;
            if (_prev != null)
            {
                BaseNavigationText.Click += (sender, e) =>
                {
                    _prev.Show();
                    this.Close();
                };
            }
        }

    }
}
