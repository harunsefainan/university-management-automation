using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.bolum
{
    public partial class bolum_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OkulTableAdapters.BolumTableAdapter bolum= new OkulTableAdapters.BolumTableAdapter();
            FakulteList.DataSource = bolum.BolumListesiGetir();
            FakulteList.DataBind();
        }
        public string universiteAdiGetir(int Universite_id)
        {
            OkulTableAdapters.UniversiteTableAdapter univ = new OkulTableAdapters.UniversiteTableAdapter();
            string universiteAdi = "";

            try
            {
                universiteAdi = univ.UniversiteGetir(Universite_id)[0].Universite_id;
            }
            catch (Exception)
            {

                universiteAdi = "Üniversite Kayıtlardan Silinmiş!!!";
            }
            return universiteAdi;
        }

        public string fakulteAdiGetir(int Fakulte_id)
        {
            OkulTableAdapters.FakulteTableAdapter fakulte = new OkulTableAdapters.FakulteTableAdapter();
            string fakulteAdi = "";

            try
            {
                fakulteAdi = fakulte.FakulteGetir(Fakulte_id)[0].Fakulte_ad;
            }
            catch (Exception)
            {
                fakulteAdi = "Fakülte Kayıtlardan Silinmiş!!!";

            }
            return fakulteAdi;
        }




    }
}