using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDistroboot
{
    public class Global
    {
        public double st { get; set; }
        public string archive { get; set; }
        public Process ps { get; set; } = GetPs();

        public static Process GetPs()
        {
            Process ps = new Process();
            ps.StartInfo.RedirectStandardInput = true;
            ps.StartInfo.CreateNoWindow = false;
            ps.StartInfo.FileName = "cmd.exe";
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.Arguments = string.Empty;
            ps.Start();
            return ps;
        }

        public int handle { get; set; }
        public string Downloaded { get; set; }

    }
}
