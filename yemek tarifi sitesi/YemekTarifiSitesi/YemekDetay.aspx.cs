using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace YemekTarifiSitesi
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        sqlsinif connection = new sqlsinif();
        string yemekid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            yemekid = Request.QueryString["yemekid"];//bu sayfaya taşımış olduğum değer ?den sonra yazdığımızla aynı olmalı
            SqlCommand komut = new SqlCommand("Select YemekAd From tbl_Yemekler where yemekid=@p1", connection.baglantimetod());
            komut.Parameters.AddWithValue("@p1", yemekid);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read()) 
            {
                Label1.Text = dr[0].ToString();
            }
            connection.baglantimetod().Close();
            //yorumları listeleme
            SqlCommand komut2 = new SqlCommand("Select*From Tbl_Yorumlar where yemekid=@p2", connection.baglantimetod());
            komut2.Parameters.AddWithValue("@p2", yemekid);
            SqlDataReader dr2 = komut2.ExecuteReader();
            DataList1.DataSource = dr2;
            DataList1.DataBind();

        }
    }
}