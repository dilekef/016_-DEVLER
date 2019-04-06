using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 int toplam;
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(listBox1.Items[i]);
                comboBox1.Items.Add(listBox1.Items[i]);

            }
            label1.Text = toplam.ToString();
          
        }
    }
}
