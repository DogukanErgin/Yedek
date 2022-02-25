using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace güncelvericekme
{
    class sqlsinif
    {
        public SqlConnection baglantimetod()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7S1L2OC\\SQLEXPRESS;Initial Catalog=Dbo_Rig;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
