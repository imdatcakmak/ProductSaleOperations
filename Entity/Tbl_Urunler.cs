//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite2.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Urunler()
        {
            this.Tbl_Satıs = new HashSet<Tbl_Satıs>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string URUNMARKA { get; set; }
        public Nullable<byte> URUNKATEGORI { get; set; }
        public Nullable<decimal> URUNFIYAT { get; set; }
        public Nullable<short> URUNSTOK { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual Tbl_Kategori Tbl_Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Satıs> Tbl_Satıs { get; set; }
    }
}
