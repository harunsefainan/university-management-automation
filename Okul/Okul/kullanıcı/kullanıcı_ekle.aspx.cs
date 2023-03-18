using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Okul.kullanıcı
{
    public partial class kullanıcı_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnKayıt_Click(object sender, EventArgs e)
        {
            OkulTableAdapters.tblKullaniciTableAdapter kullanıcı = new OkulTableAdapters.tblKullaniciTableAdapter();
            if (txtKadi.Text == "" && txtSoyadi.Text == ""&& txtEposta.Text == ""&& txtAdi.Text == "" && txtSifre.Text == "")
            {
                Response.Redirect("/kullanıcı/kullanıcı_ekle.aspx");              
            }
            else
            {          
                kullanıcı.KullanıcıEkle(txtKadi.Text, txtAdi.Text, txtSoyadi.Text, txtEposta.Text, txtSifre.Text);
                Response.Redirect("/kullanıcı/kullanıcı_giris.aspx");
                Response.Write("<script language='javascript'>alert('Kaydınız yapıldı');</script>");
            }
        }
        protected void btnIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("/kullanıcı/kullanıcı_giris.aspx");
        }
    }
}