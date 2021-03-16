using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.KATEGORIAD = TextBox1.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}