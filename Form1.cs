//using Microsoft.Windows.PowerShell.Gui.Internal;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.WebRequestMethods;

namespace WinFormsDistroboot
{
    public partial class Distroboot : Form
    {

        IntPtr hWnd = 0;
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        string RamSize { get; set; } = "10G";
        HttpClient client = new HttpClient();
        //WebClient webClient = new();

        public Distroboot()
        {
            InitializeComponent();
            Process ps = new();
            ps.StartInfo.RedirectStandardInput = true;
            ps.StartInfo.CreateNoWindow = false;
            ps.StartInfo.FileName = "cmd.exe";
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.Arguments = string.Empty;
            ps.Start();
            Global.Pid = ps.Id;
            Global.Ps = ps;
            ps.StandardInput.WriteLine("ECHO OFF & color 5e & cls & " + "echo pid: " + ps.Id);
            hWnd = ps.MainWindowHandle;
            ShowWindow((int)hWnd, SW_HIDE);
        }
        private void ShowDetailedInfo(object sender, ItemCheckEventArgs e)
        {
            //MessageBox.Show(e.CurrentValue.ToString());
            //MessageBox.Show(e.Index.ToString() + " " + e.CurrentValue.ToString());
            switch (e.Index.ToString())
            {
                case "0":
                    lblId.Text = "IMAGE ID: 0";
                    lblId.Visible = false;

                    lblIso.Text = @"c:\iso\MX-21.3_ahs_x64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/mx-linux/files/Final/Xfce/MX-21.3_ahs_x64.iso/download";
                    break;
                case "1":
                    lblId.Text = "IMAGE ID: 1";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\EndeavourOS_Cassini_neo_22_12.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://mirror.alpix.eu/endeavouros/iso/EndeavourOS_Cassini_neo_22_12.iso";
                    break;
                case "2":
                    lblId.Text = "IMAGE ID: 2";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\linuxmint-21.1-cinnamon-64bit.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://mirror.crexio.com/linuxmint/isos/stable/21.1/linuxmint-21.1-cinnamon-64bit.iso";
                    break;
                case "3":
                    lblId.Text = "IMAGE ID: 3";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\manjaro-kde-22.0.3-230213-linux61.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://download.manjaro.org/kde/22.0.3/manjaro-kde-22.0.3-230213-linux61.iso";
                    break;
                case "4":
                    lblId.Text = "IMAGE ID: 4";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\manjaro-gnome-22.0.3-230213-linux61.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://download.manjaro.org/gnome/22.0.3/manjaro-gnome-22.0.3-230213-linux61.iso";
                    break;
                case "5":
                    lblId.Text = "IMAGE ID: 5";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\pop-os_22.04_amd64_intel_22.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://iso.pop-os.org/22.04/amd64/intel/22/pop-os_22.04_amd64_intel_22.iso";
                    break;
                case "6":
                    lblId.Text = "IMAGE ID: 6";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\pop-os_22.04_amd64_nvidia_22.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://iso.pop-os.org/22.04/amd64/nvidia/22/pop-os_22.04_amd64_nvidia_22.iso";
                    break;
                case "7":
                    lblId.Text = "IMAGE ID: 7";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Fedora-Workstation-Live-x86_64-37-1.7.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://download.fedoraproject.org/pub/fedora/linux/releases/37/Workstation/x86_64/iso/Fedora-Workstation-Live-x86_64-37-1.7.iso";
                    break;
                case "8":
                    lblId.Text = "IMAGE ID: 8";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ubuntu-22.04.1-desktop-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://releases.ubuntu.com/22.04.1/ubuntu-22.04.1-desktop-amd64.iso";
                    break;
                case "9":
                    lblId.Text = "IMAGE ID: 9";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ubuntustudio-22.04.2-dvd-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://cdimage.ubuntu.com/ubuntustudio/releases/22.04.2/release/ubuntustudio-22.04.2-dvd-amd64.iso";
                    break;
                case "10":
                    lblId.Text = "IMAGE ID: 10";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ubuntu-22.04.1-live-server-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://releases.ubuntu.com/22.04.1/ubuntu-22.04.1-live-server-amd64.iso";
                    break;
                case "11":
                    lblId.Text = "IMAGE ID: 11";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Linux-lite-6.2-64bit.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.halifax.rwth-aachen.de/osdn/storage/g/l/li/linuxlite/6.2/linux-lite-6.2-64bit.iso";
                    break;
                case "12":
                    lblId.Text = "IMAGE ID: 12";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Linux-lite-6.2-64bit.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.halifax.rwth-aachen.de/osdn/storage/g/l/li/linuxlite/6.2/linux-lite-6.2-64bit.iso";
                    break;
                case "13":
                    lblId.Text = "IMAGE ID: 13";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\garuda-dr460nized-linux-zen-221019.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/garuda-linux/files/garuda/dr460nized/221019/garuda-dr460nized-linux-zen-221019.iso";
                    break;
                case "14":
                    lblId.Text = "IMAGE ID: 14";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\elementaryos-7.0-stable.20230129rc.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ams3.dl.elementary.io/download/MTY3Njc4NTg3Nw==/elementaryos-7.0-stable.20230129rc.iso";
                    break;
                case "15":
                    lblId.Text = "IMAGE ID: 15";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\voyagerlive.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/voyagerlive/files/latest/download";
                    break;
                case "16":
                    lblId.Text = "IMAGE ID: 16";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\AV_Linux_MX_Edition-21.3_ahs_x64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://downloads.bandshed.net/AVL-MXE_21.3/AV_Linux_MX_Edition-21.3_ahs_x64.iso";
                    break;
                case "17":
                    lblId.Text = "IMAGE ID: 17";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\haiku-r1beta4-x86_64-anyboot.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "http://mirror.rit.edu/haiku/r1beta4/haiku-r1beta4-x86_64-anyboot.iso";
                    break;
                case "18":
                    lblId.Text = "IMAGE ID: 18";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\dfly-x86_64-6.4.0_REL.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://mirror-master.dragonflybsd.org/iso-images/dfly-x86_64-6.4.0_REL.iso";
                    break;
                case "19":
                    lblId.Text = "IMAGE ID: 19";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\extix-22.12-64bit-deepin-20.8-refracta-2560mb-221218.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/extix/files/latest/download";
                    break;
                case "20":
                    lblId.Text = "IMAGE ID: 20";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\FerenOS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/ferenoslinux/files/Feren-OS-standarddt.iso/download";
                    break;
                case "21":
                    lblId.Text = "IMAGE ID: 21";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Nobara-37-Official-2023-02-05.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://nobara.h3o66.de/iso/Nobara-37-Official-2023-02-05.iso";
                    break;
                case "22":
                    lblId.Text = "IMAGE ID: 22";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Qubes-R4.1.2-rc1-x86_64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.qubes-os.org/iso/Qubes-R4.1.2-rc1-x86_64.iso";
                    break;
                case "23":
                    lblId.Text = "IMAGE ID: 23";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Neptune75-20220814.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://download.neptuneos.com/download/Neptune75-20220814.iso";
                    break;
                case "24":
                    lblId.Text = "IMAGE ID: 24";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\athenaOS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/athena-iso/files/latest/download";
                    break;
                case "25":
                    lblId.Text = "IMAGE ID: 25";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\slax-64bit-11.6.0.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.linux.cz/pub/linux/slax/Slax-11.x/slax-64bit-11.6.0.iso";
                    break;
                case "26":
                    lblId.Text = "IMAGE ID: 26";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Zorin-OS-16.2-Core-64-bit-r1.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.halifax.rwth-aachen.de/zorinos/16/Zorin-OS-16.2-Core-64-bit-r1.iso";
                    break;
                case "27":
                    lblId.Text = "IMAGE ID: 27";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\kali-linux-2022.4-installer-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://cdimage.kali.org/kali-2022.4/kali-linux-2022.4-installer-amd64.iso";
                    break;
                case "28":
                    lblId.Text = "IMAGE ID: 28";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\cld-23-x86_64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://mirror.koddos.net/calculate-linux/release/23/cld-23-x86_64.iso";
                    break;
                case "29":
                    lblId.Text = "IMAGE ID: 29";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\CorePlus-current.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "http://www.tinycorelinux.net/13.x/x86/release/CorePlus-current.iso";
                    break;
                case "30":
                    lblId.Text = "IMAGE ID: 30";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\OracleLinux-R9-U1-x86_64-dvd.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://yum.oracle.com/ISOS/OracleLinux/OL9/u1/x86_64/OracleLinux-R9-U1-x86_64-dvd.iso";
                    break;
                case "31":
                    lblId.Text = "IMAGE ID: 31";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\installOpenBSD72.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.fr.openbsd.org/pub/OpenBSD/7.2/amd64/install72.iso";
                    break;
                case "32":
                    lblId.Text = "IMAGE ID: 32";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\LXLE-Focal-Release.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/lxle/files/Final/OS/Focal-64/LXLE-Focal-Release.iso/download";
                    break;
                case "33":
                    lblId.Text = "IMAGE ID: 33";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\GeckoLinux_STATIC_Cinnamon.x86_64-154.220822.0.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/geckolinux/files/Static/154.220822/GeckoLinux_STATIC_Cinnamon.x86_64-154.220822.0.iso/download";
                    break;
                case "34":
                    lblId.Text = "IMAGE ID: 34";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Peropesis-2.0-live.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://peropesis.org/peropesis/Peropesis-2.0-live.iso";
                    break;
                case "35":
                    lblId.Text = "IMAGE ID: 35";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\MakuluLinux-ShiFt-U-2022-12-29.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/makulu/files/downloads/Shift/MakuluLinux-ShiFt-U-2022-12-29.iso/download";
                    break;
                case "36":
                    lblId.Text = "IMAGE ID: 36";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\kodachi-8.27-64-kernel-6.2.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/linuxkodachi/files/kodachi-8.27-64-kernel-6.2.iso/download";
                    break;
                case "37":
                    lblId.Text = "IMAGE ID: 37";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\bodhi-6.0.0-64-apppack.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/bodhilinux/files/6.0.0/bodhi-6.0.0-64-apppack.iso/download";
                    break;
                case "38":
                    lblId.Text = "IMAGE ID: 38";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\TUXEDO-OS-2-202302271716.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://os.tuxedocomputers.com/TUXEDO-OS-2-202302271716.iso";
                    break;
                case "39":
                    lblId.Text = "IMAGE ID: 39";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\tails-amd64-5.10.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://download.tails.net/tails/stable/tails-amd64-5.10/tails-amd64-5.10.iso";
                    break;
                case "40":
                    lblId.Text = "IMAGE ID: 40";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\slackware64-15.0-install-dvd.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://mirrors.slackware.com/slackware/slackware-iso/slackware64-15.0-iso/slackware64-15.0-install-dvd.iso";
                    break;
                case "41":
                    lblId.Text = "IMAGE ID: 41";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\linuxfx-11.2.22.04.7-win10-theme-cinnamon-wxd-13.0.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/linuxfxdevil/files/linuxfx-11.2.22.04.7-win10-theme-cinnamon-wxd-13.0.iso/download";
                    break;
                case "42":
                    lblId.Text = "IMAGE ID: 42";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\linuxfx-11.2.22.04.7-win11-theme-plasma-wxd-13.0.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/linuxfxdevil/files/linuxfx-11.2.22.04.7-win11-theme-plasma-wxd-13.0.iso/download";
                    break;
                case "43":
                    lblId.Text = "IMAGE ID: 43";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\fossapup64-9.5.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://distro.ibiblio.org/puppylinux/puppy-fossa/fossapup64-9.5.iso";
                    break;
                case "44":
                    lblId.Text = "IMAGE ID: 44";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\arcolinuxb-awesome-v23.03.01-x86_64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.belnet.be/arcolinux/iso/v23.03.01/arcolinuxb-awesome-v23.03.01-x86_64.iso";
                    break;
                case "45":
                    lblId.Text = "IMAGE ID: 45";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\easy-5.0-amd64.img";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://distro.ibiblio.org/easyos/amd64/releases/kirkstone/2023/5.0/easy-5.0-amd64.img";
                    break;
                case "46":
                    lblId.Text = "IMAGE ID: 46";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\nitrux-nx-desktop-d5c7cdff-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/nitruxos/files/Release/ISO/nitrux-nx-desktop-d5c7cdff-amd64.iso/download";
                    break;
                case "47":
                    lblId.Text = "IMAGE ID: 47";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Rocky-9.1-x86_64-dvd.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://download.rockylinux.org/pub/rocky/9/isos/x86_64/Rocky-9.1-x86_64-dvd.iso";
                    break;
                case "48":
                    lblId.Text = "IMAGE ID: 48";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\salix64-xfce-15.0.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/salix/files/15.0/salix64-xfce-15.0.iso/download";
                    break;
                case "49":
                    lblId.Text = "IMAGE ID: 49";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\devuan_beowulf_3.1.1_amd64_desktop.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://files.devuan.org/devuan_beowulf/installer-iso/devuan_beowulf_3.1.1_amd64_desktop.iso";
                    break;
                case "50":
                    lblId.Text = "IMAGE ID: 50";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\livegui-amd64-20230226T163212Z.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://ftp.belnet.be/pub/rsync.gentoo.org/gentoo/releases/amd64/autobuilds/current-livegui-amd64/livegui-amd64-20230226T163212Z.iso";
                    break;
                case "51":
                    lblId.Text = "IMAGE ID: 51";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\pureos-10~devel-gnome-live-20220602_amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://downloads.puri.sm/byzantium/gnome/2022-06-02/pureos-10~devel-gnome-live-20220602_amd64.iso";
                    break;
                case "52":
                    lblId.Text = "IMAGE ID: 52";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ELD-9-x86_64-latest.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://fbi.cdn.euro-linux.com/isos/ELD-9-x86_64-latest.iso";
                    break;
                case "53":
                    lblId.Text = "IMAGE ID: 53";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\primeos.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/primeos/files/latest/download";
                    break;
                case "54":
                    lblId.Text = "IMAGE ID: 54";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\BLISSOS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/blissos-dev/files/latest/download";
                    break;
                case "55":
                    lblId.Text = "IMAGE ID: 55";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ReactOS-0.4.14-release-57-g1e953d8-iso.zip";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/reactos/files/latest/download";
                    break;
                case "56":
                    lblId.Text = "IMAGE ID: 56";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\PEPPERMINT OS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/peppermintos/files/latest/download";
                    break;
                case "57":
                    lblId.Text = "IMAGE ID: 57";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\clear-37980-live-desktop.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://cdn.download.clearlinux.org/releases/37980/clear/clear-37980-live-desktop.iso";
                    break;
                case "58":
                    lblId.Text = "IMAGE ID: 58";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Redcore.Linux.Hardened.2301.Sirius.KDE.amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "http://ro.mirror.redcorelinux.org/amd64/iso/Redcore.Linux.Hardened.2301.Sirius.KDE.amd64.iso";
                    break;
                case "59":
                    lblId.Text = "IMAGE ID: 59";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\locos.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/loc-os/files/Loc-OS%2022/LXDE/Loc-OS-22-LXDE-x86_64.iso/download";
                    break;
                case "60":
                    lblId.Text = "IMAGE ID: 60";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\MABOX.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/mabox-linux/files/latest/download";
                    break;
                case "61":
                    lblId.Text = "IMAGE ID: 61";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\remixOS.zip";
                    lblUrl.Text = "https://sourceforge.net/projects/remix-os/files/Remix_OS_for_PC_Android_M_64bit_B2016112101.zip/download";
                    break;
                case "62":
                    lblId.Text = "IMAGE ID: 62";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\EMMABUNTUS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/emmabuntus/files/latest/download";
                    break;
                case "63":
                    lblId.Text = "IMAGE ID: 63";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\arcolinuxb-xtended-v23.03.01-x86_64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/arcolinux-community-editions/files/xtended/arcolinuxb-xtended-v23.03.01-x86_64.iso/download";
                    break;
                case "64":
                    lblId.Text = "IMAGE ID: 64";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\openmandriva.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/openmandriva/files/latest/download";
                    break;
                case "65":
                    lblId.Text = "IMAGE ID: 65";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\legacyos.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/legacyoslinux/files/latest/download";
                    break;
                case "66":
                    lblId.Text = "IMAGE ID: 66";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Xiaopan%206.4.1.zip";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://netcologne.dl.sourceforge.net/project/xiaopanos/Xiaopan%206.4.1.zip";
                    break;
                case "67":
                    lblId.Text = "IMAGE ID: 67";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\cachyos.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/cachyos-arch/files/latest/download";
                    break;
                case "68":
                    lblId.Text = "IMAGE ID: 68";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\slint64-15.0-2.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://slackware.uk/slint/x86_64/slint-15.0/iso/slint64-15.0-2.iso";
                    break;
                case "69":
                    lblId.Text = "IMAGE ID: 69";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\neurolinux-20.04.2-2021.04.05-April%202021.0-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "http://neurolinux.net/downloads/neurolinux-20.04.2-2021.04.05-April%202021.0-amd64.iso";
                    break;
                case "70":
                    lblId.Text = "IMAGE ID: 70";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\jarro4_0_0.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://jarronegro.mx/jarro4_0_0.iso";
                    break;
                case "71":
                    lblId.Text = "IMAGE ID: 71";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\predator-os-v2.5-LTS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://seilany.ir/predator-os/download/predator-os-v2.5-LTS.iso";
                    break;
                case "72":
                    lblId.Text = "IMAGE ID: 72";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\XOS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/xos-workstation/files/latest/download";
                    break;
                case "73":
                    lblId.Text = "IMAGE ID: 73";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\DRAGONOS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/dragonos-focal/files/latest/download";
                    break;
                case "74":
                    lblId.Text = "IMAGE ID: 74";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\lixix.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://caesar-rylan.60.nu/lirix/iso";
                    break;
                case "75":
                    lblId.Text = "IMAGE ID: 75";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\Circle-8.7-x86_64-dvd1.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://mirror.cclinux.org/pub/circle/8.7/isos/x86_64/Circle-8.7-x86_64-dvd1.iso";
                    break;
                case "76":
                    lblId.Text = "IMAGE ID: 76";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\rolling-2022-09-07.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://archive.org/download/rolling-2022-09-07/rolling-2022-09-07.iso";
                    break;
                case "77":
                    lblId.Text = "IMAGE ID: 77";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\titan.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/titan-linux/files/latest/download";
                    break;
                case "78":
                    lblId.Text = "IMAGE ID: 78";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\crowz.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/crowz/files/latest/download";
                    break;
                case "79":
                    lblId.Text = "IMAGE ID: 79";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\datLinux.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/dat-linux/files/latest/download";
                    break;
                case "80":
                    lblId.Text = "IMAGE ID: 80";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\freedomOS.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/freedomoslinux/files/latest/download";
                    break;
                case "81":
                    lblId.Text = "IMAGE ID: 81";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\metis-base-runit-20220717-v1.1.1-x86_64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://github.com/metis-os/metis-iso/releases/download/v1.1.1/metis-base-runit-20220717-v1.1.1-x86_64.iso";
                    break;
                case "82":
                    lblId.Text = "IMAGE ID: 82";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\gnuinos-4.0.0-chimaera_2023.02.22-ob_amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://www.gnuinos.org/mirror/chimaera/live/gnuinos-4.0.0-chimaera_2023.02.22-ob_amd64.iso";
                    break;
                case "83":
                    lblId.Text = "IMAGE ID: 83";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\gnuinos-5.0.0-daedalus_2022.11.05-xfce_amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://www.gnuinos.org/mirror/daedalus/live/gnuinos-5.0.0-daedalus_2022.11.05-xfce_amd64.iso";
                    break;
                case "84":
                    lblId.Text = "IMAGE ID: 84";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\convectix_darwin.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://myb.convectix.com/DL/nubectl-darwin";
                    break;
                case "85":
                    lblId.Text = "IMAGE ID: 85";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\myb-13.1.2.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://myb.convectix.com/DL/myb-13.1.2.iso";
                    break;
                case "86":
                    lblId.Text = "IMAGE ID: 86";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ShinyOS-V1-desktop-amd64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/shinyos/files/ShinyOS-V1-desktop-amd64.iso/download";
                    break;
                case "87":
                    lblId.Text = "IMAGE ID: 87";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\carbonOS-2022.3-installer.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://repo.carbon.sh/img/carbonOS-2022.3-installer.iso";
                    break;
                case "88":
                    lblId.Text = "IMAGE ID: 88";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\PikaOS-Gnome-2210-amd64_23.02.17.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://pika-os.com/PikaOS-Gnome-2210-amd64_23.02.17.iso";
                    break;
                case "89":
                    lblId.Text = "IMAGE ID: 89";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\PikaOS-KDE-2210-amd64_23.02.18.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://pika-os.com/PikaOS-KDE-2210-amd64_23.02.18.iso";
                    break;
                case "90":
                    lblId.Text = "IMAGE ID: 90";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\blendOS-2023.01.26-x86_64.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://github.com/blend-os/blendOS/releases/download/23.01/blendOS-2023.01.26-x86_64.iso";
                    break;
                case "91":
                    lblId.Text = "IMAGE ID: 91";
                    lblId.Visible = false;
                    lblIso.Text = @"c:\iso\ACCCoco.iso";
                    lblIso.Visible = false;
                    lblUrl.Text = "https://sourceforge.net/projects/accessible-coconut/files/latest/download";
                    break;
                default:
                    break;
            }
            GrpImageDetails.Visible = true;
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            string Downloaded = string.Format("{0}    Downloading: {1} of {2}MB", e.UserState as string, e.BytesReceived / 1024 / 1024, e.TotalBytesToReceive / 1024 / 1024);
            lblSpeed.Visible = true;
            lblSpeed.Text = Downloaded;
            progressBar1.Value = e.ProgressPercentage;
            int percent = (int)(((double)(progressBar1.Value - progressBar1.Minimum) /
                (double)(progressBar1.Maximum - progressBar1.Minimum)) * 100);
            using (Graphics gr = progressBar1.CreateGraphics())
            {
                gr.DrawString(percent.ToString() + "%",
                    SystemFonts.DefaultFont,
                    Brushes.Black,
                    new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                        SystemFonts.DefaultFont).Width / 2.0F),
                    progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                        SystemFonts.DefaultFont).Height / 2.0F)));
            }
        }

        private async void Completed(object sender, AsyncCompletedEventArgs e)
        {
            foreach (var item in Directory.EnumerateFiles("c:\\iso", "*"))
            {
                if (item.ToLower().EndsWith(".zip"))
                {
                    progressBar1.Value = 0;
                    int Index = ImagesLocal.SelectedIndex;
                    Global.Ps.StandardInput.WriteLine("PowerShell -Command \"Expand-Archive -Path " + item + " -DestinationPath C:\\ISO\"");
                    Global.Ps.StandardInput.WriteLine("del " + item);
                }
                if (item.ToUpper().EndsWith(".ISO") || item.ToUpper().EndsWith(".IMG"))
                {
                    ImagesLocal.Items.Add(item);
                }
            }
        }

        private async void DownloadItemAsync(object sender, EventArgs e)
        {
            if (ImagesOnline.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select one or more distros from the list");
            }
            else
            {
                //SpeedCounters.Visible = true;
                for (int i = 0; i < ImagesOnline.Items.Count; i++)
                {
                    //MessageBox.Show(i.ToString());
                    if (ImagesOnline.GetItemChecked(i))
                    {
                        //MessageBox.Show(ImagesOnline.GetItemChecked(i).ToString());
                        switch (i.ToString())
                        {
                            case "0":
                                lblId.Text = "IMAGE ID: 0";
                                lblId.Visible = false;

                                lblIso.Text = @"c:\iso\MX-21.3_ahs_x64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/mx-linux/files/Final/Xfce/MX-21.3_ahs_x64.iso/download";
                                break;
                            case "1":
                                lblId.Text = "IMAGE ID: 1";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\EndeavourOS_Cassini_neo_22_12.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://mirror.alpix.eu/endeavouros/iso/EndeavourOS_Cassini_neo_22_12.iso";
                                break;
                            case "2":
                                lblId.Text = "IMAGE ID: 2";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\linuxmint-21.1-cinnamon-64bit.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://mirror.crexio.com/linuxmint/isos/stable/21.1/linuxmint-21.1-cinnamon-64bit.iso";
                                break;
                            case "3":
                                lblId.Text = "IMAGE ID: 3";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\manjaro-kde-22.0.3-230213-linux61.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://download.manjaro.org/kde/22.0.3/manjaro-kde-22.0.3-230213-linux61.iso";
                                break;
                            case "4":
                                lblId.Text = "IMAGE ID: 4";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\manjaro-gnome-22.0.3-230213-linux61.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://download.manjaro.org/gnome/22.0.3/manjaro-gnome-22.0.3-230213-linux61.iso";
                                break;
                            case "5":
                                lblId.Text = "IMAGE ID: 5";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\pop-os_22.04_amd64_intel_22.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://iso.pop-os.org/22.04/amd64/intel/22/pop-os_22.04_amd64_intel_22.iso";
                                break;
                            case "6":
                                lblId.Text = "IMAGE ID: 6";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\pop-os_22.04_amd64_nvidia_22.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://iso.pop-os.org/22.04/amd64/nvidia/22/pop-os_22.04_amd64_nvidia_22.iso";
                                break;
                            case "7":
                                lblId.Text = "IMAGE ID: 7";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Fedora-Workstation-Live-x86_64-37-1.7.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://download.fedoraproject.org/pub/fedora/linux/releases/37/Workstation/x86_64/iso/Fedora-Workstation-Live-x86_64-37-1.7.iso";
                                break;
                            case "8":
                                lblId.Text = "IMAGE ID: 8";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ubuntu-22.04.1-desktop-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://releases.ubuntu.com/22.04.1/ubuntu-22.04.1-desktop-amd64.iso";
                                break;
                            case "9":
                                lblId.Text = "IMAGE ID: 9";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ubuntustudio-22.04.2-dvd-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://cdimage.ubuntu.com/ubuntustudio/releases/22.04.2/release/ubuntustudio-22.04.2-dvd-amd64.iso";
                                break;
                            case "10":
                                lblId.Text = "IMAGE ID: 10";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ubuntu-22.04.1-live-server-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://releases.ubuntu.com/22.04.1/ubuntu-22.04.1-live-server-amd64.iso";
                                break;
                            case "11":
                                lblId.Text = "IMAGE ID: 11";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Linux-lite-6.2-64bit.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.halifax.rwth-aachen.de/osdn/storage/g/l/li/linuxlite/6.2/linux-lite-6.2-64bit.iso";
                                break;
                            case "12":
                                lblId.Text = "IMAGE ID: 12";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Linux-lite-6.2-64bit.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.halifax.rwth-aachen.de/osdn/storage/g/l/li/linuxlite/6.2/linux-lite-6.2-64bit.iso";
                                break;
                            case "13":
                                lblId.Text = "IMAGE ID: 13";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\garuda-dr460nized-linux-zen-221019.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/garuda-linux/files/garuda/dr460nized/221019/garuda-dr460nized-linux-zen-221019.iso";
                                break;
                            case "14":
                                lblId.Text = "IMAGE ID: 14";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\elementaryos-7.0-stable.20230129rc.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ams3.dl.elementary.io/download/MTY3Njc4NTg3Nw==/elementaryos-7.0-stable.20230129rc.iso";
                                break;
                            case "15":
                                lblId.Text = "IMAGE ID: 15";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\voyagerlive.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/voyagerlive/files/latest/download";
                                break;
                            case "16":
                                lblId.Text = "IMAGE ID: 16";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\AV_Linux_MX_Edition-21.3_ahs_x64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://downloads.bandshed.net/AVL-MXE_21.3/AV_Linux_MX_Edition-21.3_ahs_x64.iso";
                                break;
                            case "17":
                                lblId.Text = "IMAGE ID: 17";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\haiku-r1beta4-x86_64-anyboot.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "http://mirror.rit.edu/haiku/r1beta4/haiku-r1beta4-x86_64-anyboot.iso";
                                break;
                            case "18":
                                lblId.Text = "IMAGE ID: 18";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\dfly-x86_64-6.4.0_REL.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://mirror-master.dragonflybsd.org/iso-images/dfly-x86_64-6.4.0_REL.iso";
                                break;
                            case "19":
                                lblId.Text = "IMAGE ID: 19";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\extix-22.12-64bit-deepin-20.8-refracta-2560mb-221218.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/extix/files/latest/download";
                                break;
                            case "20":
                                lblId.Text = "IMAGE ID: 20";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\FerenOS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/ferenoslinux/files/Feren-OS-standarddt.iso/download";
                                break;
                            case "21":
                                lblId.Text = "IMAGE ID: 21";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Nobara-37-Official-2023-02-05.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://nobara.h3o66.de/iso/Nobara-37-Official-2023-02-05.iso";
                                break;
                            case "22":
                                lblId.Text = "IMAGE ID: 22";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Qubes-R4.1.2-rc1-x86_64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.qubes-os.org/iso/Qubes-R4.1.2-rc1-x86_64.iso";
                                break;
                            case "23":
                                lblId.Text = "IMAGE ID: 23";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Neptune75-20220814.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://download.neptuneos.com/download/Neptune75-20220814.iso";
                                break;
                            case "24":
                                lblId.Text = "IMAGE ID: 24";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\athenaOS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/athena-iso/files/latest/download";
                                break;
                            case "25":
                                lblId.Text = "IMAGE ID: 25";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\slax-64bit-11.6.0.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.linux.cz/pub/linux/slax/Slax-11.x/slax-64bit-11.6.0.iso";
                                break;
                            case "26":
                                lblId.Text = "IMAGE ID: 26";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Zorin-OS-16.2-Core-64-bit-r1.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.halifax.rwth-aachen.de/zorinos/16/Zorin-OS-16.2-Core-64-bit-r1.iso";
                                break;
                            case "27":
                                lblId.Text = "IMAGE ID: 27";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\kali-linux-2022.4-installer-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://cdimage.kali.org/kali-2022.4/kali-linux-2022.4-installer-amd64.iso";
                                break;
                            case "28":
                                lblId.Text = "IMAGE ID: 28";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\cld-23-x86_64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://mirror.koddos.net/calculate-linux/release/23/cld-23-x86_64.iso";
                                break;
                            case "29":
                                lblId.Text = "IMAGE ID: 29";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\CorePlus-current.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "http://www.tinycorelinux.net/13.x/x86/release/CorePlus-current.iso";
                                break;
                            case "30":
                                lblId.Text = "IMAGE ID: 30";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\OracleLinux-R9-U1-x86_64-dvd.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://yum.oracle.com/ISOS/OracleLinux/OL9/u1/x86_64/OracleLinux-R9-U1-x86_64-dvd.iso";
                                break;
                            case "31":
                                lblId.Text = "IMAGE ID: 31";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\installOpenBSD72.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.fr.openbsd.org/pub/OpenBSD/7.2/amd64/install72.iso";
                                break;
                            case "32":
                                lblId.Text = "IMAGE ID: 32";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\LXLE-Focal-Release.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/lxle/files/Final/OS/Focal-64/LXLE-Focal-Release.iso/download";
                                break;
                            case "33":
                                lblId.Text = "IMAGE ID: 33";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\GeckoLinux_STATIC_Cinnamon.x86_64-154.220822.0.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/geckolinux/files/Static/154.220822/GeckoLinux_STATIC_Cinnamon.x86_64-154.220822.0.iso/download";
                                break;
                            case "34":
                                lblId.Text = "IMAGE ID: 34";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Peropesis-2.0-live.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://peropesis.org/peropesis/Peropesis-2.0-live.iso";
                                break;
                            case "35":
                                lblId.Text = "IMAGE ID: 35";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\MakuluLinux-ShiFt-U-2022-12-29.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/makulu/files/downloads/Shift/MakuluLinux-ShiFt-U-2022-12-29.iso/download";
                                break;
                            case "36":
                                lblId.Text = "IMAGE ID: 36";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\kodachi-8.27-64-kernel-6.2.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/linuxkodachi/files/kodachi-8.27-64-kernel-6.2.iso/download";
                                break;
                            case "37":
                                lblId.Text = "IMAGE ID: 37";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\bodhi-6.0.0-64-apppack.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/bodhilinux/files/6.0.0/bodhi-6.0.0-64-apppack.iso/download";
                                break;
                            case "38":
                                lblId.Text = "IMAGE ID: 38";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\TUXEDO-OS-2-202302271716.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://os.tuxedocomputers.com/TUXEDO-OS-2-202302271716.iso";
                                break;
                            case "39":
                                lblId.Text = "IMAGE ID: 39";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\tails-amd64-5.10.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://download.tails.net/tails/stable/tails-amd64-5.10/tails-amd64-5.10.iso";
                                break;
                            case "40":
                                lblId.Text = "IMAGE ID: 40";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\slackware64-15.0-install-dvd.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://mirrors.slackware.com/slackware/slackware-iso/slackware64-15.0-iso/slackware64-15.0-install-dvd.iso";
                                break;
                            case "41":
                                lblId.Text = "IMAGE ID: 41";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\linuxfx-11.2.22.04.7-win10-theme-cinnamon-wxd-13.0.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/linuxfxdevil/files/linuxfx-11.2.22.04.7-win10-theme-cinnamon-wxd-13.0.iso/download";
                                break;
                            case "42":
                                lblId.Text = "IMAGE ID: 42";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\linuxfx-11.2.22.04.7-win11-theme-plasma-wxd-13.0.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/linuxfxdevil/files/linuxfx-11.2.22.04.7-win11-theme-plasma-wxd-13.0.iso/download";
                                break;
                            case "43":
                                lblId.Text = "IMAGE ID: 43";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\fossapup64-9.5.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://distro.ibiblio.org/puppylinux/puppy-fossa/fossapup64-9.5.iso";
                                break;
                            case "44":
                                lblId.Text = "IMAGE ID: 44";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\arcolinuxb-awesome-v23.03.01-x86_64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.belnet.be/arcolinux/iso/v23.03.01/arcolinuxb-awesome-v23.03.01-x86_64.iso";
                                break;
                            case "45":
                                lblId.Text = "IMAGE ID: 45";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\easy-5.0-amd64.img";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://distro.ibiblio.org/easyos/amd64/releases/kirkstone/2023/5.0/easy-5.0-amd64.img";
                                break;
                            case "46":
                                lblId.Text = "IMAGE ID: 46";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\nitrux-nx-desktop-d5c7cdff-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/nitruxos/files/Release/ISO/nitrux-nx-desktop-d5c7cdff-amd64.iso/download";
                                break;
                            case "47":
                                lblId.Text = "IMAGE ID: 47";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Rocky-9.1-x86_64-dvd.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://download.rockylinux.org/pub/rocky/9/isos/x86_64/Rocky-9.1-x86_64-dvd.iso";
                                break;
                            case "48":
                                lblId.Text = "IMAGE ID: 48";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\salix64-xfce-15.0.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/salix/files/15.0/salix64-xfce-15.0.iso/download";
                                break;
                            case "49":
                                lblId.Text = "IMAGE ID: 49";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\devuan_beowulf_3.1.1_amd64_desktop.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://files.devuan.org/devuan_beowulf/installer-iso/devuan_beowulf_3.1.1_amd64_desktop.iso";
                                break;
                            case "50":
                                lblId.Text = "IMAGE ID: 50";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\livegui-amd64-20230226T163212Z.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://ftp.belnet.be/pub/rsync.gentoo.org/gentoo/releases/amd64/autobuilds/current-livegui-amd64/livegui-amd64-20230226T163212Z.iso";
                                break;
                            case "51":
                                lblId.Text = "IMAGE ID: 51";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\pureos-10~devel-gnome-live-20220602_amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://downloads.puri.sm/byzantium/gnome/2022-06-02/pureos-10~devel-gnome-live-20220602_amd64.iso";
                                break;
                            case "52":
                                lblId.Text = "IMAGE ID: 52";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ELD-9-x86_64-latest.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://fbi.cdn.euro-linux.com/isos/ELD-9-x86_64-latest.iso";
                                break;
                            case "53":
                                lblId.Text = "IMAGE ID: 53";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\primeos.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/primeos/files/latest/download";
                                break;
                            case "54":
                                lblId.Text = "IMAGE ID: 54";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\BLISSOS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/blissos-dev/files/latest/download";
                                break;
                            case "55":
                                lblId.Text = "IMAGE ID: 55";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ReactOS-0.4.14-release-57-g1e953d8-iso.zip";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/reactos/files/latest/download";
                                break;
                            case "56":
                                lblId.Text = "IMAGE ID: 56";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\PEPPERMINT OS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/peppermintos/files/latest/download";
                                break;
                            case "57":
                                lblId.Text = "IMAGE ID: 57";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\clear-37980-live-desktop.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://cdn.download.clearlinux.org/releases/37980/clear/clear-37980-live-desktop.iso";
                                break;
                            case "58":
                                lblId.Text = "IMAGE ID: 58";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Redcore.Linux.Hardened.2301.Sirius.KDE.amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "http://ro.mirror.redcorelinux.org/amd64/iso/Redcore.Linux.Hardened.2301.Sirius.KDE.amd64.iso";
                                break;
                            case "59":
                                lblId.Text = "IMAGE ID: 59";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\locos.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/loc-os/files/Loc-OS%2022/LXDE/Loc-OS-22-LXDE-x86_64.iso/download";
                                break;
                            case "60":
                                lblId.Text = "IMAGE ID: 60";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\MABOX.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/mabox-linux/files/latest/download";
                                break;
                            case "61":
                                lblId.Text = "IMAGE ID: 61";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\remixOS.zip";
                                lblUrl.Text = "https://sourceforge.net/projects/remix-os/files/Remix_OS_for_PC_Android_M_64bit_B2016112101.zip/download";
                                break;
                            case "62":
                                lblId.Text = "IMAGE ID: 62";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\EMMABUNTUS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/emmabuntus/files/latest/download";
                                break;
                            case "63":
                                lblId.Text = "IMAGE ID: 63";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\arcolinuxb-xtended-v23.03.01-x86_64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/arcolinux-community-editions/files/xtended/arcolinuxb-xtended-v23.03.01-x86_64.iso/download";
                                break;
                            case "64":
                                lblId.Text = "IMAGE ID: 64";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\openmandriva.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/openmandriva/files/latest/download";
                                break;
                            case "65":
                                lblId.Text = "IMAGE ID: 65";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\legacyos.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/legacyoslinux/files/latest/download";
                                break;
                            case "66":
                                lblId.Text = "IMAGE ID: 66";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Xiaopan%206.4.1.zip";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://netcologne.dl.sourceforge.net/project/xiaopanos/Xiaopan%206.4.1.zip";
                                break;
                            case "67":
                                lblId.Text = "IMAGE ID: 67";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\cachyos.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/cachyos-arch/files/latest/download";
                                break;
                            case "68":
                                lblId.Text = "IMAGE ID: 68";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\slint64-15.0-2.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://slackware.uk/slint/x86_64/slint-15.0/iso/slint64-15.0-2.iso";
                                break;
                            case "69":
                                lblId.Text = "IMAGE ID: 69";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\neurolinux-20.04.2-2021.04.05-April%202021.0-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "http://neurolinux.net/downloads/neurolinux-20.04.2-2021.04.05-April%202021.0-amd64.iso";
                                break;
                            case "70":
                                lblId.Text = "IMAGE ID: 70";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\jarro4_0_0.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://jarronegro.mx/jarro4_0_0.iso";
                                break;
                            case "71":
                                lblId.Text = "IMAGE ID: 71";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\predator-os-v2.5-LTS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://seilany.ir/predator-os/download/predator-os-v2.5-LTS.iso";
                                break;
                            case "72":
                                lblId.Text = "IMAGE ID: 72";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\XOS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/xos-workstation/files/latest/download";
                                break;
                            case "73":
                                lblId.Text = "IMAGE ID: 73";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\DRAGONOS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/dragonos-focal/files/latest/download";
                                break;
                            case "74":
                                lblId.Text = "IMAGE ID: 74";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\lixix.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://caesar-rylan.60.nu/lirix/iso";
                                break;
                            case "75":
                                lblId.Text = "IMAGE ID: 75";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\Circle-8.7-x86_64-dvd1.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://mirror.cclinux.org/pub/circle/8.7/isos/x86_64/Circle-8.7-x86_64-dvd1.iso";
                                break;
                            case "76":
                                lblId.Text = "IMAGE ID: 76";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\rolling-2022-09-07.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://archive.org/download/rolling-2022-09-07/rolling-2022-09-07.iso";
                                break;
                            case "77":
                                lblId.Text = "IMAGE ID: 77";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\titan.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/titan-linux/files/latest/download";
                                break;
                            case "78":
                                lblId.Text = "IMAGE ID: 78";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\crowz.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/crowz/files/latest/download";
                                break;
                            case "79":
                                lblId.Text = "IMAGE ID: 79";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\datLinux.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/dat-linux/files/latest/download";
                                break;
                            case "80":
                                lblId.Text = "IMAGE ID: 80";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\freedomOS.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/freedomoslinux/files/latest/download";
                                break;
                            case "81":
                                lblId.Text = "IMAGE ID: 81";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\metis-base-runit-20220717-v1.1.1-x86_64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://github.com/metis-os/metis-iso/releases/download/v1.1.1/metis-base-runit-20220717-v1.1.1-x86_64.iso";
                                break;
                            case "82":
                                lblId.Text = "IMAGE ID: 82";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\gnuinos-4.0.0-chimaera_2023.02.22-ob_amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://www.gnuinos.org/mirror/chimaera/live/gnuinos-4.0.0-chimaera_2023.02.22-ob_amd64.iso";
                                break;
                            case "83":
                                lblId.Text = "IMAGE ID: 83";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\gnuinos-5.0.0-daedalus_2022.11.05-xfce_amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://www.gnuinos.org/mirror/daedalus/live/gnuinos-5.0.0-daedalus_2022.11.05-xfce_amd64.iso";
                                break;
                            case "84":
                                lblId.Text = "IMAGE ID: 84";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\convectix_darwin.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://myb.convectix.com/DL/nubectl-darwin";
                                break;
                            case "85":
                                lblId.Text = "IMAGE ID: 85";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\myb-13.1.2.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://myb.convectix.com/DL/myb-13.1.2.iso";
                                break;
                            case "86":
                                lblId.Text = "IMAGE ID: 86";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ShinyOS-V1-desktop-amd64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/shinyos/files/ShinyOS-V1-desktop-amd64.iso/download";
                                break;
                            case "87":
                                lblId.Text = "IMAGE ID: 87";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\carbonOS-2022.3-installer.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://repo.carbon.sh/img/carbonOS-2022.3-installer.iso";
                                break;
                            case "88":
                                lblId.Text = "IMAGE ID: 88";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\PikaOS-Gnome-2210-amd64_23.02.17.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://pika-os.com/PikaOS-Gnome-2210-amd64_23.02.17.iso";
                                break;
                            case "89":
                                lblId.Text = "IMAGE ID: 89";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\PikaOS-KDE-2210-amd64_23.02.18.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://pika-os.com/PikaOS-KDE-2210-amd64_23.02.18.iso";
                                break;
                            case "90":
                                lblId.Text = "IMAGE ID: 90";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\blendOS-2023.01.26-x86_64.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://github.com/blend-os/blendOS/releases/download/23.01/blendOS-2023.01.26-x86_64.iso";
                                break;
                            case "91":
                                lblId.Text = "IMAGE ID: 91";
                                lblId.Visible = false;
                                lblIso.Text = @"c:\iso\ACCCoco.iso";
                                lblIso.Visible = false;
                                lblUrl.Text = "https://sourceforge.net/projects/accessible-coconut/files/latest/download";
                                break;
                            default:
                                break;
                        }
                    }
                }
                //HttpClient client = new HttpClient();

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri(lblUrl.Text), lblIso.Text);
            }
        }

        private void radio10GB_SelectedChanged(object sender, EventArgs e)
        {
            if (radio10GB.Checked)
            {
                RamSize = "10G";
                Global.Ps.StandardInput.WriteLine("echo ramdisk size " + this.RamSize);
            }
            else
            {
                RamSize = "4G";
                Global.Ps.StandardInput.WriteLine("echo ramdisk size " + this.RamSize);
            }
        }

        private void Distroboot_Load(object sender, EventArgs e)
        {
            //
        }

        private void FindImage(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();
            dlg.InitialDirectory = "c:\\ISO\\";

            dlg.ShowDialog();
            string fileName = dlg.FileName;
            if (!ImagesLocal.Items.Contains(fileName))
            {
                ImagesLocal.Items.Add(fileName);
            }
        }

        private void ScanImages(object sender, EventArgs e)
        {
            ImagesLocal.Items.Clear();
            Process ps = Global.Ps;
            foreach (var item in Directory.EnumerateFiles("c:\\ISO", "*"))
            {
                if (item.ToLower().EndsWith(".zip"))
                {
                    Global.Ps.StandardInput.WriteLine("start /wait PowerShell -Command \"Expand-Archive -Path " + item + " -DestinationPath C:\\ISO\"");
                    Global.Ps.StandardInput.WriteLine("del " + item);
                }
                if (item.ToUpper().EndsWith(".ISO") || item.ToUpper().EndsWith(".IMG"))
                {
                    ImagesLocal.Items.Add(item);
                }
            }

        }
        private void ShowTerminal(object sender, RoutedEventArgs e)
        {
            IntPtr hWnd = Global.Ps.MainWindowHandle;
            ShowWindow((int)hWnd, SW_HIDE);
            //ShowOutput.ToolTip = "Hide Terminal Output";
        }

        private void HideTerminal(object sender, RoutedEventArgs e)
        {
            IntPtr hWnd = Global.Ps.MainWindowHandle;
            ShowWindow((int)hWnd, SW_HIDE);
            //ShowOutput.ToolTip = "Show Terminal Output";
        }
        private void RemoveItem(object sender, EventArgs e)
        {
            int Index = ImagesLocal.SelectedIndex;
            if (Index != -1)
            {
                ImagesLocal.Items.RemoveAt(Index);
            }
        }

        public void StartImage(object sender, MouseEventArgs e)
        {
            //int pid = Global.Pid;
            //int hWnd = (int)Global.process.MainWindowHandle;
            //ShowWindow(hWnd, SW_HIDE);
            if (!System.IO.File.Exists("C:\\Program Files\\qemu\\qemu-system-x86_64.exe"))
            { Global.Ps.StandardInput.WriteLine("powershell -command \"winget install qemu\""); }

            string? fileName = ImagesLocal.Text;
            Global.Ps.StandardInput.WriteLine("echo ramdisk size " + this.RamSize);
            if (fileName.ToUpper().Contains(".IMG"))
            {
                Global.Ps.StandardInput.WriteLine("\"C:\\Program Files\\qemu\\qemu-system-x86_64.exe\" -m " + this.RamSize + " -drive file=" +
                (char)34 + fileName + (char)34 + ",format=raw,index=0,media=disk -vga virtio -no-reboot");
            };
            if (fileName.ToUpper().Contains(".ISO"))
            {
                Global.Ps.StandardInput.WriteLine("\"C:\\Program Files\\qemu\\qemu-system-x86_64.exe\" -cdrom " +
                (char)34 + fileName + (char)34 + " -m " + this.RamSize);
            };
            if (Global.Ps.HasExited)
            {
                //PrepSystem(sender, e);
            }
            if (ShowOutput.Checked)
            {
                ShowWindow((int)hWnd, SW_SHOW);
            }
            else
            {
                ShowWindow((int)hWnd, SW_HIDE);
            }
        }
    }
}