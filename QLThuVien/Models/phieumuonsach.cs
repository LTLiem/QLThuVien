//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class phieumuonsach
    {
        public phieumuonsach()
        {
            this.ctphieumuonsach = new HashSet<ctphieumuonsach>();
        }
    
        public int maPhieuMuonSach { get; set; }
        public Nullable<System.DateTime> ngayTra { get; set; }
        public Nullable<System.DateTime> ngayGiaHan { get; set; }
        public Nullable<int> soTienPhat { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> maNhanVien { get; set; }
        public Nullable<int> maTheThuVien { get; set; }
    
        public virtual ICollection<ctphieumuonsach> ctphieumuonsach { get; set; }
        public virtual nhanvien nhanvien { get; set; }
        public virtual thethuvien thethuvien { get; set; }
    }
}