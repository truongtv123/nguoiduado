//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nguoiduado.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Video
    {
        public int VideoID { get; set; }
        public string TieuDe { get; set; }
        public string LinkAnh { get; set; }
        public string LinkVideo { get; set; }
        public string NguonTin { get; set; }
        public Nullable<int> LuotXem { get; set; }
        public string NguoiDang { get; set; }
        public Nullable<System.DateTime> NgayDang { get; set; }
        public string NguoiCapNhat { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public int TrangThaiPhatHanh { get; set; }
    }
}