using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Okul.Model;
namespace Okul.bolum
{
    
    public partial class bolum_ekle : System.Web.UI.Page
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
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
                OkulTableAdapters.UniversiteTableAdapter univ = new OkulTableAdapters.UniversiteTableAdapter();
                OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
                OkulTableAdapters.BolumTableAdapter bolum = new OkulTableAdapters.BolumTableAdapter();
                int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
                int fakulteID = Convert.ToInt32(fakultecombo.SelectedItem.Value);
            
                bolum.BolumEkle(txtBolumAdi.Text, fakulteID,universiteID);
                Response.Redirect("/bolum/bolum_listesi.aspx");
        }

        
    }
}