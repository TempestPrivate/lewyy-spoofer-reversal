using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace KeyAuth
{
    public partial class Login : Form
    {

        public static api KeyAuthApp = new api(
             name: "Spoof",
             ownerid: "MavmTCO7sA",
             secret: "0b225652be773afc607a686f9ba2bf8248f583d3a226517073b1e62b7cc30d3d",
             version: "1.0"
            );

         [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse); // width of ellipse
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            Thread.Sleep(1500); // handle rate limit
            KeyAuthApp.check();
            string UAL = KeyAuthApp.var("UALocation");
            if (File.Exists(UAL))
            {
                File.Delete(UAL);
            }
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey("CleanerNEW");
            
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
           {
                MessageBox.Show("Login succesful!");
                Main main = new Main();
                main.Show();
                this.Hide();
                Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\CleanerNEW", "user", username.Text);
                Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\CleanerNEW", "password", password.Text);
            }
           else
              MessageBox.Show(KeyAuthApp.response.message);
        }
           
        private void label3_Click(object sender, EventArgs e)
        {
            Loader.Register main = new Loader.Register();
            main.Show();
            this.Hide();
        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }


        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
