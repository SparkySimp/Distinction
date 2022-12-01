using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayıklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random prng1 = new Random();
            Random prng2 = new Random();
            int uretimSayisi = prng2.Next(10, 21);
            for (int i = 0; i < uretimSayisi; i++) listBox1.Items.Add(prng1.Next(50, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int number in listBox1.Items) { 
                if (number % 2 == 0) {
                    listBox2.Items.Add(number);
                } else {
                    listBox3.Items.Add(number);
                } 
            };
        }
    }
}
