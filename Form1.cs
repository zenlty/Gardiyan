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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //set number & button click event
        private void Number_1_Click(object sender, EventArgs e)
        {
            numpad.Text += 1;
        }
        private void Number_2_Click(object sender, EventArgs e)
        {
            numpad.Text += 2;
        }
        private void Number_3_Click(object sender, EventArgs e)
        {
            numpad.Text += 3;
        }
        private void Number_4_Click(object sender, EventArgs e)
        {
            numpad.Text += 4;
        }
        private void Number_5_Click(object sender, EventArgs e)
        {
            numpad.Text += 5;
        }
        private void Number_6_Click(object sender, EventArgs e)
        {
            numpad.Text += 6;
        }
        private void Number_7_Click(object sender, EventArgs e)
        {
            numpad.Text += 7;
        }
        private void Number_8_Click(object sender, EventArgs e)
        {
            numpad.Text += 8;
        }
        private void Number_9_Click(object sender, EventArgs e)
        {
            numpad.Text += 9;
        }
        private void Number_0_Click(object sender, EventArgs e)
        {
            numpad.Text += 0;
        }
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            numpad.Clear();
        }
        private void Btn_backspace_Click(object sender, EventArgs e)
        {
            if ((String.Compare(numpad.Text, " ") < 0))
            {
                numpad.Text = numpad.Text.Substring(0, numpad.Text.Length - 1 + 1);
            }
            else
            {
                numpad.Text = numpad.Text.Substring(0, numpad.Text.Length - 1);
            }
        }
        //set number & button click event

    }
}
