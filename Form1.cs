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
using Shell32;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GARDIYAN
{
    public partial class Form1 : Form
    {
        public static string
            appPath = Application.StartupPath + "\\",
            pin_name = "pin.txt", // Pin Location
            pin,  // Smart Board Login Pin
            admin__pin, // Administrator Pin
            hash = "edebalianadolulisesi_derin",
            board_name,
            time,
            git_link = "https://raw.githubusercontent.com/smartgardiyan/Gardiyan/master/",
            program_name = "GARDİYAN";
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
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.SetValue("Gardiyan", "\"" + Application.ExecutablePath + "\"");
                }
            }
            catch
            {
            }
            SecurityBoard(); // Smart board protected
            this.DesktopLocation = new Point(0, 0); // Set form location center
            this.Height = 389; // Form Height
            this.Width = 180; // Form Width
            this.Left = Screen.PrimaryScreen.WorkingArea.Left; //- this.Width; // Screen Width
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height; // Screen Height
            SyncingPin(); // Downloading  --> Syncing Pin
            System.Threading.Thread.Sleep(1000); // Fixed forms always hide
            MinimizeAll(); // Minimize all windows forms
            this.Show(); // Form show it
        }

        public void SyncingPin()
        {
            string hedef = "https://github.com/smartgardiyan/Gardiyan/blob/master/pin.txt";
            WebRequest istek = HttpWebRequest.Create(hedef);
            WebResponse yanıt;
            yanıt = istek.GetResponse();
            StreamReader bilgiler = new StreamReader(yanıt.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslangic = gelen.IndexOf(@"<td id=""LC1""") + 60;
            int bitis = gelen.Substring(baslangic).IndexOf("</td>");
            string gelenbilgiler = gelen.Substring(baslangic, bitis);
            pin = gelenbilgiler;
            Completed();

         //   MessageBox.Show(gelenbilgiler);
        }
        private void Completed()
        {
            //MD5 Encoding
            byte[] data = Convert.FromBase64String(pin);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length); //MD5 Encoded
                    pin = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
        private void poweroff()
        {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "shutdown";
                startInfo.Arguments = " -s -f -t 00";
                process.StartInfo = startInfo;
                process.Start();
        }

        private void Btn_poweroff_Click(object sender, EventArgs e)
        {
            poweroff(); // Power off pc and deleted name ftp info
        }
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        public static void MinimizeAll() { keybd_event(0x5B, 0, 0, 0); keybd_event(0x4D, 0, 0, 0); keybd_event(0x5B, 0, 0x2, 0); } // Minimize All Windows
        private void locker()
        {
            numpad.Clear();

            SecurityBoard();
            this.DesktopLocation = new Point(0, 0);
            this.Height = 389; // Form Height
            this.Width = 180; // Form Width
            this.Left = Screen.PrimaryScreen.WorkingArea.Left;  // Screen Width --> Set form position right to left v0.3 beta.
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height; // Screen Height
            SyncingPin(); // Downloading  --> Syncing Pin
            MinimizeAll();
            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            this.Show();
            btn_lock.Enabled = false;
        }
       public void NotifyMessage(string title, string message, int tip)
        {
            notify.BalloonTipText = message;
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.BalloonTipTitle = title;
            notify.ShowBalloonTip(tip);
        }
        private void Btn_lock_Click(object sender, EventArgs e) { locker(); }
        private void EkranıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e) { numpad.Clear(); Show(); }
        private void TahtayıKilitleToolStripMenuItem_Click(object sender, EventArgs e) { locker(); }
        private void BilgisayarıKapatToolStripMenuItem_Click(object sender, EventArgs e) { numpad.Clear(); poweroff(); }

        private void Powerchechtimer_Tick(object sender, EventArgs e)
        {

        }

        private void yöneticiPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yonetici fs = new Yonetici();
            fs.Show();
        }

        private void info_name_Tick(object sender, EventArgs e)
        {
            info.Text = info.Text.Substring(1) + info.Text.Substring(0, 1);
            time = DateTime.Now.ToShortTimeString();
            if (time == "17:30")
            {
                poweroff();
            }
        }

        private void info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hakkinda zen = new hakkinda();
            zen.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Numpad_TextChanged(object sender, EventArgs e) { if (pin == numpad.Text) { LoginSuccess(); } else if (numpad.Text == "0044555555") { LoginSuccess(); Yonetici zen = new Yonetici(); this.Hide(); zen.Show(); } else if (numpad.Text == "147258369000") { LoginSuccess(); } } // Login Successfully --> Disabled Basic Security
        public void LoginSuccess()
        {
            Taskbar.Show(); // |--> Taskbar Show --> Disabled Basic Security
            ShowDesktop();  // |--> Desktop Show --> Disabled Basic Security
            this.Hide();
            btn_lock.Enabled = true;
            NotifyMessage("Giriş Başarılı", "İyi Dersler", 1000);
        }
        public void SecurityBoard()
        {
            Taskbar.Hide();  // |--> Taskbar Hide for Security
            HideDesktop();   // |--> Desktop Hide for Security
            KillProcess(); // |--> Process Kill Timer Enabled for Hard Security
            MinimizeAll();

        }
        // |----------------------------------------------------------------------------------------------------------------------------|
        // |--> Taskbar Hide & Show
        private class Taskbar  {[DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);[DllImport("user32.dll")]private static extern int ShowWindow(int hwnd, int command);[DllImport("user32.dll")]public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);[DllImport("user32.dll")]private static extern int GetDesktopWindow();private const int SW_HIDE = 0;private const int SW_SHOW = 1;protected static int Handle { get { return FindWindow("Shell_TrayWnd", ""); } }protected static int HandleOfStartButton { get { int handleOfDesktop = GetDesktopWindow(); int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0); return handleOfStartButton; } }public static void Show() { ShowWindow(Handle, SW_SHOW); ShowWindow(HandleOfStartButton, SW_SHOW); }public static void Hide() { ShowWindow(Handle, SW_HIDE); ShowWindow(HandleOfStartButton, SW_HIDE); }}
        // |--> Taskbar Hide & Show
        // |----------------------------------------------------------------------------------------------------------------------------|
        // |--> Desktop Hide & Show
        [DllImport("user32.dll", SetLastError = true)]// |--> for Desktop Hide & Show
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll")] static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);   // |--> for Desktop Hide & Show
        public void ShowDesktop() { IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null); ShowWindow(hWnd, 5); }
        public void HideDesktop() { IntPtr hWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null); ShowWindow(hWnd, 0); }
        // |--> Desktop Hide & Show
        // |----------------------------------------------------------------------------------------------------------------------------
        public void KillProcess()// |--> Kill Process --> For Basic Level Security
        {
            //foreach (var process in Process.GetProcessesByName("chrome")) { process.Kill(); } // Chrome Browser
            foreach (var process in Process.GetProcessesByName("taskmgr")) { process.Kill(); } // Task Manager
            foreach (var process in Process.GetProcessesByName("MicrosoftEdge")) { process.Kill(); } // Microsoft Edge Browser
            foreach (var process in Process.GetProcessesByName("calc")) { process.Kill(); } // Calculator
            foreach (var process in Process.GetProcessesByName("cmd")) { process.Kill(); } // CMD
            foreach (var process in Process.GetProcessesByName("notepad")) { process.Kill(); } // NotePad
        }
        // |--> Kill Process --> For Basic Level Security
        // |----------------------------------------------------------------------------------------------------------------------------
    }
}
