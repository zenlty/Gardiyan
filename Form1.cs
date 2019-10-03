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

namespace DERIN
{
    public partial class Form1 : Form
    {
        public static string
              appPath = Application.StartupPath + "\\",
              http = "http://", //URL First address
              url = "zenlty.com.tr.ht/", //Web address
              pin_name = "pin.txt", // Pin Location
              pin,  // Smart Board Login Pin
              admin__pin, // Administrator Pin
              ftp_user = "school@zenlty.com.tr.ht",
              ftp_pass = "Kilavya59",
              hash = "edebalianadolulisesi_derin",
              board_name;
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
            SecurityBoard(); // Smart board protected
            this.DesktopLocation = new Point(0, 0); // Set form location center
            this.Height = 370; // Form Height
            this.Width = 180; // Form Width
            this.Left = Screen.PrimaryScreen.WorkingArea.Left; //- this.Width; // Screen Width
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height; // Screen Height
            SyncingPin(); // Downloading  --> Syncing Pin
            runningProgram(); // Upload FTP --> Board Name
            System.Threading.Thread.Sleep(1000); // Fixed forms always hide
            MinimizeAll(); // Minimize all windows forms
            this.Show(); // Form show it
        }

        public void SyncingPin()
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
        private void manuelpoweroff()
        {
            try
            {
                StreamReader str = new StreamReader("name.txt");
                string tahtaadi = str.ReadLine();
                str.Close();
                string uri = "ftp://" + url + "public_html/" + board_name + ".txt";
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                reqFTP.Credentials = new NetworkCredential(ftp_user, ftp_pass);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
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
            catch
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
            finally
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
        }
        public void runningProgram()
        {
            try
            {
                StreamReader str = new StreamReader("name.txt");
                board_name = str.ReadLine();
                str.Close();
                FileInfo FI = new FileInfo(appPath + "name.txt");
                string uri = "ftp://" + url + "public_html/" + board_name + ".txt";
                FtpWebRequest FTP;
                FTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                FTP.Credentials = new NetworkCredential(ftp_user, ftp_pass);
                FTP.KeepAlive = false;
                FTP.Method = WebRequestMethods.Ftp.UploadFile;
                FTP.UseBinary = true;
                FTP.ContentLength = FI.Length;
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;
                FileStream FS = FI.OpenRead();
                try
                {
                    Stream strm = FTP.GetRequestStream();
                    contentLen = FS.Read(buff, 0, buffLength);
                    while (contentLen != 0)
                    {
                        strm.Write(buff, 0, contentLen);
                        contentLen = FS.Read(buff, 0, buffLength);
                    }
                    strm.Close();
                    FS.Close();

                }
                catch
                {
                    MessageBox.Show("Lütfen Bilişim Teknolojileri Formatör Öğretmeni ile irtibata geçip hata kodunu bildiriniz. Bu hata akıllı tahtanın çalışmasına engel olabilecek düzeyde kritiktir.", "Hata Kodu : 101", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                try
                {
                    Random rnd = new Random();
                    int randomname = rnd.Next(170, 20000);
                    StreamWriter str = new StreamWriter("name.txt");
                    str.WriteLine("NO_NAME" + randomname.ToString());
                    str.Close();
                    runningProgram();
                }
                catch
                {
                    MessageBox.Show("Lütfen Bilişim Teknolojileri Formatör Öğretmeni ile irtibata geçip hata kodunu bildiriniz. Bu hata akıllı tahtanın çalışmasına engel olabilecek düzeyde kritiktir.", "Hata Kodu : 102", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void Btn_poweroff_Click(object sender, EventArgs e)
        {
            manuelpoweroff(); // Power off pc and deleted name ftp info
        }
        private void poweroff()
        {
            powerform str = new powerform();
            str.Show();
            powerchecktimer.Enabled = false;
            NotifyMessage("Önemli Bilgilendirme","Yönetici kontrolü devre dışı bırakılmıştır. Kullanım sonrası akıllı tahtayı kapatmayı unutmayınız",1000);


        }
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        public static void MinimizeAll() { keybd_event(0x5B, 0, 0, 0); keybd_event(0x4D, 0, 0, 0); keybd_event(0x5B, 0, 0x2, 0); } // Minimize All Windows
        private void locker()
        {
            numpad.Clear();

            SecurityBoard();
            this.DesktopLocation = new Point(0, 0);
            this.Height = 370; // Form Height
            this.Width = 180; // Form Width
            this.Left = Screen.PrimaryScreen.WorkingArea.Left;  // Screen Width --> Set form position right to left v0.3 beta.
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height; // Screen Height
            SyncingPin(); // Downloading  --> Syncing Pin
            runningProgram(); 
            this.TopMost = true;
            this.Focus();
            this.BringToFront();
            this.Show();
            btn_lock.Enabled = false;
        }
        private void powercheck()
        {
            string FTPDosyaYolu = "ftp://" + url + "public_html/" + board_name + ".txt";
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPDosyaYolu);
            string username = ftp_user;
            string password = ftp_pass;
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = true; // pasif olarak kullanabilme
            request.UseBinary = true; // aktarım binary ile olacak
            request.KeepAlive = false; // sürekli açık tutma

            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse(); // File found --> Smart board is on
            }
            catch
            {
                poweroff(); // File not found --> Smart board power off
            }
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
        private void BilgisayarıKapatToolStripMenuItem_Click(object sender, EventArgs e) { numpad.Clear(); manuelpoweroff(); }

        private void Powerchechtimer_Tick(object sender, EventArgs e)
        {
            powercheck();
        }

        private void Numpad_TextChanged(object sender, EventArgs e) { if (pin == numpad.Text) { LoginSuccess(); } } // Login Successfully --> Disabled Basic Security
        public void LoginSuccess()
        {
            Taskbar.Show(); // |--> Taskbar Show --> Disabled Basic Security
            ShowDesktop();  // |--> Desktop Show --> Disabled Basic Security
            this.Hide();
            btn_lock.Enabled = true;
            NotifyMessage("Bilgilendirme Metni", "GİRİŞ BAŞARILI , İYİ DERSLER", 1000);
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
            foreach (var process in Process.GetProcessesByName("chrome")) { process.Kill(); } // Chrome Browser
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
