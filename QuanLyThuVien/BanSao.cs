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
    
    public partial class BanSao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BanSao()
        {
            this.PhieuMuonSaches = new HashSet<PhieuMuonSach>();
        }
    
        public string MaBanSao { get; set; }
        public string MaSach { get; set; }
        public ETrangThai TrangThai { get; set; }
    
        public virtual Sach Sach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuonSach> PhieuMuonSaches { get; set; }
    }
}