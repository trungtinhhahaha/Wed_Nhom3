using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGiayPatin.Models
{
    public class Giohang
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
        public int Gia { get; set; }
        public int GiaGiam { get; set; }
        public int SoLuong { get; set; }

        public static List<Giohang> Giohangs
        {
            set
            {
                HttpContext.Current.Session["Giohang"] = value;
            }
            get
            {
                if (HttpContext.Current.Session["Giohang"] == null)
                {
                    List<Giohang> gh = new List<Giohang>();
                    HttpContext.Current.Session["Giohang"] = gh;
                    return gh;
                }
                return (List<Giohang>)HttpContext.Current.Session["Giohang"];
            }
        }

        public Giohang(string masp, string tensp, string hinhanh, int soluong, int gia, int giagiam)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.HinhAnh = hinhanh;
            this.SoLuong = soluong;
            this.Gia = gia;
            this.GiaGiam = giagiam;
        }
        public Giohang()
        { }
    }
}