using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urunler = db.Tbl_Urunler.Find(id);
            urunler.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}