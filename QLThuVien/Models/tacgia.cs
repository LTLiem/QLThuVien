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
    
    public partial class tacgia
    {
        public tacgia()
        {
            this.sach = new HashSet<sach>();
        }
    
        public int maTacGia { get; set; }
        public string tenVietTat { get; set; }
        public string tenDayDu { get; set; }
        public string thongTin { get; set; }
        public string gioiTinh { get; set; }
    
        public virtual ICollection<sach> sach { get; set; }
    }
}
