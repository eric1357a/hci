using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

using HCI.Foundation;
using HCI.Model;
using Transitions;
using System.Reflection;

namespace HCI.Forms
{
    public partial class SearchCourse : LoggedInForm
    {
        private bool Animated = false;
        private Color normalColor, hintColor;
        private const string HINT_PRICE = "[Example: 100]",
            HINT_PRICE_RANGE = "[Example: 100 - 200]",
            HINT_PLACES = "[Example: 10]",
            HINT_PLACES_MONTH = "[Example: 10, Tuesday]";

        public SearchCourse()
        {
            InitializeComponent();
            // Initalize colors
            normalColor = tb_searchText.ForeColor;
            hintColor = Color.FromArgb(
                normalColor.R + 150,
                normalColor.G + 150,
                normalColor.B + 150
            );

            // set default to first item
            cb_searchWhat.SelectedIndex = 0;
            tb_searchText.KeyPress += numberOnly;
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
            // Used for setting tb_searchText's placeholder
            cb_searchWhat.SelectedIndexChanged += (sender, e) =>
            {
                lb_searchResult.Items.Clear();
                tb_searchText.Text = "";
                placePlaceholders();
            };
            // Used for dismissing placeholder
            tb_searchText.GotFocus += (sender, e) =>
            {
                // Changing color back to normalColor
                tb_searchText.ForeColor = normalColor;
                // check if placeholders
                switch (tb_searchText.Text)
                {
                    case HINT_PRICE:
                    case HINT_PRICE_RANGE:
                    case HINT_PLACES:
                    case HINT_PLACES_MONTH:
                        // reset tb
                        tb_searchText.Text = "";
                        break;
                }
            };
            // Used for placing placeholder if no text
            tb_searchText.LostFocus += (sender, e) =>
            {
                placePlaceholders();
            };
            // Initialize placeholder
            placePlaceholders();
        }

        // Clear all keyPress event
        private void RemoveClickEvent(Control c)
        {
            FieldInfo f1 = typeof(Control).GetField("EventKeyPress",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(c);
            PropertyInfo pi = c.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(c, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void numberOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                || e.KeyChar == 13)

                e.Handled = true;
        }

        private void numberAndCommaAndLetter(Object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || char.IsDigit(e.KeyChar)
                || char.IsControl(e.KeyChar) && e.KeyChar != 13
                || e.KeyChar == ','))

                e.Handled = true;
        }

        private void numberAndMinus(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-'
                || e.KeyChar == 13)

                e.Handled = true;
        }

        private void placePlaceholders()
        {
            if (tb_searchText.Text.Length == 0)
            {
                // Fading color
                tb_searchText.ForeColor = hintColor;

                // Remove all events
                RemoveClickEvent(tb_searchText);

                // Set tb_searchText placeholder
                switch (cb_searchWhat.SelectedIndex)
                {
                    case 0:
                        tb_searchText.Text = HINT_PRICE;
                        tb_searchText.KeyPress += numberOnly;
                        break;
                    case 1:
                        tb_searchText.Text = HINT_PRICE_RANGE;
                        tb_searchText.KeyPress += numberAndMinus;
                        break;
                    case 2:
                        tb_searchText.Text = HINT_PLACES;
                        tb_searchText.KeyPress += numberOnly;
                        break;
                    case 3:
                        tb_searchText.Text = HINT_PLACES_MONTH;
                        tb_searchText.KeyPress += numberAndCommaAndLetter;
                        break;
                }
            }
        }

        private void tb_searchText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lb_searchResult.Items.Clear();
                SearchCriteria sc;
                object[] args;
                switch (cb_searchWhat.SelectedIndex)
                {
                    case 0:
                        sc = SearchCriteria.Price;
                        args = new object[] { Int32.Parse(tb_searchText.Text) };
                        break;
                    case 1:
                        sc = SearchCriteria.PriceRange;
                        args = new object[]
                        {
                            Int32.Parse(tb_searchText.Text.Split('-')[0]),
                            Int32.Parse(tb_searchText.Text.Split('-')[1])
                        };
                        break;
                    case 2:
                        sc = SearchCriteria.AvailablePlaces;
                        args = new object[] { Int32.Parse(tb_searchText.Text) };
                        break;
                    default:
                        sc = SearchCriteria.AvailablePlacesForMonth;
                        args = new object[]
                        {
                            Int32.Parse(tb_searchText.Text.Split(',')[0]),
                            (tb_searchText.Text.Split(',')[1].ToUpper()[0]
                            + tb_searchText.Text.Split(',')[1].ToLower().Substring(1,tb_searchText.Text.Split(',')[1].Length - 1))
                                .Substring(0, 3)
                        };
                        break;
                }

                object[] data = CourseCollection.Search(
                    sc,
                    args.ToArray()
                );
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