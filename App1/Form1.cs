using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        string a;
        char d;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            textBox1.Text = "";
            d = '+';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            textBox1.Text = "";
            d = '-';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int p1 = int.Parse(a);
            int p2 = int.Parse(textBox1.Text);

            switch(d)
            {
                case '+':
                    textBox1.Text = (p1 + p2).ToString();
                    break;
                case '-':
                    textBox1.Text = (p1 - p2).ToString();
                    break;
            }
        }
    }
}
