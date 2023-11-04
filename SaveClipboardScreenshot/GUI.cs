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

        private void ClipboardToScreenshot_Load(object sender, EventArgs e)
        {
            Configuration.LoadConfiguration();
            Settings.InitialLoad(TextBox_Directory, ComboBox_Suffix, CheckBox_SubFolder);
        }

        private void Button_SelectDirectory_Click(object sender, EventArgs e)
        {
            Settings.SelectDirectory(TextBox_Directory);
        }

        private void TextBox_Directory_TextChanged(object sender, EventArgs e)
        {
            Configuration.SetDirectory(TextBox_Directory.Text);
        }

        private void CheckBox_SubFolder_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.SetCreateSubFolder(CheckBox_SubFolder.Checked);
        }

        private void ComboBox_Suffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.SetSelectedSuffix(ComboBox_Suffix.Text);
        }
    }
}
