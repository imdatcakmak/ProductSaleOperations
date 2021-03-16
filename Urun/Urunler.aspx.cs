using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            // var urunler = db.Tbl_Urunler.Where(x => x.DURUM == true).ToList();
            var urunler = (from x in db.Tbl_Urunler
                           where x.DURUM==true
                           select new
                           {
                               x.URUNID,
                               x.URUNAD,
                               x.URUNMARKA,
                               x.Tbl_Kategori.KATEGORIAD,
                               x.URUNFIYAT,
                               x.URUNSTOK

                           }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}