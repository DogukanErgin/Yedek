using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class giris_sayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
        Response.Redirect("https://bethesda.net");
        }

        protected void XmlDataSource1_Transforming(object sender, EventArgs e)
        {

        }
    }
}