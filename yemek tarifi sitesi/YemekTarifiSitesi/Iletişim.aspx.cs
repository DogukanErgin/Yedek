using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YemekTarifiSitesi
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.Form["username"];
            Response.Write(value);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String deneme = " ";
            deneme = TextBox1.Text;
            TextBox1.Text = "";
            TextBox2.Text = "EFSANE YAKIŞIKLI KARİZMATİK BİR ADAM --------->>>>>"+ deneme;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Value == "1")
            {
                //Do something 
            }
            else
            {
                //Do something 
            }
        }
    }
}