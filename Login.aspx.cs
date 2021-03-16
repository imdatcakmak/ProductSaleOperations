using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2
{
    public partial class Login : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_Admin where x.KULLANICI == TxtKullaniciad.Text && x.SIFRE == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("/Kategori/Kategoriler.aspx");
            }
            else
            {
                Response.Write("Hatalı giriş...!");
            }
        }
    }
}