using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace YemekTarifiSitesi
{
    public class sqlsinif
    {
        public SqlConnection baglantimetod()
        {
            SqlConnection baglan = new SqlConnection("Data Source =DESKTOP-7S1L2OC\\SQLEXPRESS; Initial Catalog = Dbo_WebSite; Integrated Security = True");
            baglan.Open();
            return baglan;
         

        }
    }
}