using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String a;
            a = TextBox1.Text;
            Label1.Text = "başarılı tıklama  "+  " " + a + " " +"aferin lan" ;

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x;
            int y = 0;
            TextBox2.Text=y.ToString();
            
            Label2.Text = "Secilen kitaplar"+"</br>";
            for (x = 0; x <= 1; x++)
            

                if (CheckBoxList1.Items[x].Selected)
                {
                    Label2.Text += Convert.ToString(CheckBoxList1.Items[x].Text) + ":" + "<b>" + CheckBoxList1.Items[x].Value + "</b>" + "₺" + "</br>";
                    TextBox2.Text = (Convert.ToString(Convert.ToDecimal(TextBox2.Text)) + (Convert.ToDecimal(CheckBoxList1.Items[x].Value)));

                }

                TextBox2.Text += "₺";

            

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}