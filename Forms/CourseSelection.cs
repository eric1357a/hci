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
using HCI.Controls;

namespace HCI.Forms
{
    public partial class CourseSelection : LoggedInForm
    {
        private Color orgBorderColor;

        public CourseSelection()
        {
            InitializeComponent();
            orgBorderColor = BackColor;

            prepareTable(GroupTable, CourseCollection.Count, 1);

            int max = 0;
            for (int i = 0; i < CourseCollection.Count; i++)
                if (CourseCollection.Programmes.ElementAt(i).Count > max)
                    max = CourseCollection.Programmes.ElementAt(i).Count;

            // Initialize text of tables and groupboxes
            for (int i = 0; i < CourseCollection.Count; i++)
            {
                // Initialize groupbox
                NewGroupBox ngb = new NewGroupBox();
                ngb.Font = this.Font;
                ngb.Text = CourseCollection
                    .Programmes
                    .ElementAt(i)
                    .Category;
                GroupTable.Controls.Add(ngb, i, 0);
                ngb.Padding = new Padding(0);
                ngb.LegendBackColor = BackColor;
                ngb.Margin = new Padding(10);
                ngb.Font = new Font(Font.FontFamily, (int)(Font.Size * 1.5));
                ngb.Dock = DockStyle.Fill;

                // Initialize tableLayoutPanel
                TableLayoutPanel tlp = new TableLayoutPanel();
                ngb.Controls.Add(tlp);
                tlp.Dock = DockStyle.Fill;
                tlp.Padding = new Padding(2);
                prepareTable(tlp, 0, max);

                for (int j = 0; j < CourseCollection.Programmes.ElementAt(i).Count; j++)
                {
                    // Initialize inner tableLayoutPanel
                    TableLayoutPanel inner = new TableLayoutPanel();
                    tlp.Controls.Add(inner, 0, j);
                    inner.Dock = DockStyle.Fill;
                    inner.BackColor = Color.Transparent;
                    prepareTable(inner, 2, 1);
                    inner.Margin = new Padding(0);
                    bindEvents(inner);

                    // Initialize panel
                    Panel p = new Panel();
                    p.BackColor = Color.Transparent;
                    p.Dock = DockStyle.Fill;
                    inner.Controls.Add(p, 0, 0);
                    bindEvents(p);

                    // Initialize label
                    Label l = new Label();
                    l.Font = Font;
                    l.BackColor = Color.Transparent;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    inner.Controls.Add(l, 1, 0);
                    l.Dock = DockStyle.Fill;
                    l.Margin = new Padding(3);
                    l.Name = CourseCollection
                        .Programmes
                        .ElementAt(i)
                        .Key[0]
                        .ToString() + (j + 1);
                    l.Text = CourseCollection
                        .Programmes
                        .ElementAt(i)
                        .Courses[j].Name;
                    bindEvents(l);

                    // Initialize pictureBox
                    PictureBox pb = new PictureBox();
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(
                        CourseCollection
                        .Programmes
                        .ElementAt(i)
                        .Key[0]
                        .ToString() + (j + 1),
                        null
                    );
                    pb.BackColor = Color.Transparent;
                    p.Controls.Add(pb);
                    pb.Size = new Size((int)(p.Width / 2), (int)(p.Width / 2));
                    pb.Location = new Point(
                        p.Width / 2 - pb.Width / 2,
                        p.Height / 2 - pb.Height / 2
                    );
                    bindEvents(pb);
                }

                // Add complement
                for (int j = 0; i < max - CourseCollection.Programmes.ElementAt(i).Count; j++)
                {
                    // Initialize inner tableLayoutPanel
                    TableLayoutPanel inner = new TableLayoutPanel();
                    tlp.Controls.Add(inner, 0, j);
                    inner.Dock = DockStyle.Fill;
                    inner.Margin = new Padding(0);
                }
            }
        }

        private void bindEvents(Control c)
        {
            c.MouseEnter += TableItem_MouseEnter;
            c.MouseLeave += TableItem_MouseLeave;
            c.MouseClick += TableItem_MouseClick;
        }

        private void prepareTable(TableLayoutPanel table, int columnCount, int rowCount)
        {
            table.ColumnCount = columnCount;
            table.RowCount = rowCount;
            table.ColumnStyles.Clear();

            // Set column styles to same
            for (int i = 0; i < table.ColumnCount; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Set row styles to same
            for (int i = 0; i < table.RowCount; i++)
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }

        private Control toRootControl(Control control)
        {
            while (control.Parent.Parent.Parent.Parent.Parent.Parent.Parent != null)
                control = control.Parent;
            return control;
        }

        private void TableItem_MouseEnter(object sender, EventArgs e)
        {
            toRootControl((Control)sender).BackColor = Color.FromArgb(
                orgBorderColor.R - 15,
                orgBorderColor.G - 15,
                orgBorderColor.B - 15
            );
        }

        private void TableItem_MouseLeave(object sender, EventArgs e)
        {
            toRootControl((Control)sender).BackColor = orgBorderColor;
        }

        private void TableItem_MouseClick(object sender, MouseEventArgs e)
        {
            TableLayoutPanel tlp = (TableLayoutPanel)toRootControl((Control)sender);
            Control label = tlp.GetControlFromPosition(1, 0);
            string key = label.Name;          
            new CourseDetail(key) { Prev = this }.Show();
        }
    }
}
