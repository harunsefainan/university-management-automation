using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.bolum
{
    public partial class bolum_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            OkulTableAdapters.BolumTableAdapter bolum = new OkulTableAdapters.BolumTableAdapter();
            bolum.BolumSil(id);
            Response.Redirect("/bolum/bolum_listesi.aspx");
        }
    }
}