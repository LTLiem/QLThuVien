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
    
    public partial class donhang
    {
        public donhang()
        {
            this.ctdonhangs = new HashSet<ctdonhang>();
        }
    
        public int maDonHang { get; set; }
        public Nullable<System.DateTime> ngayLapDonHang { get; set; }
        public Nullable<System.DateTime> ngayGiaoHang { get; set; }
        public string ghiChu { get; set; }
        public Nullable<int> trangThai { get; set; }
        public Nullable<int> maNhaCungCap { get; set; }
    
        public virtual ICollection<ctdonhang> ctdonhangs { get; set; }
        public virtual nhacungcap nhacungcap { get; set; }
    }
}
