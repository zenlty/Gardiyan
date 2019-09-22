using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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
        private void Btn_backspace_Click(object sender, EventArgs e) { if ((String.Compare(numpad.Text, " ") < 0)) { numpad.Text = numpad.Text.Substring(0, numpad.Text.Length - 1 + 1); } else { numpad.Text = numpad.Text.Substring(0, numpad.Text.Length - 1); } }
        //|------------------------------------------------------------------------->set number & button click event
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            securityboard();
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
            StreamReader str = new StreamReader(pin_name); //  |--> Set Downloaded Pin
            pin = str.ReadLine(); //  |--> Reading downloading pin
            str.Close(); // |--> Readed pin
        }
        private void Numpad_TextChanged(object sender, EventArgs e)
        {
            if (pin == numpad.Text)
            {
                LoginSuccess(); // Login Successfully --> Disabled Basic Security
            }

        }
        public void LoginSuccess()
        {
            Taskbar.Show(); // |--> Taskbar Show --> Disabled Basic Security
            ShowDesktop();  // |--> Desktop Show --> Disabled Basic Security
        }

        public void kill_process()
        {

            foreach (var process in Process.GetProcessesByName("explorer"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("taskmgr"))
            {
                process.Kill();
            }
        }
        public void securityboard()
        {
            Taskbar.Hide();  // |--> Taskbar Hide for Security
            HideDesktop();   // |--> Desktop Hide for Security
            kill_process(); // |--> Process Kill Timer Enabled for Hard Security
        }

        // |--> Taskbar Hide & Show
        private class Taskbar
        {
            [DllImport("user32.dll")]
            private static extern int FindWindow(string className, string windowText);
            [DllImport("user32.dll")]
            private static extern int ShowWindow(int hwnd, int command);
            [DllImport("user32.dll")]
            public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);
            [DllImport("user32.dll")]
            private static extern int GetDesktopWindow();
            private const int SW_HIDE = 0;
            private const int SW_SHOW = 1;
            protected static int Handle { get { return FindWindow("Shell_TrayWnd", ""); } }
            protected static int HandleOfStartButton { get { int handleOfDesktop = GetDesktopWindow(); int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0); return handleOfStartButton; } }
            public static void Show() { ShowWindow(Handle, SW_SHOW); ShowWindow(HandleOfStartButton, SW_SHOW); }
            public static void Hide() { ShowWindow(Handle, SW_HIDE); ShowWindow(HandleOfStartButton, SW_HIDE); }
        }
        // |--> Taskbar Hide & Show
        //----------------------------------------------------------------------------------------------------------------------------
        // |--> Desktop Hide & Show
        [DllImport("user32.dll", SetLastError = true)]// |--> for Desktop Hide & Show
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);   // |--> for Desktop Hide & Show
        public void ShowDesktop() { IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null); ShowWindow(hWnd, 5); }
        public void HideDesktop() { IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null); ShowWindow(hWnd, 0); }
        // |--> Desktop Hide & Show
        //----------------------------------------------------------------------------------------------------------------------------

    }
}
