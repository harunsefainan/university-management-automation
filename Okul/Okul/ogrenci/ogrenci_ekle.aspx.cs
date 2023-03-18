using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.ogrenci
{
    public partial class ogrenci_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OkulTableAdapters.UniversiteTableAdapter univ = new OkulTableAdapters.UniversiteTableAdapter();
                universiteCombo.Items.Clear();
                universiteCombo.Items.Add(new ListItem("Üniversite Seçiniz...", ""));
                universiteCombo.AppendDataBoundItems = true;
                universiteCombo.DataSource = univ.UniversiteListesiGetir();
                universiteCombo.DataTextField = "Universite_id";
                universiteCombo.DataValueField = "ID";
                universiteCombo.DataBind();

                OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
                fakultecombo.Items.Clear();
                fakultecombo.Items.Add(new ListItem("Fakülte Seçiniz...", ""));
                fakultecombo.AppendDataBoundItems = true;
                fakultecombo.DataSource = fakulte.FakulteListesiGetir();
                fakultecombo.DataTextField = "Fakulte_ad";
                fakultecombo.DataValueField = "ID";
                fakultecombo.DataBind();

                OkulTableAdapters.BolumTableAdapter bolum = new OkulTableAdapters.BolumTableAdapter();
                bolumcombo.Items.Clear();
                bolumcombo.Items.Add(new ListItem("Bölüm Seçiniz...", ""));
                bolumcombo.AppendDataBoundItems = true;
                bolumcombo.DataSource = bolum.BolumListesiGetir();
                bolumcombo.DataTextField = "Bolum_ad";
                bolumcombo.DataValueField = "ID";
                bolumcombo.DataBind();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            OkulTableAdapters.UniversiteTableAdapter univ = new OkulTableAdapters.UniversiteTableAdapter();
            OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
            OkulTableAdapters.BolumTableAdapter bolum = new OkulTableAdapters.BolumTableAdapter();
            OkulTableAdapters.OgrenciTableAdapter ogr= new OkulTableAdapters.OgrenciTableAdapter();
            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int fakulteID = Convert.ToInt32(fakultecombo.SelectedItem.Value);
            int bolumID = Convert.ToInt32(bolumcombo.SelectedItem.Value);

            ogr.OgrenciEkle(txtOgrenciAdi.Text,universiteID,fakulteID,bolumID);
            Response.Redirect("/ogrenci/ogrenci_listesi.aspx");
        }
    }
}