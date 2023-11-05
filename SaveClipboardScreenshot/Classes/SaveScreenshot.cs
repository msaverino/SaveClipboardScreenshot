using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveClipboardScreenshot.Classes
{
    internal class SaveScreenshot
    {
        internal static void Save(string prefix, bool subFolder)
        {
            if (!ClipboardContainsImage())
                return;

            string folderPath = Configuration.GetDirectory();
            string suffix = Configuration.GetSuffix();
            if (string.IsNullOrEmpty(prefix))
                prefix = "Screenshot";

            string saveLocation;

            if (subFolder)
                saveLocation = Path.Combine(folderPath, prefix);
            else 
                saveLocation = folderPath;
            
            
            if (!Directory.Exists(saveLocation))
                Directory.CreateDirectory(saveLocation);

            string fileName = GetFileName(saveLocation, prefix, suffix);

            saveLocation = Path.Combine(saveLocation, $"{fileName}.png");

            PerformSave(saveLocation);
        }


        private static string GetFileName(string saveLocation, string prefix, string suffix)
        {
            switch (suffix)
            {
                case "Increment":
                    return GetIncrementedSuffix(prefix, saveLocation);
                case "Date and Time":
                    return GetDateAndTimeSuffix(prefix);
                case "Time":
                    return GetTimeSuffix(prefix);
                case "Date":
                    return GetDateSuffix(prefix);
                case "Random":
                    return GetRandomSuffix(prefix);
                case "Custom":
                    return GetCustomSuffix(prefix);
                default:
                    return GetIncrementedSuffix(prefix, saveLocation);
            }
        }

        private static string GetDateSuffix(string prefix) =>
            $"{prefix} {DateTime.Now.ToString("yyyy-MM-dd")}";

        private static string GetCustomSuffix(string prefix)
        {
            string customSuffix = string.Empty;
            customSuffix = Interaction.InputBox("Enter a custom suffix for the file name.", "Custom Suffix", string.Empty);
            return $"{prefix}_{customSuffix}";
        }

        private static string GetRandomSuffix(string prefix) =>
            $"{prefix} {Guid.NewGuid().ToString().Substring(0, 8)}";

        private static string GetTimeSuffix(string prefix) =>
            $"{prefix} {DateTime.Now.ToString("HH-mm-ss")}";

        private static string GetDateAndTimeSuffix(string prefix) =>
            $"{prefix} {DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}";

        private static string GetIncrementedSuffix(string prefix, string saveLocation)
        {
            // Check the save folder for the prefix and increment the number if it already exists.
            string[] files = System.IO.Directory.GetFiles(saveLocation, $"{prefix}*");
            if (files.Length > 0)
            {
                // We have files with the prefix, so we need to increment the number.
                int highestNumber = 0;
                foreach (string file in files)
                {
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(file);
                    string[] splitFileName = fileName.Split('_');
                    // Try to parse the number from the file name. if it fails, we will just ignore it as it's not a file we created.
                    int number = 0;
                    try
                    {
                        number = int.Parse(splitFileName[1]);
                    }
                    catch
                    {

                    }
                    if (number > highestNumber)
                    {
                        highestNumber = number;
                    }
                }
                return $"{prefix}_{highestNumber + 1}";
            }
            else
            {
                // We don't have any files with the prefix, so we can just return the prefix.
                return $"{prefix}_1";
            }
        }

        private static void PerformSave(string saveLocation)
        {
            using (Image image = Clipboard.GetImage())
            {
                image.Save(saveLocation, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private static bool ClipboardContainsImage() =>
            Clipboard.ContainsImage();
    }
}
