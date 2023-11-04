using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveClipboardScreenshot.Models
{
    public class ConfigurationModel
    {
        public string Suffix { get; set; }
        public string Folder { get; set; }
        public bool CreateChildFolder { get; set; }
    }
}
