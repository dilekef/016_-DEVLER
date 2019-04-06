using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üstü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam;
        int sayi;
        int ust;
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + (3 * i + 4);
            }
            label1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 27; i++)
            {
                toplam = toplam + (7 * (i * i - 9)) / 12 + (9 * (i + 7)) / 5;
            }
            label1.Text = toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = 0;
            sayi = Convert.ToInt32(textBox1.Text);
            int mod;
            mod = sayi % 2;
            if (mod == 0)
            {
                sayi = sayi - 1;
            }
            ust = (sayi + 1) / 2;
            for (int i = 1; i <= ust; i++)
            {
                toplam = toplam + (2 * i - 1);
            }

           
            label1.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            toplam = 1;
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                toplam = toplam * Convert.ToInt32(textBox2.Text);
            }
            label1.Text = toplam.ToString();
        }
    }
}
