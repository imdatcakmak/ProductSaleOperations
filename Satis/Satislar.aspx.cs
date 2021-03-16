using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite2.Entity;
namespace WebSite2.Satis
{
    public partial class Satislar : System.Web.UI.Page
    {
        SiteDb2Entities db = new SiteDb2Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var satislar = db.Tbl_Satıs.ToList();
            var satislar = (from x in db.Tbl_Satıs
                            select new
                            {
                                x.SATISID,
                                x.Tbl_Urunler.URUNAD,
                                x.Tbl_Personel.PERSONELADSOYAD,
                                MUSTERI = x.Tbl_Musteri.MUSTERIAD + x.Tbl_Musteri.MUSTERISOYAD,
                                x.FIYAT
                            }).ToList();
            Repeater1.DataSource = satislar;
            Repeater1.DataBind();
        }
    }
}