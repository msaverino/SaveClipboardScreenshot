using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveClipboardScreenshot.Classes
{
    internal class Documentation
    {
        private const string _configurationUrlDev = "https://github.com/msaverino/SaveClipboardScreenshot/blob/development/SaveClipboardScreenshot/docs/Configuration.md";
        private const string _configurationUrl = "https://github.com/msaverino/SaveClipboardScreenshot/blob/main/SaveClipboardScreenshot/docs/Configuration.md";

        internal static void OpenConfigurationPage()
        {
            if (IsRelease())
                System.Diagnostics.Process.Start(_configurationUrl);
            else
                System.Diagnostics.Process.Start(_configurationUrlDev);
        }

        internal static bool IsRelease()
        {
            #if DEBUG
                return false;
            #else
                return true;
            #endif
        }
    }
}
