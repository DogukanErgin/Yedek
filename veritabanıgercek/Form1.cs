using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanıgercek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle (){
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, sonuc;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonuc = a * b;
            textBox3.Text = sonuc.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
