using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.bolum
{
    public partial class bolum_guncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OkulTableAdapters.BolumTableAdapter bolum= new OkulTableAdapters.BolumTableAdapter();
                OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
                OkulTableAdapters.UniversiteTableAdapter univ = new OkulTableAdapters.UniversiteTableAdapter();

                int id=Convert.ToInt32(Request.QueryString["id"]);

                int universiteID = bolum.BolumGetir(id)[0].Universite_id;
                string universiteAdi = univ.UniversiteGetir(universiteID)[0].Universite_id;

                int fakulteID = bolum.BolumGetir(id)[0].Fakulte_id;
                string fakulteAdi = fakulte.FakulteGetir(fakulteID)[0].Fakulte_ad;

                string bolumAdi = bolum.BolumGetir(id)[0].Bolum_Ad;

                txtBolumAdi.Text = bolumAdi;

                universiteCombo.Items.Clear();
                universiteCombo.DataSource = univ.UniversiteListesiGetir();
                universiteCombo.DataTextField = "Universite_id";
                universiteCombo.DataValueField = "ID";
                universiteCombo.DataBind();
                universiteCombo.SelectedIndex = universiteCombo.Items.IndexOf(universiteCombo.Items.FindByText(universiteAdi));

                fakultecombo.Items.Clear();
                fakultecombo.DataSource = fakulte.FakulteListesiGetir();
                fakultecombo.DataTextField = "Fakulte_Ad";
                fakultecombo.DataValueField= "ID";  
                fakultecombo.DataBind();
                fakultecombo.SelectedIndex = fakultecombo.Items.IndexOf(fakultecombo.Items.FindByText(fakulteAdi));
            }
        }
        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            OkulTableAdapters.BolumTableAdapter bolum= new OkulTableAdapters.BolumTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int fakulteID = Convert.ToInt32(fakultecombo.SelectedItem.Value);
            bolum.BolumGuncelle(txtBolumAdi.Text, fakulteID, universiteID, id);
            Response.Redirect("/bolum/bolum_listesi.aspx");

        }
    }
}