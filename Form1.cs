using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DERIN
{
    public partial class Form1 : Form
    {
        public static string appPath = Application.StartupPath + "\\",
              http = "http://", //URL First address
              url = "zenlty.com.tr.ht/", //Web address
              ftp = "ftp://" + url, // FTP Address
              pin_name = "pin.txt", // Pin Location
              pin,  // Smart Board Login Pin
              admin__pin; // Administrator Pin
        //|------------------------------------------------------------------------->set number & button click event
        private void Number_1_Click(object sender, EventArgs e) => numpad.Text += 1;
        private void Number_2_Click(object sender, EventArgs e) => numpad.Text += 2;
        private void Number_3_Click(object sender, EventArgs e) => numpad.Text += 3;
        private void Number_4_Click(object sender, EventArgs e) => numpad.Text += 4;
        private void Number_5_Click(object sender, EventArgs e) => numpad.Text += 5;
        private void Number_6_Click(object sender, EventArgs e) => numpad.Text += 6;
        private void Number_7_Click(object sender, EventArgs e) => numpad.Text += 7;
        private void Number_8_Click(object sender, EventArgs e) => numpad.Text += 8;
        private void Number_9_Click(object sender, EventArgs e) => numpad.Text += 9;
        private void Number_0_Click(object sender, EventArgs e) => numpad.Text += 0;
        private void Btn_clear_Click(object sender, EventArgs e) => numpad.Clear();
        private void Btn_backspace_Click(object sender, EventArgs e) {   if ((String.Compare(numpad.Text, " ") < 0)) { numpad.Text = numpad.Text.Substring(0, numpad.Text.Length - 1 + 1); }else { numpad.Text = numpad.Text.Substring(0, numpad.Text.Length - 1); }}
        //|------------------------------------------------------------------------->set number & button click event
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(0, 0);
            this.Height = 478; // Form Height
            this.Width = 245; // Form Width
            this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width; // Screen Width
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height; // Screen Height
            downloadpin(); // Downloading  --> Syncing Pin
        }
        public void downloadpin()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed); // Download finish --> Syncing Pin 
            webClient.DownloadFileAsync(new Uri(http + url + pin_name), appPath + pin_name);  // --> https://example.com/pin.txt
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            StreamReader str = new StreamReader(pin_name);
            pin = str.ReadLine();
            str.Close();
        }
        private void Numpad_TextChanged(object sender, EventArgs e)
        {
            if (pin == numpad.Text)
            {
                loginsuccess();
            }

        }
        public void loginsuccess()
        {

        }
    }
}
