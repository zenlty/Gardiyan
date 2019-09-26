using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DERIN
{
    public partial class powerform : Form
    {
        public powerform()
        {
            InitializeComponent();
        }
        int sayac;
            private void Powertimer_Tick(object sender, EventArgs e)
        {
                sayac--;
                sure.Text = sayac.ToString();
            this.Text = sayac.ToString();
                if (sayac == 0)
                {
                    powertimer.Stop();
                    sayac = 100;
                    button1.PerformClick();
                }
            }

        private void Powerform_Load(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Yönetici tarafından akıllı tahta kapatma talimatı verilmiştir. 15 saniye içerisinde iptal etmediğiniz takdirde akıllı tahta kapanacaktır.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            powertimer.Enabled = true;
            sayac = 10;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            poweroff();

        }
        private void poweroff()
        {

            try
            {
                StreamReader str = new StreamReader("name.txt");
                string tahtaadi = str.ReadLine();
                str.Close();
                string uri = "ftp://" + Form1.url + "public_html/" + Form1.board_name + ".txt";
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                reqFTP.Credentials = new NetworkCredential(Form1.ftp_user, Form1.ftp_pass);
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
                MessageBox.Show("Lütfen Bilişim Teknolojileri Formatör Öğretmeni ile irtibata geçip hata kodunu bildiriniz. Bu hata akıllı tahtanın kapanmasına engel olabilecek düzeyde kritiktir.", "Hata Kodu : 100 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            powertimer.Enabled = false;
            this.Hide();
        }
    }
}
