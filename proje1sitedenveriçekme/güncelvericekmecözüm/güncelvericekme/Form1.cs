using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace güncelvericekme
{
    public partial class Form1 : Form
    {
        public String html;
        public Uri url;
        sqlsinif connection = new sqlsinif();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                        for (int a = 1; a < 10; a++)
                        {
                            VeriAl("https://www.tefas.gov.tr/FonAnaliz.aspx", "//*[@id='MainContent_PanelFundList']/ul/li[" + a + "]/a", listBox1);
                        }

                        for (int b = 1; b < 23; b++)
                        {
                        
                            VeriAlDip("https://www.tefas.gov.tr/FonAnaliz.aspx", "//*[@id='MainContent_PanelFundList']/ul/li[" + b + "]/a", "href", listBox2);

                        }
                        */


        }
        public void VeriAl(String Url, String XPath, ListBox CikanSonuc)

        {
            try
            {
                url = new Uri(Url);

            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            try
            {
                html = client.DownloadString(url);

            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                CikanSonuc.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);

            }
            catch (NullReferenceException)
            {


                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

        }
        public void VeriAlDip(String Url, String XPath, String dip, ListBox CikanSonuc)

        {
            try
            {
                url = new Uri(Url);

            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }

            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            try
            {
                html = client.DownloadString(url);

            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                CikanSonuc.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).Attributes[dip].Value);

            }
            catch (NullReferenceException)
            {


                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string metin = "https://www.tefas.gov.tr/FonAnaliz.aspx?FonKod=";
            string[] veriler2 = new string[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(i);
                listBox1.Items.Add(listBox2.Items[i]);
                veriler2[i] = metin + listBox2.Items[i].ToString();
                listBox3.Items.Add(veriler2[i]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {


                VeriAl(listBox3.Items[i].ToString(), "//*[@id='MainContent_PanelInfo']/div[2]/ul/li[1]/span", listBox4);
            }
            /*     Dictionary<string, int> hashmap = new Dictionary<string, int>();
                 int key = i;
                 hashmap.Add(listBox4.ToString(), key);
                 listBox4.Items.Add(i);
                 listBox5.Items.Add(hashmap); */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {

                VeriAl(listBox3.Items[i].ToString(), "//*[@id='MainContent_PanelInfo']/div[2]/ul/li[2]/span", listBox5);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {

                VeriAl(listBox3.Items[i].ToString(), "//*[@id='MainContent_PanelInfo']/div[1]/ul[1]/li[2]/span", listBox6);



            }/*
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
            

                if (listBox4.Items[i].ToString().Length >=5)
                {
                    listBox6.Items.Add(listBox4.Items[i]);
                }
            }
        */

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                x = listBox4.Items[i].ToString().Length;
                if (listBox4.Items[i] != null && listBox4.Items[i].ToString().Length > 2)
                {
                    listBox7.Items.Add(listBox4.Items[i].ToString().Substring(1, x - 1));

                }
            }
            /*
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                listBox7.Items.Add(i+1);
                listBox7.Items.Add(listBox4.Items[i]);
       
    }*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < listBox5.Items.Count; i++)

            {
                x = listBox5.Items[i].ToString().Length;
                if (listBox5.Items[i] != null && listBox5.Items[i].ToString().Length > 2)
                {

                    listBox8.Items.Add(listBox5.Items[i].ToString().Substring(1, x - 1));
                }
            }
            /*

        for (int i = 0; i < listBox4.Items.Count; i++)
        {
            listBox8.Items.Add(i+1);
            listBox8.Items.Add(listBox5.Items[i]);
        }*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < listBox6.Items.Count; i++)
            {
                x = listBox6.Items[i].ToString().Length;
                if (listBox6.Items[i] != null && listBox6.Items[i].ToString().Length > 2)
                {
                    listBox9.Items.Add(listBox6.Items[i].ToString().Substring(1, x - 1));
                }
                else
                {
                    listBox9.Items.Add(0);
                }
            }
            /*
             for (int i =0 ; i < listBox5.Items.Count; i++)
            {
                if (listBox5.Items[i].ToString().Length >= 5)
                {
                    listBox9.Items.Add(listBox5.Items[i]);
                }
                   }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)

        {
            int sayac = listBox7.Items.Count;
            int sayac2 = listBox8.Items.Count;

            if (sayac2 >= sayac)
            {

                for (int i = 0; i < sayac; i++)
                {




                    if (listBox7.Items[i] != null && listBox8.Items[i] != null && listBox9.Items[i] != null)
                    {
                        double temp = double.Parse(listBox7.Items[i].ToString());
                        double temp_2 = double.Parse(listBox8.Items[i].ToString());
                        double temp_3 = double.Parse(listBox9.Items[i].ToString());

                        if (temp > 5.0 && temp_2 < -3.0)
                        {

                            listBox11.Items.Add(i);

                            listBox11.Items.Add(listBox7.Items[i]);

                            listBox11.Items.Add(listBox8.Items[i]);

                            listBox11.Items.Add(listBox9.Items[i]);



                        }
                    }
                }

            }
            else
            {
                for (int i = 0; i < sayac2; i++)
                {


                    if (listBox7.Items[i] != null && listBox8.Items[i] != null && listBox9.Items[i] != null)
                    {
                        double temp = double.Parse(listBox7.Items[i].ToString());
                        double temp_2 = double.Parse(listBox8.Items[i].ToString());
                        double temp_3 = double.Parse(listBox9.Items[i].ToString());


                        if (temp > 1.0 && temp_2 < -1.0)
                        {

                            listBox11.Items.Add(i);
                            listBox11.Items.Add(listBox7.Items[i]);
                            listBox11.Items.Add(listBox8.Items[i]);
                            listBox11.Items.Add(listBox9.Items[i]);




                        }
                    }

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayac = listBox7.Items.Count;
            int sayac2 = listBox8.Items.Count;

            if (sayac2 >= sayac)
            {

                for (int i = 0; i < sayac; i++)
                {


                    // listBox10.Items.Add(i);



                    if (listBox8.Items[i] != null && listBox7.Items[i] != null && listBox9.Items[i] != null)
                    {
                        double temp = double.Parse(listBox7.Items[i].ToString());
                        double temp_2 = double.Parse(listBox8.Items[i].ToString());
                        double temp_3 = double.Parse(listBox9.Items[i].ToString());
                        if (temp > 5.0 && temp_2 > 1.0 && temp_3 > 0.1)
                        {
                            listBox10.Items.Add(i);
                            listBox10.Items.Add(listBox7.Items[i]);
                            listBox10.Items.Add(listBox8.Items[i]);

                            listBox10.Items.Add(listBox9.Items[i]);


                        }


                    }
                }

            }
            else
            {
                for (int i = 0; i < sayac2; i++)
                {
                    // listBox10.Items.Add(i);
                    if (listBox7.Items[i] != null && listBox8.Items[i] != null && listBox9.Items[i] != null)
                    {
                        double temp = double.Parse(listBox7.Items[i].ToString());
                        double temp_2 = double.Parse(listBox8.Items[i].ToString());
                        double temp_3 = double.Parse(listBox9.Items[i].ToString());

                        if (temp > 5.0 && temp_2 > 1.0 && temp_3 > 0.1)

                        {

                            listBox10.Items.Add(i);
                            listBox10.Items.Add(listBox7.Items[i]);
                            listBox10.Items.Add(listBox8.Items[i]);
                            listBox10.Items.Add(listBox9.Items[i]);



                        }
                    }
                }
            }

        }







        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                //*[@id='MainContent_PanelInfo']/div[1]/ul[1]/li[1]/span
                ////*[@id="highcharts-4"]/svg/g[1]/g[1]/path[7]
                VeriAl(listBox3.Items[i].ToString(), "//*[@id='MainContent_PanelInfo']/div[1]/ul[1]/li[1]/span", listBox12);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox12.Items.Count; i++)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_FonGünlükEkleme3 (Fondeger,Fonid) values (@t2,@t3)", connection.baglantimetod());

                komut.Parameters.AddWithValue("@t2", Convert.ToDouble(listBox12.Items[i]));
                komut.Parameters.AddWithValue("@t3", i + 1);
                komut.ExecuteNonQuery();

                connection.baglantimetod().Close();
                textBox1.Text = "tamam lan kaydoldu";




            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Fon1(Fonkod,Fondeger)values (@t1,@t2)", connection.baglantimetod());
                komut.Parameters.AddWithValue("@t1", Convert.ToString(listBox2.Items[i]));
                komut.Parameters.AddWithValue("@t2", Convert.ToDouble(listBox12.Items[i]));
                komut.ExecuteNonQuery();
                connection.baglantimetod().Close();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 206; i++)
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Fon1 set Bankaadı='Ziraat' ", connection.baglantimetod());

                komut.ExecuteNonQuery();
                connection.baglantimetod().Close();
                textBox1.Text = "tamam oldu";

            }
            /*  int i;
              for (i = 825; i <= 1030; i++) {

                  SqlCommand komut = new SqlCommand("Delete from Tbl_FonGünlükEkleme3 WHERE Fontarihid in ("+i+")",connection.baglantimetod());


                  komut.ExecuteNonQuery();
                  connection.baglantimetod().Close();


              }
              textBox1.Text = ("helal silindi");
            */
        }

        private void button15_Click(object sender, EventArgs e)
        {

            //for (int a = 1; a < 10; a++)
            //          {
            //              VeriAl("https://miningchamp.com/", "//*[@id='example1']/tbody/tr[a]/td[1]", listBox11);
            //          }

            for (int b = 1; b < 148; b++)
            {

                VeriAl("https://miningchamp.com", "//*[@id='example1']/tbody/tr[" + b + "]/td[1]", listBox12);

            }
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox12.Items.Count; i++)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_EkranKartıDeğerlendirme(kart_ismi,Elektrik_tüketimi)values (@t1,@t2)", connection.baglantimetod());
                komut.Parameters.AddWithValue("@t1", Convert.ToString(listBox12.Items[i]));
                komut.Parameters.AddWithValue("@t2", Convert.ToString(listBox11.Items[i]));

                komut.ExecuteNonQuery();
                connection.baglantimetod().Close();

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int b = 1; b < 148; b++)
            {

                VeriAl("https://miningchamp.com", "//*[@id='example1']/tbody/tr[" + b + "]/td[4]", listBox11);

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            for (int b = 1; b < 5; b++)
            {

                VeriAl("https://coinmarketcap.com/coins/?page=2", "//*[@id='__next']/div/div[2]/div/div/div[3]/table/tbody/tr[" + b + "]/td[3]/a/div/div/p", listBox12);

                VeriAlDip("https://coinmarketcap.com/coins/?page=2", "//*[@id='__next']/div/div[2]/div/div/div[3]/table/tbody/tr[1]/td[3]/a/div/div/p", "href", listBox12);
            }

        }
    }
}



