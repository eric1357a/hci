using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI.Controls
{
    public enum Lposition
    {
        Left, Center, Right
    }

    public class NewGroupBox : GroupBox
    {
        // Answer from Vin Jin, 
        // https://social.msdn.microsoft.com/Forums/windows/en-US/60767912-6ea4-4ff6-acb5-44002bd94e82/how-to-change-border-color-of-groupbox-in-cnet

        // Default light medium purple
        private Color _borderColor = Color.FromArgb(8, 127, 183), _legendBackColor = DefaultBackColor;

        // Default legend centering
        private Lposition _legendPosition = Lposition.Center;
        public Lposition LegendPosition
        {
            get { return _legendPosition; }
            set { this._legendPosition = value; }
        }

        public Color BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }

        public Color LegendBackColor
        {
            get { return this._legendBackColor; }
            set { this._legendBackColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Get the text size in groupbox
            SizeF tSize = e.Graphics.MeasureString(this.Text, this.Font);

            Rectangle borderRect = this.ClientRectangle;
            borderRect.Y = (int)(borderRect.Y + (tSize.Height / 2));
            borderRect.Height = (int)(borderRect.Height - (tSize.Height / 2));
            ControlPaint.DrawBorder(e.Graphics, borderRect, this._borderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = this.ClientRectangle;
            switch (_legendPosition)
            {
                case Lposition.Center:
                    textRect.X = (int)Math.Ceiling(textRect.X + this.Width / 2 - tSize.Width / 2);
                    break;
                case Lposition.Right:
                    textRect.X = (int)(this.Width - tSize.Width - 6);
                    break;
                default:
                    textRect.X = (textRect.X + 6);
                    break;
            }
            textRect.Width = (int)Math.Ceiling(tSize.Width);
            textRect.Height = (int)Math.Ceiling(tSize.Height);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.FillRectangle(new SolidBrush(_legendBackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect, stringFormat);
        }
    }
}
