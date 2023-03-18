using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.universite
{
    public partial class universite_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id =Convert.ToInt32(Request.QueryString["id"].ToString());
                OkulTableAdapters.UniversiteTableAdapter univ= new OkulTableAdapters.UniversiteTableAdapter();
                string universiteAdi = univ.UniversiteGetir(id)[0].Universite_id;
                txtUniversiteAdi.Text = universiteAdi;
            }
        }
        protected void btnDuzenle_Click(object sender,EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            OkulTableAdapters.UniversiteTableAdapter univ =new OkulTableAdapters.UniversiteTableAdapter();
            univ.UniversiteGuncelle(txtUniversiteAdi.Text, id);
            Response.Redirect("/universite/universite_listesi.aspx");
        }


    }
}