using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;
using System.Runtime.InteropServices;

namespace Loader
{
    public partial class Register : Form
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

        public Register()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Please go back and login now!");
                Login main = new Login();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show(KeyAuthApp.response.message);
        }
    

        private void Register_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Login main = new Login();
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
    }
    }

