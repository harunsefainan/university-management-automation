using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.fakulte
{
    public partial class fakulte_ekle : System.Web.UI.Page
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
            }     
        }   
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            OkulTableAdapters.FakulteTableAdapter fakulte= new OkulTableAdapters.FakulteTableAdapter();

            int universiteID= Convert.ToInt32(universiteCombo.SelectedItem.Value);
            fakulte.FakulteEkle(txtFakulteAdi.Text, universiteID);
            Response.Redirect("/fakulte/fakulte_listesi.aspx");
        }
    }
}