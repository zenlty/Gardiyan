using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace GARDIYAN
{
    public partial class Yonetici : Form
    {
        bool exitprogram = false;
        public Yonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey rkey1 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies", true);
            rkey1.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
            rkey1.Close();
            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            rkey2.SetValue("DisableTaskMgr", 0);
            rkey2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteProgram();
        }
        void deleteProgram()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo process_info = new ProcessStartInfo("cmd.exe", "/C del \"" + Application.ExecutablePath + "\"");
                process_info.CreateNoWindow = true;
                process_info.UseShellExecute = false;
                process = Process.Start(process_info);
                process.Close();
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(Form1.program_name);
            }
            catch 
            {
                Process.Start(new ProcessStartInfo()
                {
                    Arguments = "/C del \"" + Application.ExecutablePath + "\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe"
                });
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "441108")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 zen = new Form1();
            zen.Show();
            

        }

        private void Yonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitprogram==false)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Application.Exit();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/zenlty");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exitprogram = true;
            Application.Exit();
        }

        private void nyX_Theme1_Click(object sender, EventArgs e)
        {

        }
    }
}
