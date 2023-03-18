using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.ogrenci
{
    public partial class ogrenci_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OkulTableAdapters.OgrenciTableAdapter ogr = new OkulTableAdapters.OgrenciTableAdapter();
            FakulteList.DataSource = ogr.OgrenciListesiGetir();
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

        public string bolumAdiGetir(int bolum_id)
        {
            OkulTableAdapters.BolumTableAdapter bolum = new OkulTableAdapters.BolumTableAdapter();
            string bolumAdi = "";

            try
            {
                bolumAdi = bolum.BolumGetir(bolum_id)[0].Bolum_Ad;
            }
            catch (Exception)
            {
                bolumAdi = "Bölüm Kayıtlardan Silinmiş!!!";

            }
            return bolumAdi;
        }
    }
}