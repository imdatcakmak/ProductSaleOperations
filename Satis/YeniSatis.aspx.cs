using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                var urun = (from x in db.Tbl_Urunler
                            select new
                            {
                                x.URUNID,
                                x.URUNAD
                            }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var musteri = (from x in db.Tbl_Musteri
                               select new
                               {
                                  x.MUSTERIID,
                               MUSTERIADSOYAD=   x.MUSTERIAD + " " + x.MUSTERISOYAD
                               }).ToList();
                DropDownList2.DataTextField = "MUSTERIADSOYAD";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = musteri;
                DropDownList2.DataBind();

                var personel = (from x in db.Tbl_Personel
                                select new
                                {
                                    x.PERSONELID,
                                    x.PERSONELADSOYAD
                                }).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = personel;
                DropDownList3.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Satıs t = new Tbl_Satıs();
            t.URUN = int.Parse(DropDownList1.SelectedValue);
            t.MUSTERI = int.Parse(DropDownList2.SelectedValue);
            t.PERSONEL = byte.Parse(DropDownList3.SelectedValue);
            t.FIYAT = decimal.Parse(Textbox1.Text);
            db.Tbl_Satıs.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");

        }
    }
}