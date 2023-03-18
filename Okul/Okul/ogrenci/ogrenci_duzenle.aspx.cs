using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.ogrenci
{
    public partial class ogrenci_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OkulTableAdapters.BolumTableAdapter bolum = new OkulTableAdapters.BolumTableAdapter();
                OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
                OkulTableAdapters.UniversiteTableAdapter univ = new OkulTableAdapters.UniversiteTableAdapter();
                OkulTableAdapters.OgrenciTableAdapter ogr= new OkulTableAdapters.OgrenciTableAdapter();

                int id = Convert.ToInt32(Request.QueryString["id"]);

                int universiteID = ogr.OgrenciGetir(id)[0].Universite_id;
                string universiteAdi = univ.UniversiteGetir(universiteID)[0].Universite_id;

                int fakulteID = ogr.OgrenciGetir(id)[0].Fakulte_id;
                string fakulteAdi = fakulte.FakulteGetir(fakulteID)[0].Fakulte_ad;

                int bolumID = ogr.OgrenciGetir(id)[0].Bolum_id;
                string bolumAdi = bolum.BolumGetir(bolumID)[0].Bolum_Ad;


                string ogrAd = ogr.OgrenciGetir(id)[0].Ogr_Ad;

                txtOgrenciAdi.Text = ogrAd;

                universiteCombo.Items.Clear();
                universiteCombo.DataSource = univ.UniversiteListesiGetir();
                universiteCombo.DataTextField = "Universite_id";
                universiteCombo.DataValueField = "ID";
                universiteCombo.DataBind();
                universiteCombo.SelectedIndex = universiteCombo.Items.IndexOf(universiteCombo.Items.FindByText(universiteAdi));

                fakultecombo.Items.Clear();
                fakultecombo.DataSource = fakulte.FakulteListesiGetir();
                fakultecombo.DataTextField = "Fakulte_Ad";
                fakultecombo.DataValueField = "ID";
                fakultecombo.DataBind();
                fakultecombo.SelectedIndex = fakultecombo.Items.IndexOf(fakultecombo.Items.FindByText(fakulteAdi));

                bolumCombo.Items.Clear();
                bolumCombo.DataSource = bolum.BolumListesiGetir();
                bolumCombo.DataTextField = "Bolum_Ad";
                bolumCombo.DataValueField = "ID";
                bolumCombo.DataBind();
                bolumCombo.SelectedIndex = bolumCombo.Items.IndexOf(bolumCombo.Items.FindByText(bolumAdi));
            }
        }
        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            OkulTableAdapters.OgrenciTableAdapter ogr = new OkulTableAdapters.OgrenciTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int fakulteID = Convert.ToInt32(fakultecombo.SelectedItem.Value);
            int bolumID= Convert.ToInt32(bolumCombo.SelectedItem.Value);
            ogr.OgrenciGuncelle(txtOgrenciAdi.Text,universiteID,fakulteID,bolumID,id);
            Response.Redirect("/ogrenci/ogrenci_listesi.aspx");
        }
    }
}