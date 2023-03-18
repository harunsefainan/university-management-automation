using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.fakulte
{
    public partial class fakulte_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OkulTableAdapters.FakulteTableAdapter fakulte =new OkulTableAdapters.FakulteTableAdapter();
                OkulTableAdapters.UniversiteTableAdapter univ= new OkulTableAdapters.UniversiteTableAdapter();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                int universiteID     = fakulte.FakulteGetir(id)[0].Universite_id;
                string fakulteAdi    = fakulte.FakulteGetir(id)[0].Fakulte_ad;
                string universiteAdi = univ.UniversiteGetir(universiteID)[0].Universite_id;
                txtFakulteAdi.Text = fakulteAdi;
                universiteCombo.Items.Clear();
                universiteCombo.DataSource = univ.UniversiteListesiGetir();
                universiteCombo.DataTextField = "Universite_id";
                universiteCombo.DataValueField = "ID";
                universiteCombo.DataBind();
                universiteCombo.SelectedIndex=universiteCombo.Items.IndexOf(universiteCombo.Items.FindByText(universiteAdi));
            }
        }
        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int universiteID=Convert.ToInt32(universiteCombo.SelectedItem.Value);
            fakulte.FakulteGuncelle(txtFakulteAdi.Text, universiteID, id);
            Response.Redirect("/fakulte/fakulte_listesi.aspx");
        }
    }
}