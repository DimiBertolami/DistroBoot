using System.Diagnostics;
using WinFormsDistroboot;

internal static class DistrobootHelpers
{

    public static Process CMD_Launcher(string Args = "")
    {
        Process ps = new();
        Global g = new();
        g.ps = ps;
        ps.StartInfo.RedirectStandardInput = true;
        ps.StartInfo.FileName = "cmd.exe";
        ps.StartInfo.CreateNoWindow = false;
        ps.StartInfo.Arguments = "";
        ps.StartInfo.WorkingDirectory = "c:\\iso";
        ps.StartInfo.UseShellExecute = false;
        ps.Start();
        return ps;
    }
}