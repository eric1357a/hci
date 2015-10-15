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
using Transitions;

namespace HCI.Forms
{
    public partial class SearchCourse : LoggedInForm
    {
        private bool Animated = false;
        public SearchCourse()
        {
            InitializeComponent();
            // set default to first item
            cb_searchWhat.SelectedIndex = 0;
            bool handleEnter = false;
            tb_searchText.KeyDown += (sender, e) =>
            {
                if (e.KeyValue == 13) handleEnter = true;
                else handleEnter = false;
            };
            tb_searchText.KeyPress += (sender, e) =>
            {
                if (handleEnter || !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            };
            tb_searchText.KeyUp += (sender, e) =>
            {
                /* Animation part */
                if (tb_searchText.Text.Length < 1 || Animated) return;
                lb_searchDesc.Parent.Controls.Remove(lb_searchDesc);

                Transition t = new Transition(new TransitionType_EaseInEaseOut(250));
                int oldWidth = panel_searchBox.Width;
                t.add(panel_searchBox, "Left", 0);
                t.add(panel_searchBox, "Top", 0);
                t.add(panel_searchBox, "Width", this.Width);
                t.add(tb_searchText, "Width", tb_searchText.Width + this.Width - oldWidth);
                t.add(lb_searchResult, "Top", panel_searchBox.Height);
                t.add(lb_searchResult, "Height", BaseContentWrapper.Height - panel_searchBox.Height);
                t.run();
                Animated = true;
            };
        }

        private void tb_searchText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int value = Int32.Parse(tb_searchText.Text);
                lb_searchResult.Items.Clear();
                string what = cb_searchWhat.Items[cb_searchWhat.SelectedIndex].ToString();
                bool searchPrice = what[0] == 'P';
                object[] data = CourseCollection.Search(searchPrice, value);
                lb_searchResult.Items.AddRange(data);
            }
            catch (Exception ex) { }
        }

        private void lb_searchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lb_searchResult.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Course c = (Course)((ListItem)lb_searchResult.Items[index]).Value;
                new CourseDetail(CourseCollection.GetKeyByName(c.Name)) { Prev = this }.Show();
            }
        }

    }
}