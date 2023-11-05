using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveClipboardScreenshot.Classes
{
    internal class SaveScreenshot
    {
        internal static void Save(string prefix)
        {
            if (!ClipboardContainsImage())
                return;

            string folderPath = Configuration.GetDirectory();
            string suffix = Configuration.GetSuffix();
            if (string.IsNullOrEmpty(prefix))
                prefix = "Screenshot";

            string saveLocation = Path.Combine(folderPath, prefix);
            if (!Directory.Exists(saveLocation))
                Directory.CreateDirectory(saveLocation);

            string fileName = GetFileName(saveLocation, prefix, suffix);

            saveLocation = Path.Combine(saveLocation, fileName);
            PerformSave(saveLocation);
        }


        private static string GetFileName(string saveLocation, string prefix, string suffix)
        {
            throw new NotImplementedException();
        }

        private static void PerformSave(string saveLocation)
        {
            throw new NotImplementedException();
        }

        private static bool ClipboardContainsImage() =>
            Clipboard.ContainsImage();
    }
}
