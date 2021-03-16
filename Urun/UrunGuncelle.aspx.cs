using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
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

                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                TxtUrunid.Text = id.ToString();
                TxtUrunid.Enabled = false;
                var p = db.Tbl_Urunler.Find(id);
                TxtUrunad.Text = p.URUNAD;
                TxtStok.Text = p.URUNSTOK.ToString();
                TxtMarka.Text = p.URUNMARKA;
                TxtFiyat.Text = p.URUNFIYAT.ToString();
                DropDownList1.SelectedValue = p.URUNKATEGORI.ToString();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun = db.Tbl_Urunler.Find(id);
            urun.URUNAD = TxtUrunad.Text;
            urun.URUNFIYAT = decimal.Parse(TxtFiyat.Text);
            urun.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue);
            urun.URUNSTOK =  short.Parse(TxtStok.Text);
            urun.URUNMARKA = TxtMarka.Text;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");

        }
    }
}