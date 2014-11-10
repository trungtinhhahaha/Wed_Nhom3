using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdminWinform" in both code and config file together.
    // Sửa tất cả các chức năng
    [ServiceContract]
    public interface IAdminWinform
    {
        #region NguoiDung
        [OperationContract]
        List<NguoiDung> FindAllNguoiDung();
        [OperationContract]
        List<NguoiDung> FindNguoiDung(string tendangnhap);
        [OperationContract]
        bool DangNhapNguoiDung(string tendangnhap, string matkhau);
        [OperationContract]
        bool InsertNguoiDung(string tendangnhap, string matkhau, string hoten, int quyen, string ngaysinh, string gioitinh, string diachi, string email, string sdt);
        [OperationContract]
        bool DeleteNguoiDung(string tendangnhap);
        [OperationContract]
        bool UpdateNguoiDung(string tendangnhap, string matkhau, string hoten, int quyen, string ngaysinh, string gioitinh, string diachi, string email, string sdt);
        #endregion
        #region SanPham
        [OperationContract]
        List<SanPham> FindAllSanPham();
        [OperationContract]
        List<SanPham> FindSanPham(string tensp);
        [OperationContract]
        SanPham FindMaSanPham(string masp);
        [OperationContract]
        bool UpdateSoLuong(string masp, int soluong);
        [OperationContract]
        bool DeleteSoLuong(string masp, int soluong);
        [OperationContract]
        bool InsertSanPham(string masp, string tensp, string maloai, int baohanh, string trangthai, string loaimau, string kichco, int soluong, int gia, int giagiam, string hinhanh);
        [OperationContract]
        bool DeleteSanPham(string masp);
        [OperationContract]
        bool UpdateSanPham(string masp, string tensp, string maloai, int baohanh, string trangthai, string loaimau, string kichco, int soluong, int gia, int giagiam, string hinhanh);
        #endregion
        #region PhanLoai
        [OperationContract]
        List<PhanLoai> FindAllPhanLoai();
        [OperationContract]
        List<PhanLoai> FindPhanLoai(string mapl);
        [OperationContract]
        bool InsertPhanLoai(string mapl, string tenpl);
        [OperationContract]
        bool DeletePhanLoai(string mapl);
        [OperationContract]
        bool UpdatePhanLoai(string mapl, string tenpl);
        #endregion
        #region HoaDonBan
        [OperationContract]
        List<HoaDonBan> FindAllHoaDonBan();
        [OperationContract]
        List<HoaDonBan> FindHoaDonBan(string mahd);
        [OperationContract]
        bool InsertHoaDonBan(string mahd, string tendangnhap, string tinhtrang, string hoten, string sdt, string diachi, float tongtien);
        [OperationContract]
        bool UpdateHoaDonBan(string mahd, string tinhtrang);
        #endregion
        #region ChiTietHoaDonBan
        [OperationContract]
        List<CTHoaDonBan> FindChiTietHoaDonBan(string mahd);
        [OperationContract]
        bool InsertChiTietHoaDonBan(string mahd, string masp, int soluong, int gia, int giagiam);
        #endregion
        #region HoaDonNhap
        [OperationContract]
        List<HoaDonNhap> FindAllHoaDonNhap();
        [OperationContract]
        List<HoaDonNhap> FindHoaDonNhap(string mahd);
        [OperationContract]
        bool InsertHoaDonNhap(string mahd, string tendangnhap, float tongtien);
        #endregion
        #region ChiTietHoaDonNhap
        [OperationContract]
        List<CTHoaDonNhap> FindChiTietHoaDonNhap(string mahd);
        [OperationContract]
        bool InsertChiTietHoaDonNhap(string mahd, string masp, int soluong, int gia);
        #endregion
        #region ThongKe
        [OperationContract]
        List<HoaDonBan> ThongKeTheoNgay(string ngay);
        [OperationContract]
        List<HoaDonBan> ThongKeTheoThang(string thang, string nam);
        [OperationContract]
        List<HoaDonBan> ThongKeTheoNam(string nam);
        #endregion
    }
}
