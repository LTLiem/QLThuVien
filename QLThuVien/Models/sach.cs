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
    
    public partial class sach
    {
        public sach()
        {
            this.ctphieumuonsaches = new HashSet<ctphieumuonsach>();
            this.chudes = new HashSet<chude>();
            this.tacgias = new HashSet<tacgia>();
        }
    
        public int maSach { get; set; }
        public Nullable<int> maVach { get; set; }
        public Nullable<int> tinhTrangSach { get; set; }
        public Nullable<int> soTienPhat { get; set; }
        public Nullable<int> maDauSach { get; set; }
    
        public virtual ICollection<ctphieumuonsach> ctphieumuonsaches { get; set; }
        public virtual ICollection<chude> chudes { get; set; }
        public virtual ICollection<tacgia> tacgias { get; set; }
    }
}
