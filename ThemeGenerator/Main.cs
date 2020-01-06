using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeGenerator.Core;
using ThemeGenerator.Helper;

namespace ThemeGenerator
{
    public partial class Main : Form
    {
        iControl iC = new iControl();
        public Main()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            iControl.iButton iButton = new iControl.iButton();
            flp.Controls.Add(iButton);
            iButton.Click += objProperties;
        }

        private void objProperties(object sender, EventArgs e)
        {
            ppg.SelectedObject = sender;
        }

        private void ClearObj()
        {
            ppg.SelectedObject = null;
        }

        private void btnRemoveObject_Click(object sender, EventArgs e)
        {
            if (iControl.selectedObject is null) return;
            if (flp.Controls.Count == 1 && iControl.selectedObject != null)
            {
                btnClearObject.PerformClick();
                return;
            }
            Control item = iControl.selectedObject.Parent;
            iControl.selectedObject.Dispose();
            if (item?.Controls.Count == 0)
            {
                Function.RemoveItem(tlp, item);
                item.Dispose();
            }
            ClearObj();
        }

        private void btnClearObject_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            ClearObj();
        }
    }
}
