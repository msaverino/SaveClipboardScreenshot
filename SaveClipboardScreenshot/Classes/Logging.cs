using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveClipboardScreenshot.Classes
{
    internal class Logging
    {
        public static string StatusText { get; private set; }
        public static event EventHandler StatusTextChanged;

        internal static void ChangeStatusText(string text)
        {
            StatusText = text; StatusTextChanged?.Invoke(null, EventArgs.Empty);
        }

    }
}
