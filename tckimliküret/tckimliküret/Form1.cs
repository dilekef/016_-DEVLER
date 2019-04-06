using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tckimliküret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random salla = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int t = 0; t < 100; t++)
            {

                int[] a = new int[12];
                int kontrol;
                int kontrol1;
                string tc = "";
                a[1] = salla.Next(1, 10);
                tc = tc + a[1].ToString();
                for (int i = 2; i <= 11; i++)
                {
                    a[i] = salla.Next(0, 10);
                    tc = tc + a[i].ToString();
                }
                kontrol = a[10] = ((a[1] + a[3] + a[5] + a[7] + a[9]) * 7 - (a[2] + a[4] + a[6] + a[8])) % 10;
                kontrol1 = (a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]) % 10;
                if (kontrol == a[10] && kontrol1 == a[11])
                {
                    listBox1.Items.Add(tc);

                }

            }
        }
    }
}
    
