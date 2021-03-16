using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Kategori.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}