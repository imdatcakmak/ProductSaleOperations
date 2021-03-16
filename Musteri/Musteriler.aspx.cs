using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var musteriler = db.Tbl_Musteri.ToList();
            Repeater1.DataSource = musteriler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Musteri t = new Tbl_Musteri();
            t.MUSTERIAD = TextBox1.Text;
            t.MUSTERISOYAD = TextBox2.Text;
            db.Tbl_Musteri.Add(t);
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");
        }
    }
}