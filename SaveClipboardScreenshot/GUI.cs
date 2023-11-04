using SaveClipboardScreenshot.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveClipboardScreenshot
{
    public partial class ClipboardToScreenshot : Form
    {
        public ClipboardToScreenshot()
        {
            InitializeComponent();
        }

        private void Label_Suffix_DoubleClick(object sender, EventArgs e)
        {
            Documentation.OpenConfigurationPage();
        }
    }
}
