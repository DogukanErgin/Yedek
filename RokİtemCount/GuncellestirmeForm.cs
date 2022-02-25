using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RokİtemCount
{
    public partial class GuncellestirmeForm : Form
    {
        public Form1 frm1;
        public string itemname;
        public int itemsayisi,kullanıcıID,iteminsüresi;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7S1L2OC\\SQLEXPRESS; Initial Catalog = veritabanideneme2; Integrated Security = True");
        public GuncellestirmeForm()
        {
            InitializeComponent();
        }

        private void GuncellestirmeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = itemname;
            textBox2.Text = itemsayisi.ToString();
            textBox3.Text = iteminsüresi.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update Rokitemler SET iteminsüresi=@tps Where ID=@id", baglanti);
            baglanti.Open();
            if (kullanıcıID == 1)
            {
                textBox3.Text = (5*Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 2)
            {
                textBox3.Text = (10 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 3)
            {
                textBox3.Text = (15 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 4)
            {
                textBox3.Text = (30 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 5)
            {
                textBox3.Text = (60 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 6)
            {
                textBox3.Text = (480 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 39)
            {
                textBox3.Text = (1 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 9)
            {
                textBox3.Text = (5 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 10)
            {
                textBox3.Text = (10 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 11)
            {
                textBox3.Text = (30 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 12)
            {
                textBox3.Text = (60 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 13)
            {
                textBox3.Text = (480 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 14)
            {
                textBox3.Text = (1 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 15)
            {
                textBox3.Text = (5 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 16)
            {
                textBox3.Text = (10 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 17)
            {
                textBox3.Text = (15 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 18)
            {
                textBox3.Text = (30 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 19)
            {
                textBox3.Text = (60 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 20)
            {
                textBox3.Text = (180 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 21)
            {
                textBox3.Text = (480 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 22)
            {
                textBox3.Text = (5 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 23)
            {
                textBox3.Text = (10 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 24)
            {
                textBox3.Text = (15 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 25)
            {
                textBox3.Text = (30 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 26)
            {
                textBox3.Text = (60 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 27)
            {
                textBox3.Text = (1 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 28)
            {
                textBox3.Text = (3 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 29)
            {
                textBox3.Text = (5 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 30)
            {
                textBox3.Text = (10 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 31)
            {
                textBox3.Text = (15 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 32)
            {
                textBox3.Text = (30 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 33)
            {
                textBox3.Text = (60 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 34)
            {
                textBox3.Text = (180 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 35)
            {
                textBox3.Text = (480 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 36)
            {
                textBox3.Text = (900 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 37)
            {
                textBox3.Text = (1440 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 38)
            {
                textBox3.Text = (10080 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 40)
            {
                textBox3.Text = (50 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 41)
            {
                textBox3.Text = (100 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 42)
            {
                textBox3.Text = (500 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 43)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 44)
            {
                textBox3.Text = (100 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 45)
            {
                textBox3.Text = (500 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 46)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 47)
            {
                textBox3.Text = (5000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 48)
            {
                textBox3.Text = (10000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 49)
            {
                textBox3.Text = (20000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 62)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 63)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
          
            if (kullanıcıID == 64)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 65)
            {
                textBox3.Text = (10000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 66)
            {
                textBox3.Text = (10000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 67)
            {
                textBox3.Text = (50000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 68)
            {
                textBox3.Text = (150000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 69)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 70)
            {
                textBox3.Text = (10000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 71)
            {
                textBox3.Text = (50000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 72)
            {
                textBox3.Text = (150000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 73)
            {
                textBox3.Text = (500000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 74)
            {
                textBox3.Text = (1500000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 75)
            {
                textBox3.Text = (1000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 76)
            {
                textBox3.Text = (10000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 77)
            {
                textBox3.Text = (50000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 78)
            {
                textBox3.Text = (150000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 79)
            {
                textBox3.Text = (500000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 80)
            {
                textBox3.Text = (1500000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 81)
            {
                textBox3.Text = (750 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 82)
            {
                textBox3.Text = (7500 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 83)
            {
                textBox3.Text = (37500 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 84)
            {
                textBox3.Text = (112500 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 85)
            {
                textBox3.Text = (375000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 86)
            {
                textBox3.Text = (1125000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 87)
            {
                textBox3.Text = (500 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 88)
            {
                textBox3.Text = (3000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 89)
            {
                textBox3.Text = (15000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 90)
            {
                textBox3.Text = (50000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            if (kullanıcıID == 91)
            {
                textBox3.Text = (200000 * Convert.ToInt32(textBox2.Text)).ToString();

            }
            kmt.Parameters.AddWithValue("@tps", textBox3.Text);
            baglanti.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update Rokitemler SET itemname=@itemismi,itemsayisi=@adet,iteminsüresi=@tps Where ID=@id",baglanti);
            baglanti.Open();
            kmt.Parameters.AddWithValue("@itemismi", textBox1.Text);
            kmt.Parameters.AddWithValue("@adet", textBox2.Text);
            kmt.Parameters.AddWithValue("@tps", textBox3.Text);
            kmt.Parameters.AddWithValue("@id", kullanıcıID);
            int sonuc = kmt.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
            {

                DialogResult = DialogResult.Yes;
            }
        }
    }
}
