using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeGenerator.Helper
{
    public class Function
    {
        public static void RemoveItem(TableLayoutPanel tlp, Control control)
        {
            int Position = tlp.GetRow(control);
            if (Position < tlp.RowCount - 1)
            {
                for (int i = Position; i < tlp.RowCount - 1; i++)
                {
                    tlp.SetRow(tlp.GetControlFromPosition(0, i + 1), i);
                }
            }
            tlp.RowCount -= 1;
        }
    }
}
