using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    class ListItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public ListItem(string text, object value)
        {
            Text = text;
            Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
