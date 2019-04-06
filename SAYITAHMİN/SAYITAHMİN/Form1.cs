using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAYITAHMİN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1;
        int sayı2;
        int sayı = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            sayı = 0;
            Random rnd = new Random();

            sayı1 = rnd.Next(1, 101);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayı = sayı + 1;

            sayı2 = Convert.ToInt32(textBox1.Text);
            if (sayı1 == sayı2)
            {
                MessageBox.Show("Doğru tahmin    " +sayı);
                sayı = 0;
            }
            else
            {

                if (sayı2 > sayı1)
                {
                    MessageBox.Show("Yanlış tahmin  Tuttuğunuz sayı random sayıdan büyüktür   " + sayı);
                }
                else
                {
                    MessageBox.Show("Yanlış tahmin  Tuttuğunuz sayı random sayıdan küçüktür   " + sayı);
                }
            }
            if (sayı > 2)
            {
                MessageBox.Show("Hakkınız bitmiştir");
                button2.Enabled = false;
            }
        }
    }
}
