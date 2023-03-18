using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.universite
{
    public partial class universite_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OkulTableAdapters.UniversiteTableAdapter univ =new OkulTableAdapters.UniversiteTableAdapter();
            universiteList.DataSource=univ.UniversiteListesiGetir();
            universiteList.DataBind();
        }
    }
}