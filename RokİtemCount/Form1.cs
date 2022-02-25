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
    public partial class Form1 : Form
    {
        public GuncellestirmeForm gform = new GuncellestirmeForm();
        public Form1()
        {
            InitializeComponent();
            gform.frm1 = this;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7S1L2OC\\SQLEXPRESS; Initial Catalog = veritabanideneme2; Integrated Security = True");
        private void Form1_Load(object sender, EventArgs e)
        {
            tabloyenile();    
        }
        void tabloyenile()
        {
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Rokitemler", baglanti);
        DataTable tablo = new DataTable();
        adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                    count += (int)(dataGridView1.SelectedRows[i].Cells["iteminsüresi"].Value);
               
                }
            
                int atama;


            atama= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            
            textBox3.Text = atama.ToString();
            textBox4.Text = count.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Rokitemler(itemname,itemsayisi,iteminsüresi) VALUES(@ismi,@adet,@tps)",baglanti);
            komut.Parameters.AddWithValue("@ismi", textBox1.Text);
            komut.Parameters.AddWithValue("@adet", textBox2.Text);
            komut.Parameters.AddWithValue("tps", textBox3.Text);
            baglanti.Open();
            int sonuc =komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("kayıt basarılı");
                baglanti.Close();
                tabloyenile();
            }
            else
                MessageBox.Show("kayıt basarısız");
            baglanti.Close();

        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Rokitemler WHERE ID=@idparameter", baglanti);
            baglanti.Open();
            komut2.Parameters.AddWithValue("@idparameter",dataGridView1.SelectedRows[0].Cells["ID"].Value);
            int sonuc = komut2.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("silme başarılı");
                baglanti.Close();
                tabloyenile();
            }
            else
                
                MessageBox.Show("silme başarısız");
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gform.itemname = dataGridView1.SelectedRows[0].Cells["itemname"].Value.ToString();
            gform.itemsayisi = (int)dataGridView1.SelectedRows[0].Cells["itemsayisi"].Value;
            gform.iteminsüresi= (int)dataGridView1.SelectedRows[0].Cells["iteminsüresi"].Value;
            gform.kullanıcıID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            DialogResult cevap= gform.ShowDialog();
if(cevap==DialogResult.Yes)
            {
            //    MessageBox.Show(this, "Güncelleme başarılı", "Tebrikler");
                tabloyenile();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
