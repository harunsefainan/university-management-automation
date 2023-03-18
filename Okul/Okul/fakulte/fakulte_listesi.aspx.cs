using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul.fakulte
{
    public partial class fakulte_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OkulTableAdapters.FakulteTableAdapter  fakulte = new OkulTableAdapters.FakulteTableAdapter();
            fakulteList.DataSource = fakulte.FakulteListesiGetir();
            fakulteList.DataBind();
        }

        public string universiteAdiGetir(int Universite_id)
        {
            OkulTableAdapters.UniversiteTableAdapter univ= new OkulTableAdapters.UniversiteTableAdapter();
            string universiteAdi = "";

            try
            {
                universiteAdi=univ.UniversiteGetir(Universite_id)[0].Universite_id;
            }
            catch (Exception)
            {

                universiteAdi = "Üniversite Kayıtlardan Silinmiş!!!";
            }
            return universiteAdi;
        }
    }
}