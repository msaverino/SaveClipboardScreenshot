using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveClipboardScreenshot.Classes
{
    internal class Settings
    {
        private static readonly string[] Options = { "Increment", "Date", "Date and Time", "Random", "Custom" };

        internal static void InitialLoad(TextBox directory, ComboBox suffix, CheckBox subFolder)
        {
            Logging.ChangeStatusText("Reading configuration file...");
            LoadDirectoryTextBox(directory);
            LoadSuffixDropDown(suffix);
            LoadSubFolderCheckBox(subFolder);
            Logging.ChangeStatusText("Ready");
        }

        private static void LoadSubFolderCheckBox(CheckBox subFolder) =>
            subFolder.Checked = Configuration.CreateChildFolder();

        private static void LoadDirectoryTextBox(TextBox directory)
        {
            directory.Text = Configuration.GetDirectory();
        }

        private static void LoadSuffixDropDown(ComboBox suffix)
        {
            suffix.Items.Clear();
            suffix.Items.AddRange(Options);
            string suffixText = Configuration.GetSuffix();
            if (Options.Contains(suffixText))
            {
                suffix.SelectedItem = suffixText;
            }
            else
            {
                suffix.Text = Options[0];
            }
        }

        internal static void SelectDirectory(TextBox directory)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Configuration.GetDirectory();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                Configuration.SetDirectory(selectedPath);
                directory.Text = selectedPath;
            }
        }
    }
}
