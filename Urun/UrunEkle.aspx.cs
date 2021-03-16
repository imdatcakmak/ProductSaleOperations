using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Urun
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

           
            var ktgr = (from x in db.Tbl_Kategori
                        select new
                        {
                            x.KATEGORIID,
                            x.KATEGORIAD
                        }).ToList();
            DropDownList1.DataTextField = "KATEGORIAD";
            DropDownList1.DataValueField = "KATEGORIID";
            DropDownList1.DataSource = ktgr;
            DropDownList1.DataBind();
        }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Urunler t = new Tbl_Urunler();
            t.URUNAD = TxtUrunad.Text;
            t.URUNSTOK = short.Parse(TxtStok.Text);
            t.URUNMARKA = TxtMarka.Text;
            t.URUNFIYAT = decimal.Parse(TxtFiyat.Text);
            t.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue);
            db.Tbl_Urunler.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}