using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Powertimer_Tick(object sender, EventArgs e)
        {
           int sayi = Convert.ToInt32(10);

             sayi--; //timer her saniyede sayıyı 1 azaltacak
            this.Text = sayi.ToString() + " içerisinde kapatılacaktır";
           label3.Text = sayi.ToString();
        }
    }
}
