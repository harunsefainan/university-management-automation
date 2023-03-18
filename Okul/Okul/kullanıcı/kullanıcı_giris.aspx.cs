using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Okul.Model;
using System.Data.SqlClient;


namespace Okul.kullanıcı
{
    public partial class kullanıcı_giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        OkulOtomasyonuEntities1 db = new OkulOtomasyonuEntities1();
        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var model= db.tblKullanici.FirstOrDefault(x=>x.Kadi==txtKadi.Text&& x.Sifre==txtSifre.Text);
            if (txtKadi.Text == "" && txtSifre.Text == "")
            {
                Response.Write("<script language='javascript'>alert('Kullanıcı Adı veya Parola giriniz');</script>");
            }
            else if (model != null)
            {
                Response.Redirect("/universite/universite_listesi.aspx");
            }
            else if(model == null)
            {
                Response.Write("<script language='javascript'>alert('Kullanıcı Adı veya Parola yanlış');</script>");
            }
        }
        protected void btnKayıt_Click(object sender, EventArgs e)
        {
            Response.Redirect("/kullanıcı/kullanıcı_ekle.aspx");
        }
    }
}