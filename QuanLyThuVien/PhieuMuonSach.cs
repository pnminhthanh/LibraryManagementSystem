//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuMuonSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuonSach()
        {
            this.BanSaos = new HashSet<BanSao>();
        }
    
        public string MaPhieuMuon { get; set; }
        public string MaNguoiMuon { get; set; }
        public string MaThuThu { get; set; }
        public System.DateTime NgayMuonSach { get; set; }
        public System.DateTime HanTraSach { get; set; }
        public Nullable<System.DateTime> NgayTraSach { get; set; }
        public Nullable<decimal> PhiThue { get; set; }
        public decimal TienDatCoc { get; set; }
    
        public virtual DocGia DocGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanSao> BanSaos { get; set; }
    }
}
