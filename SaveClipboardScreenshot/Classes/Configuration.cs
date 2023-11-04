using SaveClipboardScreenshot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveClipboardScreenshot.Classes
{
    internal class Configuration
    {
        internal static ConfigurationModel Config = new ConfigurationModel();

        internal static void LoadConfiguration()
        {
            string configurationFilePath = ConfigurationFilePath();
            string configurationFileContent = File.ReadAllText(configurationFilePath);
            Config = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigurationModel>(configurationFileContent);
        }

        internal static void SaveConfiguration()
        {
            string configurationFilePath = ConfigurationFilePath();
            string configurationFileContent = Newtonsoft.Json.JsonConvert.SerializeObject(Config, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(configurationFilePath, configurationFileContent);
        }

        internal static void OpenConfigurationFileInNotepad()
        {
            string configurationFilePath = ConfigurationFilePath();
            System.Diagnostics.Process.Start("notepad.exe", configurationFilePath);
        }

        private static string ConfigurationFilePath()
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string configurationFilePath = Path.Combine(executablePath, "Configuration", "Configuration.json");
            return configurationFilePath;
        }
    }
}
