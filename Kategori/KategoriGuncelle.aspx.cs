using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                Txtid.Text = id.ToString();
            var ktgr = db.Tbl_Kategori.Find(id);
            TxtAd.Text = ktgr.KATEGORIAD;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.Tbl_Kategori.Find(id);
            ktgr.KATEGORIAD = TxtAd.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}