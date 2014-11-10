using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserWed" in both code and config file together.
    // Sửa tất cả các chức năng
    [ServiceContract]
    public interface IUserWed
    {
        #region NguoiDung
        [OperationContract]
        List<NguoiDung> FindAllNguoiDung();
        [OperationContract]
        NguoiDung FindNguoiDung(string tendangnhap);
        [OperationContract]
        bool DangNhapNguoiDung(string tendangnhap, string matkhau);
        [OperationContract]
        bool InsertNguoiDung(string tendangnhap, string matkhau, string hoten, int quyen, string ngaysinh, string gioitinh, string diachi, string email, string sdt);
        [OperationContract]
        bool UpdateThongTinDangNhap(string tendangnhap, string matkhau);
        [OperationContract]
        bool UpdateThongTinCaNhan(string tendangnhap, string hoten, string ngaysinh, string gioitinh, string diachi, string email, string sdt);
        #endregion
        #region SanPham
        [OperationContract]
        List<SanPham> FindAllSanPham();
        [OperationContract]
        List<SanPham> FindAllSPMoi();
        [OperationContract]
        List<SanPham> FindAllSPNoiBat();
        [OperationContract]
        List<SanPham> FindAllSPPhanLoai(string maloai);
        [OperationContract]
        List<SanPham> FindAllSPKhuyenMai();
        [OperationContract]
        SanPham FindSanPham(string masp);
        [OperationContract]
        bool AddSoLuongSP(string masp, int soluong);
        [OperationContract]
        bool DeleteSoLuongSP(string masp, int soluong);
        #endregion
        #region PhanLoai
        [OperationContract]
        List<PhanLoai> FindAllPhanLoai();
        [OperationContract]
        string FindPhanLoai(string mapl);
        #endregion
        #region HoaDonBan
        [OperationContract]
        List<HoaDonBan> FindAllHoaDonBan(string tendangnhap);
        [OperationContract]
        HoaDonBan FindHoaDonBan(string mahd);
        [OperationContract]
        List<HoaDonBan> FindHoaDonBanTheoNgay(string tendangnhap, DateTime? ngaytu, DateTime? ngayden);
        [OperationContract]
        bool InsertHoaDonBan(string mahd, string tendangnhap, string hoten, string sdt, string diachi, float tongtien);
        [OperationContract]
        bool HuyHoaDonBan(string mahd);
        #endregion
        #region ChiTietHoaDonBan
        [OperationContract]
        List<CTHoaDonBan> FindChiTietHoaDonBan(string mahd);
        [OperationContract]
        bool InsertChiTietHoaDonBan(string mahd, string masp, int soluong, int gia, int giagiam);
        #endregion
        #region TimKiem
        [OperationContract]
        List<SanPham> FindTimKiemCB(string timkiem);
        [OperationContract]
        List<SanPham> FindTimKiemNC(string timkiem, string phanloai, int giatu, int giaden);
        #endregion
    }
}
