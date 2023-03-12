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
        public int handle { get; set; }
        public static int Pid { get; internal set; }
        public static Process? Ps { get; set; } = Process.GetProcessById(Global.Pid);
        public static Process GetPS(int Id)
        {
            return Process.GetProcessById(Id);
        }

    }
}
