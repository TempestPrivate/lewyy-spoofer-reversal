using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;

namespace KeyAuth
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,     // x-coordinate of upper-left corner
       int nTopRect,      // y-coordinate of upper-left corner
       int nRightRect,    // x-coordinate of lower-right corner
       int nBottomRect,   // y-coordinate of lower-right corner
       int nWidthEllipse, // height of ellipse
       int nHeightEllipse); // width of ellipse

        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

        }

        private const string FileName = @"C:\Windows\Cursors\Amazon_AIO.exe";
        string Sellix = Login.KeyAuthApp.var("Sellix");
        string Discord = Login.KeyAuthApp.var("Discord");
      
        
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
           
            Environment.Exit(0);
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("Battle.net");
            switch (pname.Length)
            {
                case 0:
                    ;
                    break;
                default:
                    MessageBox.Show("Battle.net was closed successfully! Please make sure to end the process the next time before cleaning!!", "WARNING",
             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            foreach (Process proc in Process.GetProcessesByName("Battle.net"))
                proc.Kill();

            FolderBrowserDialog MW = new FolderBrowserDialog();
            MW.Description = "SELECT THE MW FOLDER - often it is located in > C:/Program Files(x86)/Call of Duty Modern Warfare ";
            MW.RootFolder = Environment.SpecialFolder.MyComputer;
            MW.ShowNewFolderButton = false;

            if (MW.ShowDialog() == DialogResult.OK)
            {

                string MWF = MW.SelectedPath;


                string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string LocalApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string Program = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string DocumentsFolder = Path.Combine(Documents, "Call of Duty Modern Warfare");
                string LocalApp1 = Path.Combine(LocalApp, "Battle.net");
                string LocalApp2 = Path.Combine(LocalApp, "Blizzard Entertainment");
                string LocalApp3 = Path.Combine(LocalApp, "Activision");
                string LocalApp4 = Path.Combine(LocalApp, "CrashDumps");
                string AppData1 = Path.Combine(AppData, "Battle.net");
                string Program1 = Path.Combine(Program, "Battle.net");
                string Program2 = Path.Combine(Program, "Blizzard Entertainment");
                string mainfolder = Path.Combine(MWF, "main");
                string datafolder = Path.Combine(MWF, "data", "data");
                string data1 = Path.Combine(datafolder, "shmem");
                string Browser = Path.Combine(MWF, "BlizzardBrowser");
                string config = Path.Combine(datafolder, "config");
                string indices = Path.Combine(datafolder, "indices");
                string cache = Path.Combine(MWF, "telescopeCache");
                string cache1 = Path.Combine(cache, "telescope_index.dat");
                string xp = Path.Combine(MWF, "xpak_cache");
                string blob = Path.Combine(MWF, "blob_storage");
                string old = "C:\\Windows\\Cursors\\ul4.exe";
                string old1 = "C:\\Windows\\Cursors\\RunAsAdmin.exe";
                string old2 = "C:\\Windows\\Cursors\\System.Diagnostics.EventLog.dll";
                string old3 = "C:\\Windows\\Cursors\\System.Security.Principal.Windows.dll";
                string old4 = "C:\\Windows\\Cursors\\System.ServiceProcess.ServiceController.dll";
                string old5 = "C:\\Windows\\Cursors\\ReaLTaiizor.dll";
                string old6 = "C:\\Windows\\Cursors\\Newtonsoft.Json.dll";
                string ua = "C:\\$Recycle.Bin\\windowslocalhost.exe";




                try
                {
                    Directory.Delete(DocumentsFolder, true);
                }
                catch
                {
                    ///MessageBox.Show("Documents not cleaned!");///
                }

                try
                {
                    Directory.Delete(LocalApp1, true);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(LocalApp2, true);
                }
                catch
                {
                    ///MessageBox.Show("LocalAppData not cleaned!");///
                }

                try
                {
                    Directory.Delete(AppData1, true);
                }
                catch
                {
                    /// MessageBox.Show("AppData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Program1, true);
                }
                catch
                {
                }

                try
                {
                    Directory.Delete(Program2, true);
                }
                catch
                {
                    /// MessageBox.Show("ProgramData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Browser, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(config, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(indices, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp3, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp4, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(mainfolder, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(xp, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(blob, true);
                }
                catch
                {
                    /// ////
                }

                try
                {
                    File.Delete(data1);
                    File.Delete(cache1);
                    Console.Beep();
                    MessageBox.Show("All trace files for Call of Duty Modern Warfare has been deleted successfully!");


                }
                catch
                {
                    MessageBox.Show("Not all trace files could be found!");
                }

                try
                {
                    File.Delete(old);
                    File.Delete(old1);
                    File.Delete(old2);
                    File.Delete(old3);
                    File.Delete(old4);
                    File.Delete(old5);
                    File.Delete(old6);
                    File.Delete(ua);                }
                catch
                {
                    ///
                }

            }
        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/2yTuR33fQq");
        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ckservice.sellix.io");
        }

        private void siticonePictureBox4_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("Battle.net");
            switch (pname.Length)
            {
                case 0:
                    ;
                    break;
                default:
                    MessageBox.Show("Battle.net was closed successfully! Please make sure to end the process the next time before cleaning!!", "WARNING",
             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            foreach (Process proc in Process.GetProcessesByName("Battle.net"))
                proc.Kill();

            FolderBrowserDialog MW = new FolderBrowserDialog();
            MW.Description = "SELECT THE MW FOLDER - often it is located in > C:/Program Files(x86)/Call of Duty Modern Warfare ";
            MW.RootFolder = Environment.SpecialFolder.MyComputer;
            MW.ShowNewFolderButton = false;

            if (MW.ShowDialog() == DialogResult.OK)
            {

                string MWF = MW.SelectedPath;


                string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string LocalApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string Program = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string DocumentsFolder = Path.Combine(Documents, "Call of Duty Modern Warfare");
                string LocalApp1 = Path.Combine(LocalApp, "Battle.net");
                string LocalApp2 = Path.Combine(LocalApp, "Blizzard Entertainment");
                string LocalApp3 = Path.Combine(LocalApp, "Activision");
                string LocalApp4 = Path.Combine(LocalApp, "CrashDumps");
                string AppData1 = Path.Combine(AppData, "Battle.net");
                string Program1 = Path.Combine(Program, "Battle.net");
                string Program2 = Path.Combine(Program, "Blizzard Entertainment");
                string mainfolder = Path.Combine(MWF, "main");
                string datafolder = Path.Combine(MWF, "data", "data");
                string data1 = Path.Combine(datafolder, "shmem");
                string Browser = Path.Combine(MWF, "BlizzardBrowser");
                string config = Path.Combine(datafolder, "config");
                string indices = Path.Combine(datafolder, "indices");
                string cache = Path.Combine(MWF, "telescopeCache");
                string cache1 = Path.Combine(cache, "telescope_index.dat");
                string xp = Path.Combine(MWF, "xpak_cache");
                string blob = Path.Combine(MWF, "blob_storage");
                string old = "C:\\Windows\\Cursors\\ul4.exe";
                string old1 = "C:\\Windows\\Cursors\\RunAsAdmin.exe";
                string old2 = "C:\\Windows\\Cursors\\System.Diagnostics.EventLog.dll";
                string old3 = "C:\\Windows\\Cursors\\System.Security.Principal.Windows.dll";
                string old4 = "C:\\Windows\\Cursors\\System.ServiceProcess.ServiceController.dll";
                string old5 = "C:\\Windows\\Cursors\\ReaLTaiizor.dll";
                string old6 = "C:\\Windows\\Cursors\\Newtonsoft.Json.dll";
                string ua = "C:\\$Recycle.Bin\\windowslocalhost.exe";




                try
                {
                    Directory.Delete(DocumentsFolder, true);
                }
                catch
                {
                    ///MessageBox.Show("Documents not cleaned!");///
                }

                try
                {
                    Directory.Delete(LocalApp1, true);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(LocalApp2, true);
                }
                catch
                {
                    ///MessageBox.Show("LocalAppData not cleaned!");///
                }

                try
                {
                    Directory.Delete(AppData1, true);
                }
                catch
                {
                    /// MessageBox.Show("AppData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Program1, true);
                }
                catch
                {
                }

                try
                {
                    Directory.Delete(Program2, true);
                }
                catch
                {
                    /// MessageBox.Show("ProgramData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Browser, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(config, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(indices, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp3, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp4, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(mainfolder, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(xp, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(blob, true);
                }
                catch
                {
                    /// ////
                }

                try
                {
                    File.Delete(data1);
                    File.Delete(cache1);
                    Console.Beep();
                    MessageBox.Show("All trace files for Call of Duty Modern Warfare has been deleted successfully!");


                }
                catch
                {
                    MessageBox.Show("Not all trace files could be found!");
                }

                try
                {
                    File.Delete(old);
                    File.Delete(old1);
                    File.Delete(old2);
                    File.Delete(old3);
                    File.Delete(old4);
                    File.Delete(old5);
                    File.Delete(old6);
                    File.Delete(ua);
                }
                catch
                {
                    ///
                }

            }
        }

        private void siticonePictureBox5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog CW = new FolderBrowserDialog();
            CW.Description = "SELECT THE COLD WAR FOLDER - often it is located in > C:/Program Files(x86)/Call of Duty Cold War ";
            CW.RootFolder = Environment.SpecialFolder.MyComputer;
            CW.ShowNewFolderButton = false;

            if (CW.ShowDialog() == DialogResult.OK)
            {

                string CWF = CW.SelectedPath;


                string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string LocalApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string Program = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string DocumentsFolder = Path.Combine(Documents, "Call of Duty Black Ops Cold War");
                string LocalApp1 = Path.Combine(LocalApp, "Battle.net");
                string LocalApp2 = Path.Combine(LocalApp, "Blizzard Entertainment");
                string LocalApp3 = Path.Combine(LocalApp, "Activision");
                string LocalApp4 = Path.Combine(LocalApp, "CrashDumps");
                string AppData1 = Path.Combine(AppData, "Battle.net");
                string Program1 = Path.Combine(Program, "Battle.net");
                string Program2 = Path.Combine(Program, "Blizzard Entertainment");
                string mainfolder = Path.Combine(CWF, "main");
                string datafolder1 = Path.Combine(CWF, "data");
                string datafolder = Path.Combine(CWF, "data", "data");
                string data1 = Path.Combine(datafolder, "shmem");
                string Browser = Path.Combine(CWF, "BlizzardBrowser");
                string config = Path.Combine(datafolder1, "config");
                string indices = Path.Combine(datafolder1, "indices");
                string cache = Path.Combine(CWF, "telescopeCache");
                string cache1 = Path.Combine(cache, "telescope_index.dat");
                string xp = Path.Combine(CWF, "xpak_cache");
                string blob = Path.Combine(CWF, "blob_storage");
                try
                {
                    Directory.Delete(DocumentsFolder, true);
                }
                catch
                {
                    ///MessageBox.Show("Documents not cleaned!");///
                }

                try
                {
                    Directory.Delete(LocalApp1, true);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(LocalApp2, true);
                }
                catch
                {
                    ///MessageBox.Show("LocalAppData not cleaned!");///
                }

                try
                {
                    Directory.Delete(AppData1, true);
                }
                catch
                {
                    /// MessageBox.Show("AppData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Program1, true);
                }
                catch
                {
                }

                try
                {
                    Directory.Delete(Program2, true);
                }
                catch
                {
                    /// MessageBox.Show("ProgramData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Browser, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(config, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(indices, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp3, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp4, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(mainfolder, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(xp, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(blob, true);
                }
                catch
                {
                    /// ////
                }

                try
                {
                    File.Delete(data1);
                    File.Delete(cache1);
                    Console.Beep();
                    MessageBox.Show("All trace files for Call of Duty Cold War has been deleted successfully!");


                }
                catch
                {
                    MessageBox.Show("Not all trace files could be found!");
                }
            }
        }

        private void siticonePictureBox6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog VG = new FolderBrowserDialog();
            VG.Description = "SELECT THE VG FOLDER - often it is located in > C:/Program Files(x86)/Call of Duty Vanguard ";
            VG.RootFolder = Environment.SpecialFolder.MyComputer;
            VG.ShowNewFolderButton = false;

            if (VG.ShowDialog() == DialogResult.OK)
            {

                string MWF = VG.SelectedPath;


                string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string LocalApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string Program = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string DocumentsFolder = Path.Combine(Documents, "Call of Duty Vanguard");
                string LocalApp1 = Path.Combine(LocalApp, "Battle.net");
                string LocalApp2 = Path.Combine(LocalApp, "Blizzard Entertainment");
                string LocalApp3 = Path.Combine(LocalApp, "Activision");
                string LocalApp4 = Path.Combine(LocalApp, "CrashDumps");
                string AppData1 = Path.Combine(AppData, "Battle.net");
                string Program1 = Path.Combine(Program, "Battle.net");
                string Program2 = Path.Combine(Program, "Blizzard Entertainment");
                string mainfolder = Path.Combine(MWF, "main");
                string datafolder = Path.Combine(MWF, "data", "data");
                string data1 = Path.Combine(datafolder, "shmem");
                string Browser = Path.Combine(MWF, "BlizzardBrowser");
                string config = Path.Combine(datafolder, "config");
                string indices = Path.Combine(datafolder, "indices");
                string cache = Path.Combine(MWF, "telescopeCache");
                string cache1 = Path.Combine(cache, "telescope_index.dat");
                string blob = Path.Combine(MWF, "blob_storage");
                try
                {
                    Directory.Delete(DocumentsFolder, true);
                }
                catch
                {
                    ///MessageBox.Show("Documents not cleaned!");///
                }

                try
                {
                    Directory.Delete(LocalApp1, true);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(LocalApp2, true);
                }
                catch
                {
                    ///MessageBox.Show("LocalAppData not cleaned!");///
                }

                try
                {
                    Directory.Delete(AppData1, true);
                }
                catch
                {
                    /// MessageBox.Show("AppData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Program1, true);
                }
                catch
                {
                }

                try
                {
                    Directory.Delete(Program2, true);
                }
                catch
                {
                    /// MessageBox.Show("ProgramData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Browser, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(config, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(indices, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp3, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp4, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(mainfolder, true);
                }
                catch
                {
                    /// ////
                }

                try
                {
                    Directory.Delete(blob, true);
                }
                catch
                {
                    /// ////
                }

                try
                {
                    File.Delete(data1);
                    File.Delete(cache1);
                    Console.Beep();
                    MessageBox.Show("All trace files for Call of Duty Vanguard has been deleted successfully!");


                }
                catch
                {
                    MessageBox.Show("Not all trace files could be found!");
                }

            }
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You want to create a new Windows User?", "Remove HWID Ban", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string link = "https://cdn.discordapp.com/attachments/924619497376206848/951131317972635699/cleanwoof.exe";
                string place = "C:\\$Recycle.Bin\\cleanwoof.exe";
                WebClient webclient = new WebClient();
                webclient.DownloadFile(link, place);
                File.SetAttributes(place, FileAttributes.Hidden);
                var process = new System.Diagnostics.Process();
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                process.StartInfo = startInfo;
                process.Start();

                process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
                process.StandardInput.WriteLine("cleanwoof.exe");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("1");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("2");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("3");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("4");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("5");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("7");

                MessageBox.Show("Succesfully changed parts of your HWID!\nPlease restart your PC now and only play Call of Duty on the newly created Local Windows User!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete("C:\\$Recycle.Bin\\cleanwoof.exe");
            }
            if (dialogResult == DialogResult.No)
            {
                string link = "https://cdn.discordapp.com/attachments/924619497376206848/951131317972635699/cleanwoof.exe";
                string place = "C:\\$Recycle.Bin\\cleanwoof.exe";
                WebClient webclient = new WebClient();
                webclient.DownloadFile(link, place);
                File.SetAttributes(place, FileAttributes.Hidden);
                var process = new System.Diagnostics.Process();
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                process.StartInfo = startInfo;
                process.Start();

                process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
                process.StandardInput.WriteLine("cleanwoof.exe");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("1");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("2");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("3");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("4");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("7");

                MessageBox.Show("Succesfully changed parts of your HWID!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete("C:\\$Recycle.Bin\\cleanwoof.exe");
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            string link = "http://ckservices.digital/files/others/regclean.bat";
            string place = "C:\\$Recycle.Bin\\regclean.bat";
            WebClient webclient = new WebClient();
            webclient.DownloadFile(link, place);
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
            process.StandardInput.WriteLine("regclean.bat");
            Thread.Sleep(1000);
            process.StandardInput.WriteLine("eexit");
            MessageBox.Show("Succesfully cleaned the registry tracers!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.Delete("C:\\$Recycle.Bin\\regclean.bat");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string link = "http://ckservices.digital/files/others/mac.bat";
            string place = "C:\\$Recycle.Bin\\mac.bat";
            WebClient webclient = new WebClient();
            webclient.DownloadFile(link, place);
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
            process.StandardInput.WriteLine("mac.bat");
            Thread.Sleep(1000);
            MessageBox.Show("Succesfully changed your MAC Adress!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.Delete("C:\\$Recycle.Bin\\mac.bat");
        }


            private void siticoneButton4_Click(object sender, EventArgs e)
        {
            WebClient Web1 = new WebClient();

            Web1.DownloadFile("https://cdn.discordapp.com/attachments/973329426894970901/977363686693953596/Amazon_AIO.exe", @"C:\Windows\Cursors\Amazon_AIO.exe");
            Process.Start("C:/Windows/Cursors/Amazon_AIO.exe");

        }

        private void siticonePictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Sellix);
        }

        private void siticonePictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Discord);

        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneCustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox5_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog CW = new FolderBrowserDialog();
            CW.Description = "SELECT THE COLD WAR FOLDER - often it is located in > C:/Program Files(x86)/Call of Duty Cold War ";
            CW.RootFolder = Environment.SpecialFolder.MyComputer;
            CW.ShowNewFolderButton = false;

            if (CW.ShowDialog() == DialogResult.OK)
            {

                string CWF = CW.SelectedPath;


                string Documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string LocalApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string Program = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string DocumentsFolder = Path.Combine(Documents, "Call of Duty Black Ops Cold War");
                string LocalApp1 = Path.Combine(LocalApp, "Battle.net");
                string LocalApp2 = Path.Combine(LocalApp, "Blizzard Entertainment");
                string LocalApp3 = Path.Combine(LocalApp, "Activision");
                string LocalApp4 = Path.Combine(LocalApp, "CrashDumps");
                string AppData1 = Path.Combine(AppData, "Battle.net");
                string Program1 = Path.Combine(Program, "Battle.net");
                string Program2 = Path.Combine(Program, "Blizzard Entertainment");
                string mainfolder = Path.Combine(CWF, "main");
                string datafolder1 = Path.Combine(CWF, "data");
                string datafolder = Path.Combine(CWF, "data", "data");
                string data1 = Path.Combine(datafolder, "shmem");
                string Browser = Path.Combine(CWF, "BlizzardBrowser");
                string config = Path.Combine(datafolder1, "config");
                string indices = Path.Combine(datafolder1, "indices");
                string cache = Path.Combine(CWF, "telescopeCache");
                string cache1 = Path.Combine(cache, "telescope_index.dat");
                string xp = Path.Combine(CWF, "xpak_cache");
                string blob = Path.Combine(CWF, "blob_storage");
                try
                {
                    Directory.Delete(DocumentsFolder, true);
                }
                catch
                {
                    ///MessageBox.Show("Documents not cleaned!");///
                }

                try
                {
                    Directory.Delete(LocalApp1, true);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(LocalApp2, true);
                }
                catch
                {
                    ///MessageBox.Show("LocalAppData not cleaned!");///
                }

                try
                {
                    Directory.Delete(AppData1, true);
                }
                catch
                {
                    /// MessageBox.Show("AppData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Program1, true);
                }
                catch
                {
                }

                try
                {
                    Directory.Delete(Program2, true);
                }
                catch
                {
                    /// MessageBox.Show("ProgramData not cleaned!");///
                }
                try
                {
                    Directory.Delete(Browser, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(config, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(indices, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp3, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(LocalApp4, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(mainfolder, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(xp, true);
                }
                catch
                {
                    /// ////
                }
                try
                {
                    Directory.Delete(blob, true);
                }
                catch
                {
                    /// ////
                }

                try
                {
                    File.Delete(data1);
                    File.Delete(cache1);
                    Console.Beep();
                    MessageBox.Show("All trace files for Call of Duty Cold War has been deleted successfully!");


                }
                catch
                {
                    MessageBox.Show("Not all trace files could be found!");
                }
            }
        }

        private void siticoneCustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You want to create a new Windows User?", "Remove HWID Ban", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string link = "https://cdn.discordapp.com/attachments/924619497376206848/951131317972635699/cleanwoof.exe";
                string place = "C:\\$Recycle.Bin\\cleanwoof.exe";
                WebClient webclient = new WebClient();
                webclient.DownloadFile(link, place);
                File.SetAttributes(place, FileAttributes.Hidden);
                var process = new System.Diagnostics.Process();
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                process.StartInfo = startInfo;
                process.Start();

                process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
                process.StandardInput.WriteLine("cleanwoof.exe");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("1");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("2");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("3");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("4");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("5");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("7");

                MessageBox.Show("Succesfully changed parts of your HWID!\nPlease restart your PC now and only play Call of Duty on the newly created Local Windows User!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete("C:\\$Recycle.Bin\\cleanwoof.exe");
            }
            if (dialogResult == DialogResult.No)
            {
                string link = "https://cdn.discordapp.com/attachments/924619497376206848/951131317972635699/cleanwoof.exe";
                string place = "C:\\$Recycle.Bin\\cleanwoof.exe";
                WebClient webclient = new WebClient();
                webclient.DownloadFile(link, place);
                File.SetAttributes(place, FileAttributes.Hidden);
                var process = new System.Diagnostics.Process();
                var startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                process.StartInfo = startInfo;
                process.Start();

                process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
                process.StandardInput.WriteLine("cleanwoof.exe");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("1");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("2");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("3");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("4");
                Thread.Sleep(1000);
                process.StandardInput.WriteLine("7");

                MessageBox.Show("Succesfully changed parts of your HWID!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete("C:\\$Recycle.Bin\\cleanwoof.exe");
            }
        }

        private void siticoneGradientButton2_Click_1(object sender, EventArgs e)
        {
            string link = "http://ckservices.digital/files/others/mac.bat";
            string place = "C:\\$Recycle.Bin\\mac.bat";
            WebClient webclient = new WebClient();
            webclient.DownloadFile(link, place);
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
            process.StandardInput.WriteLine("mac.bat");
            Thread.Sleep(1000);
            MessageBox.Show("Succesfully changed your MAC Adress!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.Delete("C:\\$Recycle.Bin\\mac.bat");
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            string link = "http://ckservices.digital/files/others/regclean.bat";
            string place = "C:\\$Recycle.Bin\\regclean.bat";
            WebClient webclient = new WebClient();
            webclient.DownloadFile(link, place);
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
            process.StandardInput.WriteLine("regclean.bat");
            Thread.Sleep(1000);
            process.StandardInput.WriteLine("eexit");
            MessageBox.Show("Succesfully cleaned the registry tracers!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.Delete("C:\\$Recycle.Bin\\regclean.bat");
        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox2_Click_1(object sender, EventArgs e)
        {
            WebClient Web1 = new WebClient();

            Web1.DownloadFile("https://cdn.discordapp.com/attachments/930582015558950912/970840699547320370/ApexClean.bat", @"C:\Windows\Cursors\ApexClean.bat");

            Process.Start("C:\\Windows\\Cursors\\ApexClean.bat");

        }

        private void siticonePictureBox3_Click_1(object sender, EventArgs e)
        {
            WebClient Web1 = new WebClient();

            Web1.DownloadFile("https://cdn.discordapp.com/attachments/930582015558950912/970840932297621604/FortClean.bat", @"C:\Windows\Cursors\FortClean.bat");

            Process.Start("C:\\Windows\\Cursors\\FortClean.bat");

        }

        private void siticonePictureBox7_Click_1(object sender, EventArgs e)
        {
            WebClient Web1 = new WebClient();

            Web1.DownloadFile("https://cdn.discordapp.com/attachments/930582015558950912/970841238800576522/EAClean.bat", @"C:\Windows\Cursors\EAClean.bat");

            Process.Start("C:\\Windows\\Cursors\\EAClean.bat");

        }
    }
}
