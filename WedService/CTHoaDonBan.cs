//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WedService
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHoaDonBan
    {
        public string MaCTHoaDon { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public int GiaGiam { get; set; }
    
        public virtual HoaDonBan HoaDonBan { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
