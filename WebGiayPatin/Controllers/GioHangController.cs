using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiayPatin.Models;
using WebGiayPatin.ServiceReferenceUser;

namespace WebGiayPatin.Controllers
{
    public class GioHangController : Controller
    {
        UserWedClient ussv = new UserWedClient();
        public ActionResult Themgiohang(string masp) // Thêm giỏ hàng
        {
            string url = Request.UrlReferrer.ToString(); // Lấy url trước đó
            try
            { 
                string hinhanh ="http://placehold.it/200x200";
                List<Giohang> gh = Giohang.Giohangs; // Tạo list giỏ hàng
                Giohang giohang = new Giohang();
                var sp = ussv.FindSanPham(masp); // Lấy thông tin sp gán vào giỏ hàng
                giohang.MaSP = sp.MaSP;
                giohang.TenSP = sp.TenSP;
            
                if(sp.HinhAnh != null)
                {
                    string imageBase64 = Convert.ToBase64String(sp.HinhAnh); //Đổi hình ảnh từ kiểu byte sang kiểu string
                    hinhanh = string.Format("data:image/gif;base64,{0}", imageBase64);
                }
                giohang.HinhAnh = hinhanh;
                giohang.Gia = sp.Gia;
                giohang.GiaGiam = sp.GiaGiam;
                giohang.SoLuong = 1;
                Giohang s = gh.Find(p => p.MaSP == masp);
                var find = gh.Where(p => p.MaSP == masp).ToList();
                if (find.Count() > 0) // Ktra sp đã có trong giỏ hàng chưa, nếu có sẽ tăng số lượng
                {
                    if (s.SoLuong < sp.SoLuong)
                        s.SoLuong++;
                }
                else gh.Add(giohang);
                Session["Soluonggio"] = gh.Count(); // Số lượng sản phẩm trong giỏ hàng
                TempData["themgiohang"] = "thanhcong";
                return Redirect(url);
            }
            catch
            {
                TempData["themgiohang"] = "thatbai";
                return Redirect(url);
            }
        }
        public ActionResult Xemgiohang()// Xem giỏ hàng
        {
            List<Giohang> gh = Giohang.Giohangs;
            return View(gh);
        }
        public ActionResult Capnhatsoluong(string masp, int soluong) // Cập nhật số lượng
        {
            var sp = ussv.FindSanPham(masp);
            int soluongmax = sp.SoLuong;
            if (soluong > soluongmax) // Ktra có lớn hơn số lượng trong kho không
            {
                soluong = soluongmax;
                TempData["soluong"] = soluongmax;
            }
            List<Giohang> gh = Giohang.Giohangs;
            Giohang s = gh.Find(p => p.MaSP == masp);
            s.SoLuong = soluong;
            return Redirect("/Giohang/Xemgiohang");
        }
        public ActionResult Xoagiohang(string masp) // Xóa giỏ hàng
        {
            List<Giohang> gh = Giohang.Giohangs;
            Giohang s = gh.Find(p => p.MaSP == masp);
            gh.Remove(s);
            Session["Soluonggio"] = Int32.Parse(Session["Soluonggio"].ToString()) - 1;
            TempData["xoagiohang"] = "thanhcong";
            return Redirect("/Giohang/Xemgiohang");
        }
        public ActionResult Tienhanhdathang() // Tiến hành đặt hàng, hiện thông tin
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap?url=/Giohang/Tienhanhdathang");
            }
            string tendangnhap = Session["Tendangnhap"].ToString();
            var dn = ussv.FindNguoiDung(tendangnhap);
            return View(dn);
        }
        public ActionResult Dathang(string hoten, string diachi, string sdt) // Đặt hàng, hiện thông tin
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap?url=/Giohang/Tienhanhdathang");
            }
            List<Giohang> gh = Giohang.Giohangs;
            if (gh == null)
            {
                return Redirect("/Default/Index");
            }
            ViewBag.hoten = hoten;
            ViewBag.diachi = diachi;
            ViewBag.sdt = sdt;
            return View(gh);
        }
        public ActionResult Thanhtoan(string hoten, string diachi, string sdt, float tongtien)// Thanh toán
        {
            string tendangnhap = Session["Tendangnhap"].ToString();
            string mahd = DateTime.Now.Ticks.ToString();
            List<Giohang> gh = Giohang.Giohangs;
            if(ussv.InsertHoaDonBan(mahd, tendangnhap, hoten, sdt, diachi, tongtien))
            {
                foreach(Giohang cthd in gh)
                {
                    if(ussv.InsertChiTietHoaDonBan(mahd, cthd.MaSP, cthd.SoLuong, cthd.Gia, cthd.GiaGiam))
                    {
                        ussv.DeleteSoLuongSP(cthd.MaSP, cthd.SoLuong);// Trừ số lượng sản phẩm đặt
                    }
                }
                Giohang.Giohangs = null;
                Session["Soluonggio"] = 0;
                TempData["thongbao"] = "dathang";
                return Redirect("/Default/Index");
            }
            else
            {
                return Redirect("/Default/index");
            }
        }
    }
}
