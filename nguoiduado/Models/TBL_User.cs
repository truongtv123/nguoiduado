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
    
    public partial class TBL_User
    {
        public TBL_User()
        {
            this.TBL_AD_VaiTro_NguoiDung = new HashSet<TBL_AD_VaiTro_NguoiDung>();
        }
    
        public decimal UserID { get; set; }
        public Nullable<decimal> MaVaiTro { get; set; }
        public string MaNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string HoVaTen { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiO { get; set; }
        public string NoiSinh { get; set; }
        public string NguyenQuan { get; set; }
        public string ImageAvatar { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string DienThoaiDD { get; set; }
        public string DienThoaiCD { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool SuDung { get; set; }
    
        public virtual TBL_AD_VaiTro TBL_AD_VaiTro { get; set; }
        public virtual ICollection<TBL_AD_VaiTro_NguoiDung> TBL_AD_VaiTro_NguoiDung { get; set; }
    }
}
