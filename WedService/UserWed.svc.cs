using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserWed" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserWed.svc or UserWed.svc.cs at the Solution Explorer and start debugging.
    // Sửa tất cả các chức năng
    public class UserWed : IUserWed
    {
        GIAYPATINEntities db = new GIAYPATINEntities();
        #region NguoiDung
        public List<NguoiDung> FindAllNguoiDung()
        {
            return this.db.NguoiDungs.ToList();
        }
        public NguoiDung FindNguoiDung(string tendangnhap)
        {
            var tim = (from p in db.NguoiDungs where p.TenDangNhap == tendangnhap select p).Single();
            return tim;
        }
        public bool DangNhapNguoiDung(string tendangnhap, string matkhau)
        {
            try
            {
                NguoiDung nd = db.NguoiDungs.Single(p => p.TenDangNhap.Trim() == tendangnhap);
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
        public bool UpdateThongTinDangNhap(string tendangnhap, string matkhau)
        {
            try
            {
                NguoiDung nd = db.NguoiDungs.Single(p => p.TenDangNhap == tendangnhap);
                nd.MatKhau = matkhau;
                db.Entry(nd).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateThongTinCaNhan(string tendangnhap, string hoten, string ngaysinh, string gioitinh, string diachi, string email, string sdt)
        {
            try
            {
                NguoiDung nd = db.NguoiDungs.Single(p => p.TenDangNhap == tendangnhap);
                nd.HoTen = hoten;
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
        public List<SanPham> FindAllSPMoi()
        {
            var sp = (from p in db.SanPhams where p.TinhTrang == "Mới" orderby p.Gia select p).ToList();
            return sp;
        }
        public List<SanPham> FindAllSPNoiBat()
        {
            var sp = (from p in db.SanPhams where p.TinhTrang == "Mới" orderby p.MaSP select p).Take(6).ToList();
            return sp;
        }
        public List<SanPham> FindAllSPPhanLoai(string maloai)
        {
            var sp = (from p in db.SanPhams where p.MaLoai == maloai orderby p.Gia select p).ToList();
            return sp;
        }
        public List<SanPham> FindAllSPKhuyenMai()
        {
            var sp = (from p in db.SanPhams where p.GiaGiam > 0 orderby p.MaSP select p).ToList();
            return sp;
        }
        public SanPham FindSanPham(string masp)
        {
            var tim = (from p in db.SanPhams where p.MaSP == masp select p).Single();
            return tim;
        }
        public bool AddSoLuongSP(string masp, int soluong)
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
        public bool DeleteSoLuongSP(string masp, int soluong)
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
        #endregion
        #region PhanLoai
        public List<PhanLoai> FindAllPhanLoai()
        {
            return this.db.PhanLoais.ToList();
        }

        public string FindPhanLoai(string mapl)
        {
            var tim = (from p in db.PhanLoais where p.MaLoai == mapl select p).Single();
            return tim.TenLoai;
        }
        #endregion
        #region HoaDonBan
        public List<HoaDonBan> FindAllHoaDonBan(string tendangnhap)
        {
            var tim = (from p in db.HoaDonBans where p.TenDangNhap == tendangnhap select p).ToList();
            return tim;
        }

        public HoaDonBan FindHoaDonBan(string mahd)
        {
            var tim = (from p in db.HoaDonBans where p.MaHoaDon == mahd select p).Single();
            return tim;
        }
        public List<HoaDonBan> FindHoaDonBanTheoNgay(string tendangnhap, DateTime? ngaytu, DateTime? ngayden)
        {
            var tim = (from p in db.HoaDonBans where p.TenDangNhap == tendangnhap select p).ToList();
            if (ngaytu != null)
            {
                if (ngayden != null)
                {
                     tim = (from p in db.HoaDonBans where p.TenDangNhap == tendangnhap && p.NgayDatHang >= ngaytu && p.NgayDatHang <= ngayden select p).ToList();
                }
                else
                {
                    tim = (from p in db.HoaDonBans where p.TenDangNhap == tendangnhap && p.NgayDatHang >= ngaytu select p).ToList();
                }
            }
            else
            {
                if (ngayden != null)
                {
                    tim = (from p in db.HoaDonBans where p.TenDangNhap == tendangnhap && p.NgayDatHang <= ngayden select p).ToList();
                }
                else
                {
                    tim = (from p in db.HoaDonBans where p.TenDangNhap == tendangnhap select p).ToList();
                }
            }
            return tim;
        }
        public bool InsertHoaDonBan(string mahd, string tendangnhap, string hoten, string sdt, string diachi, float tongtien)
        {
            try
            {
                HoaDonBan hd = new HoaDonBan();
                hd.MaHoaDon = mahd;
                hd.TenDangNhap = tendangnhap;
                hd.TinhTrang = "Đang xử lý";
                hd.HoTen = hoten;
                hd.SDT = sdt;
                hd.DiaChi = diachi;
                hd.NgayDatHang = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));
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
        public bool HuyHoaDonBan(string mahd)
        {
            try
            {
                HoaDonBan hd = db.HoaDonBans.Single(p => p.MaHoaDon == mahd);
                hd.TinhTrang = "Hủy";
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
            var tim = (from p in db.CTHoaDonBans where p.MaCTHoaDon.Contains(mahd) select p).ToList();
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
        #region TimKiem
        public List<SanPham> FindTimKiemCB(string timkiem)
        {
            var sp = (from p in db.SanPhams select p).ToList();
            if(!String.IsNullOrEmpty(timkiem))
            {
                sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) orderby p.Gia select p).ToList();
            }
            return sp;
        }
        public List<SanPham> FindTimKiemNC(string timkiem, string phanloai, int giatu, int giaden)
        {
            var sp = (from p in db.SanPhams select p).ToList();
            if (!String.IsNullOrEmpty(timkiem))
            {
                if(phanloai == "-1")
                {
                    if(giatu == 0)
                    {
                        if(giaden == 0)
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                    else
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && ((p.Gia - p.GiaGiam) >= giatu) select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && ((p.Gia - p.GiaGiam) >= giatu) && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                }
                else
                {
                    if (giatu == 0)
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && p.MaLoai == phanloai select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && p.MaLoai == phanloai && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                    else
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && p.MaLoai == phanloai && ((p.Gia - p.GiaGiam) >= giatu) select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where p.TenSP.Contains(timkiem) && p.MaLoai == phanloai && ((p.Gia - p.GiaGiam) >= giatu) && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                }
            }
            else
            {
                if (phanloai == "-1")
                {
                    if (giatu == 0)
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                    else
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams where ((p.Gia - p.GiaGiam) >= giatu) select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where ((p.Gia - p.GiaGiam) >= giatu) && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                }
                else
                {
                    if (giatu == 0)
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams where p.MaLoai == phanloai select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where p.MaLoai == phanloai && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                    else
                    {
                        if (giaden == 0)
                        {
                            sp = (from p in db.SanPhams where p.MaLoai == phanloai && ((p.Gia - p.GiaGiam) >= giatu) select p).ToList();
                        }
                        else
                        {
                            sp = (from p in db.SanPhams where p.MaLoai == phanloai && ((p.Gia - p.GiaGiam) >= giatu) && ((p.Gia - p.GiaGiam) <= giaden) select p).ToList();
                        }
                    }
                }
            }
            return sp;
        }
        #endregion
    }
}
