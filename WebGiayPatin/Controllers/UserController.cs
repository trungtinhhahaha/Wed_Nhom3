using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiayPatin.ServiceReferenceUser;

namespace WebGiayPatin.Controllers
{
    public class UserController : Controller
    {
        UserWedClient ussv = new UserWedClient();

        public ActionResult Dangnhap(string tendangnhap, string matkhau, string url) // Đăng nhập
        {
            if (url == null)
            {
                url = @Request.UrlReferrer.ToString();
            }
            if (url == "http://localhost:2442/User/Dangnhap")
            {
                url = "/Default/Index";
            }
            ViewBag.url = url;
            ViewBag.tendangnhap = tendangnhap;
            ViewBag.matkhau = matkhau;
            if(tendangnhap != null)
            if (ussv.DangNhapNguoiDung(tendangnhap, matkhau))
            {
                Session["Tendangnhap"] = tendangnhap;
                return Redirect(url);
            }
            else
            { ViewBag.dangnhap = "thatbai"; }
            return View();
        }
        public ActionResult Dangxuat() // Đăng xuất
        {
            string url = @Request.UrlReferrer.ToString();
            ViewBag.url = url;
            Session["Tendangnhap"] = null;
            return Redirect(url);
        }
        // Đăng ký
        public ActionResult Dangky(string hoten, string tendangnhap, string matkhau, string email, string ngaysinh, string diachi, string gioitinh, string sdt)
        {
            // Đăng ký thành công
            if (ussv.InsertNguoiDung(tendangnhap, matkhau, hoten, 2, ngaysinh, gioitinh, diachi, email, sdt))
            {
                Session["Tendangnhap"] = tendangnhap;
                return Redirect("/Default/Index");
            }
            else // Đăng ký thất bại
            {
                if (tendangnhap != null)
                {
                    ViewBag.tendangnhap = tendangnhap;
                    ViewBag.matkhau = matkhau;
                    ViewBag.hoten = hoten;
                    ViewBag.ngaysinh = ngaysinh;
                    ViewBag.diachi = diachi;
                    ViewBag.email = email;
                    ViewBag.sdt = sdt;
                    TempData["thongbao"] = "thatbai";
                }
                return View();
            }  
        }
        #region Quanlytaikhoan
        public ActionResult Quanlytaikhoan()// Hiện thông tin quản lý tài khoản
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap");
            }
            string tendangnhap = Session["Tendangnhap"].ToString();
            var dn = ussv.FindNguoiDung(tendangnhap);
            return View(dn);
        }
        public ActionResult Thongtindangnhap() // Cập nhật thông tin đăng nhập
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap");
            }
            return View();
        }
        public ActionResult Thongtindangnhap1(string matkhau) // Lưu cập nhật thông tin đăng nhập
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap");
            }
            string tendangnhap = Session["Tendangnhap"].ToString();
            if(ussv.UpdateThongTinDangNhap(tendangnhap, matkhau))
            {
                TempData["thongbao"] = "thanhcong";
                return Redirect("/User/Quanlytaikhoan");
            }
            else
            {
                return Redirect("/User/Thongtindangnhap");
            }
        }
        public ActionResult Thongtincanhan()// Cập nhật thông tin cá nhân
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap");
            }
            string tendangnhap = Session["Tendangnhap"].ToString();
            var dn = ussv.FindNguoiDung(tendangnhap);
            return View(dn);
        }
        // Lưu cập nhật thông tin cá nhân
        public ActionResult Thongtincanhan1(string hoten, string ngaysinh, string gioitinh, string email, string sdt, string diachi)
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap");
            }
            string tendangnhap = Session["Tendangnhap"].ToString();
            if (ussv.UpdateThongTinCaNhan(tendangnhap, hoten, ngaysinh, gioitinh, diachi, email, sdt))
            {
                TempData["thongbao"] = "thanhcong";
                return Redirect("/User/Quanlytaikhoan");
            }
            else
            {
                return Redirect("/User/Thongtindangnhap");
            }
        }
        #endregion
        #region Quanlydonhang
        public ActionResult Quanlydonhang(DateTime? ngaytu, DateTime? ngayden) // Xem và tìm đơn hàng theo ngày
        {
            if (Session["Tendangnhap"] == null)
            {
                return Redirect("/User/Dangnhap");
            }
            string tendangnhap = Session["Tendangnhap"].ToString();
            var dh = ussv.FindAllHoaDonBan(tendangnhap);
            if(ngaytu != null || ngayden != null)
            {
                dh = ussv.FindHoaDonBanTheoNgay(tendangnhap, ngaytu, ngayden);
            }
            return View(dh);
        }
        public ActionResult Chitietdonhang(string mahoadon) // Xem chi tiết đơn hàng theo mã hóa đơn
        {
            var dh = ussv.FindHoaDonBan(mahoadon);
            var sp = ussv.FindAllSanPham();
            var cthd = ussv.FindChiTietHoaDonBan(mahoadon);
            ViewBag.sp = sp;
            ViewBag.cthd = cthd;
            return View(dh);
        }
        public ActionResult Huydonhang(string mahoadon) // Hủy đơn hàng do người đăng nhập đặt
        {
            var cthd = ussv.FindChiTietHoaDonBan(mahoadon);
            if(ussv.HuyHoaDonBan(mahoadon))
            {
                foreach(var cnsl in cthd)
                {
                    ussv.AddSoLuongSP(cnsl.MaSP, cnsl.SoLuong);
                }
                TempData["thongbao"] = "thanhcong";
                return Redirect("/User/Quanlydonhang");
            }
            else
            {
                TempData["thongbao"] = "thatbai";
                return Redirect("/User/Quanlydonhang");
            }
        }
        #endregion
    }
}
