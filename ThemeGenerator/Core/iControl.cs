using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeGenerator.Core
{
    internal class iControl : Control
    {
        protected static Graphics g;
        public static Control selectedObject = null;
        protected static bool HighlightControl;

        #region Borders
        protected static void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }
        protected static void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            g.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        public class iButton : Button
        {
            #region Border
            private bool _DrawBorder = false;
            [Description("Draw border around the button control"), Category("Misc Border")]
            public bool Border
            {
                get => _DrawBorder;
                set
                {
                    _DrawBorder = value;
                    Invalidate();
                }
            }

            private Color _BorderColor = Color.Black;
            [Description("Set border color"), Category("Misc Border")]
            public Color Color
            {
                get => _BorderColor;
                set
                {
                    _BorderColor = value;
                    Invalidate();
                }
            }

            private short _BorderSize = 1;
            [Description("Set border bound size"), Category("Misc Border")]
            public short Size
            {
                get => _BorderSize;
                set
                {
                    _BorderSize = value;
                    Invalidate();
                }
            }

            private short _BorderOffset = 1;
            [Description("Set border bound offset"), Category("Misc Border")]
            public short Offset
            {
                get => _BorderOffset;
                set
                {
                    _BorderOffset = value;
                    Invalidate();
                }
            }
            #endregion
            public iButton()
            {

            }

            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                HighlightControl = true;
                Invalidate();
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                HighlightControl = false;
                Invalidate();
            }

            protected override void OnMouseDown(MouseEventArgs mevent)
            {
                base.OnMouseDown(mevent);
                iControl.selectedObject = this;
                Invalidate();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                g = e.Graphics;
                if (selectedObject == this && HighlightControl)
                    g.DrawRectangle(new Pen(Color.Red, 3), new Rectangle(0, 0, Width - 1, Height - 1));
                if (Border)
                {
                    Pen pen = new Pen(Color, Size);
                    iControl.DrawBorders(pen, 0, 0, Width, Height, _BorderOffset);
                }
            }
        }
    }
}
