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
    
    public partial class chude
    {
        public chude()
        {
            this.sach = new HashSet<sach>();
        }
    
        public int maChuDe { get; set; }
        public string tenChuDe { get; set; }
    
        public virtual ICollection<sach> sach { get; set; }
    }
}
