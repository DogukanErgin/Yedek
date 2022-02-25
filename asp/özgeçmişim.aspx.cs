using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class özgeçmişim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x= 0;
            if (CheckBox1.Checked == true)
            {
                x = x + 100;
            }
           else if (CheckBox2.Checked == true)
            {
                x = x + 90;

            }
            TextBox1.Text = x.ToString();
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}