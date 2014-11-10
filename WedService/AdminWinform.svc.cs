using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminWinform" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdminWinform.svc or AdminWinform.svc.cs at the Solution Explorer and start debugging.
    // Viết lại tất cả
    public class AdminWinform : IAdminWinform
    {
        GIAYPATINEntities db = new GIAYPATINEntities();
        #region NguoiDung
        public List<NguoiDung> FindAllNguoiDung()
        {
            return this.db.NguoiDungs.ToList();
        }

        public List<NguoiDung> FindNguoiDung(string tendangnhap)
        {
            var tim = (from p in db.NguoiDungs where p.TenDangNhap.Contains(tendangnhap) select p).ToList();
            return tim;
        }

        public bool DangNhapNguoiDung(string tendangnhap, string matkhau)
        {
            try
            {
                NguoiDung nd = db.NguoiDungs.Single(p => p.TenDangNhap.Trim() == tendangnhap && p.Quyen == 1);
                if (nd.TenDangNhap.Trim() == tendangnhap && nd.MatKhau.Trim() == matkhau)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertNguoiDung(string tendangnhap, string matkhau, string hoten, int quyen, string ngaysinh, string gioitinh, string diachi, string email, string sdt)
        {
            try
            {
                NguoiDung nd = new NguoiDung();
                nd.TenDangNhap = tendangnhap;
                nd.MatKhau = matkhau;
                nd.HoTen = hoten;
                nd.Quyen = quyen;
                nd.NgaySinh = DateTime.Parse(ngaysinh);
                nd.GioiTinh = gioitinh;
                nd.DiaChi = diachi;
                nd.Email = email;
                nd.SDT = sdt;
                db.NguoiDungs.Add(nd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteNguoiDung(string tendangnhap)
        {
            try
            {
                NguoiDung nd = db.NguoiDungs.Single(p => p.TenDangNhap == tendangnhap);
                db.NguoiDungs.Remove(nd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNguoiDung(string tendangnhap, string matkhau, string hoten, int quyen, string ngaysinh, string gioitinh, string diachi, string email, string sdt)
        {
            try
            {
                NguoiDung nd = db.NguoiDungs.Single(p => p.TenDangNhap == tendangnhap);
                nd.MatKhau = matkhau;
                nd.HoTen = hoten;
                nd.Quyen = quyen;
                nd.NgaySinh = DateTime.Parse(ngaysinh);
                nd.GioiTinh = gioitinh;
                nd.DiaChi = diachi;
                nd.Email = email;
                nd.SDT = sdt;
                db.Entry(nd).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region SanPham
        public List<SanPham> FindAllSanPham()
        {
            return this.db.SanPhams.ToList();
        }
        public List<SanPham> FindSanPham(string tensp)
        {
            var tim = (from p in db.SanPhams where p.TenSP.Contains(tensp) select p).ToList();
            return tim;
        }
        public SanPham FindMaSanPham(string masp)
        {
            var tim = (from p in db.SanPhams where p.MaSP == masp select p).Single();
            return tim;
        }
        public bool UpdateSoLuong(string masp, int soluong)
        {
            try
            {
                SanPham sp = db.SanPhams.Single(p => p.MaSP == masp);
                sp.SoLuong = sp.SoLuong + soluong;
                db.Entry(sp).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteSoLuong(string masp, int soluong)
        {
            try
            {
                SanPham sp = db.SanPhams.Single(p => p.MaSP == masp);
                sp.SoLuong = sp.SoLuong - soluong;
                db.Entry(sp).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertSanPham(string masp, string tensp, string maloai, int baohanh, string trangthai, string loaimau, string kichco, int soluong, int gia, int giagiam, string hinhanh)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.MaSP = masp;
                sp.TenSP = tensp;
                sp.MaLoai = maloai;
                sp.BaoHanh = baohanh;
                sp.TinhTrang = trangthai;
                sp.LoaiMau = loaimau;
                sp.KichCo = kichco;
                sp.SoLuong = soluong;
                sp.Gia = gia;
                sp.GiaGiam = giagiam;
                if (hinhanh != null) // Đổi hình ảnh thành kiểu byte
                    using (var stream = File.OpenRead(hinhanh))
                    {
                        byte[] imageData = new byte[stream.Length];
                        stream.Read(imageData, 0, imageData.Length);
                        sp.HinhAnh = imageData;
                    }      
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteSanPham(string masp)
        {
            try
            {
                SanPham sp = db.SanPhams.Single(p => p.MaSP == masp);
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateSanPham(string masp, string tensp, string maloai, int baohanh, string trangthai, string loaimau, string kichco, int soluong, int gia, int giagiam, string hinhanh)
        {
            try
            {
                SanPham sp = db.SanPhams.Single(p => p.MaSP == masp);
                sp.TenSP = tensp;
                sp.MaLoai = maloai;
                sp.BaoHanh = baohanh;
                sp.TinhTrang = trangthai;
                sp.LoaiMau = loaimau;
                sp.KichCo = kichco;
                sp.SoLuong = soluong;
                sp.Gia = gia;
                sp.GiaGiam = giagiam;
                if (hinhanh != null) 
                    using (var stream = File.OpenRead(hinhanh))
                    {
                        byte[] imageData = new byte[stream.Length];
                        stream.Read(imageData, 0, imageData.Length);
                        sp.HinhAnh = imageData;
                    }
                db.Entry(sp).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        #endregion
        #region PhanLoai
        public List<PhanLoai> FindAllPhanLoai()
        {
            return this.db.PhanLoais.ToList();
        }

        public List<PhanLoai> FindPhanLoai(string mapl)
        {
            var tim = (from p in db.PhanLoais where p.MaLoai.Contains(mapl) select p).ToList();
            return tim;
        }

        public bool InsertPhanLoai(string mapl, string tenpl)
        {
            try
            {
                PhanLoai pl = new PhanLoai();
                pl.MaLoai = mapl;
                pl.TenLoai = tenpl;
                db.PhanLoais.Add(pl);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePhanLoai(string mapl)
        {
            try
            {
                PhanLoai pl = db.PhanLoais.Single(p => p.MaLoai == mapl);
                db.PhanLoais.Remove(pl);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePhanLoai(string mapl, string tenpl)
        {
            try
            {
                PhanLoai pl = db.PhanLoais.Single(p => p.MaLoai == mapl);
                pl.TenLoai = tenpl;
                db.Entry(pl).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region HoaDonBan
        public List<HoaDonBan> FindAllHoaDonBan()
        {
            return this.db.HoaDonBans.ToList();
        }

        public List<HoaDonBan> FindHoaDonBan(string mahd)
        {
            var tim = (from p in db.HoaDonBans where p.MaHoaDon.Contains(mahd) select p).ToList();
            return tim;
        }

        public bool InsertHoaDonBan(string mahd, string tendangnhap, string tinhtrang, string hoten, string sdt, string diachi, float tongtien)
        {
            try
            {
                HoaDonBan hd = new HoaDonBan();
                hd.MaHoaDon = mahd;
                hd.TenDangNhap = tendangnhap;
                hd.TinhTrang = tinhtrang;
                hd.HoTen = hoten;
                hd.SDT = sdt;
                hd.DiaChi = diachi;
                hd.NgayDatHang = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));
                if (tinhtrang == "Hoàn thành")
                {
                    hd.NgayGiaoHang = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));
                }
                hd.TongTien = tongtien;
                db.HoaDonBans.Add(hd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateHoaDonBan(string mahd, string tinhtrang)
        {
            try
            {
                HoaDonBan hd = db.HoaDonBans.Single(p => p.MaHoaDon == mahd);
                hd.TinhTrang = tinhtrang;
                if (tinhtrang == "Hoàn thành")
                {
                    hd.NgayGiaoHang = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));
                }
                db.Entry(hd).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region ChiTietHoaDonBan
        public List<CTHoaDonBan> FindChiTietHoaDonBan(string mahd)
        {
            var tim = (from p in db.CTHoaDonBans where p.MaCTHoaDon == mahd select p).ToList();
            return tim;
        }

        public bool InsertChiTietHoaDonBan(string mahd, string masp, int soluong, int gia, int giagiam)
        {
            try
            {
                CTHoaDonBan ct = new CTHoaDonBan();
                ct.MaCTHoaDon = mahd;
                ct.MaSP = masp;
                ct.SoLuong = soluong;
                ct.Gia = gia;
                ct.GiaGiam = giagiam;
                db.CTHoaDonBans.Add(ct);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region HoaDonNhap
        public List<HoaDonNhap> FindAllHoaDonNhap()
        {
            return this.db.HoaDonNhaps.ToList();
        }

        public List<HoaDonNhap> FindHoaDonNhap(string mahd)
        {
            var tim = (from p in db.HoaDonNhaps where p.MaHoaDon.Contains(mahd) select p).ToList();
            return tim;
        }

        public bool InsertHoaDonNhap(string mahd, string tendangnhap, float tongtien)
        {
            try
            {
                HoaDonNhap hd = new HoaDonNhap();
                hd.MaHoaDon = mahd;
                hd.TenDangNhap = tendangnhap;
                hd.NgayNhap = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));
                hd.TongTien = tongtien;
                db.HoaDonNhaps.Add(hd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region ChiTietHoaDonNhap
        public List<CTHoaDonNhap> FindChiTietHoaDonNhap(string mahd)
        {
            var tim = (from p in db.CTHoaDonNhaps where p.MaCTHoaDon == mahd select p).ToList();
            return tim;
        }

        public bool InsertChiTietHoaDonNhap(string mahd, string masp, int soluong, int gia)
        {
            try
            {
                CTHoaDonNhap ct = new CTHoaDonNhap();
                ct.MaCTHoaDon = mahd;
                ct.MaSP = masp;
                ct.SoLuong = soluong;
                ct.Gia = gia;
                db.CTHoaDonNhaps.Add(ct);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion  
        #region ThongKe
        public List<HoaDonBan> ThongKeTheoNgay(string ngay)
        {
            DateTime tkngay = DateTime.Parse(ngay);
            var thongke = (from p in db.HoaDonBans where p.NgayDatHang == tkngay && p.TinhTrang == "Hoàn thành" select p).ToList();
            return thongke;
        }
        public List<HoaDonBan> ThongKeTheoThang(string thang, string nam)
        {
            int th = Int32.Parse(thang);
            int yr = Int32.Parse(nam);
            var thongke = (from p in db.HoaDonBans where p.NgayDatHang.Month == th && p.NgayDatHang.Year == yr && p.TinhTrang == "Hoàn thành" select p).ToList();
            return thongke;
        }
        public List<HoaDonBan> ThongKeTheoNam(string nam)
        {
            int yr = Int32.Parse(nam);
            var thongke = (from p in db.HoaDonBans where p.NgayDatHang.Year == yr && p.TinhTrang == "Hoàn thành" select p).ToList();
            return thongke;
        }
        #endregion
    }
}
