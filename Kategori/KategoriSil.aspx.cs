using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteDb2Entities db = new SiteDb2Entities();
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var p = db.Tbl_Kategori.Find(id);
            db.Tbl_Kategori.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");

        }
    }
}