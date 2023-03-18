using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.ogrenci
{
    public partial class ogrenci_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            OkulTableAdapters.OgrenciTableAdapter ogr = new OkulTableAdapters.OgrenciTableAdapter();
            ogr.OgrenciSil(id);
            Response.Redirect("/ogrenci/ogrenci_listesi.aspx");
        }
    }
}