using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar= 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, su, cay, misir;
            misir = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            cay = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            kasatutar = kasatutar + misir * 4 + su + cay * 2 + bilet * 8;
            label9.Text= "Toplam:  " + kasatutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasatutar = 0;
            label9.Text = "Toplam:  " + kasatutar.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
