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
    
    public partial class TBL_AD_VaiTro_Menu
    {
        public decimal MaVaiTroManHinh { get; set; }
        public decimal MaMenu { get; set; }
        public decimal MaVaiTro { get; set; }
        public bool SuDung { get; set; }
        public bool Them { get; set; }
        public bool Sua { get; set; }
        public bool Xoa { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
    
        public virtual TBL_AD_Menu TBL_AD_Menu { get; set; }
        public virtual TBL_AD_VaiTro TBL_AD_VaiTro { get; set; }
    }
}