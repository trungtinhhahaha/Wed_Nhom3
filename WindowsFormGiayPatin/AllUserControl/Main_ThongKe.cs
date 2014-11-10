using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormGiayPatin.ServiceReferenceAdmin;
using Microsoft.Reporting.WinForms;

namespace WindowsFormGiayPatin.AllUserControl
{
    public partial class Main_ThongKe : UserControl
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Main_ThongKe()
        {
            InitializeComponent();
            CbbTheoThang();
            CbbTheoNam();
            CbbNam();
            DateTime t = DateTime.Today;
            cbbtheonam.Text = t.Year.ToString();
            cbbtimthang.Text = t.Month.ToString();
            cbbtimnam.Text = t.Year.ToString();
        }

        private void btntimtheongay_Click(object sender, EventArgs e)
        {
            string ngay = datetheongay.Text;
            List<CTHoaDonBan> listngay = new List<CTHoaDonBan>();
            var thongke = adsv.ThongKeTheoNgay(ngay);
            int stt = 1;
            foreach (var kt in thongke)
            {
                var cthd = adsv.FindChiTietHoaDonBan(kt.MaHoaDon);
                foreach (var aa in cthd)
                {
                    var tensp = adsv.FindMaSanPham(aa.MaSP);
                    aa.MaSP = tensp.TenSP;
                    int dem = 0;
                    foreach (var li in listngay)
                        if (aa.MaSP == li.MaSP)
                        {
                            dem = 1;
                            li.SoLuong = li.SoLuong + aa.SoLuong;
                            break;
                        }
                    if (dem == 0)
                    {
                        aa.MaCTHoaDon = stt + "";
                        stt++;
                        listngay.Add(aa);
                    }
                        
                }
            }
            
            this.reportTKNgay.LocalReport.DataSources.Clear();
            this.reportTKNgay.LocalReport.DataSources.Add(new ReportDataSource("DataSetTheoNgay", listngay));
            this.reportTKNgay.LocalReport.SetParameters(new ReportParameter("TieuDe", "Thống Kê Theo Ngày"));
            this.reportTKNgay.LocalReport.SetParameters(new ReportParameter("ThoiGian", "Ngày: " + ngay));
            this.reportTKNgay.RefreshReport();
            this.reportTKNgay.Refresh();
        }

        private void btntimtheothang_Click(object sender, EventArgs e)
        {
            string thang = cbbtimthang.SelectedItem.ToString();
            string nam = cbbtimnam.SelectedItem.ToString();
            List<CTHoaDonBan> listthang = new List<CTHoaDonBan>();
            var thongke = adsv.ThongKeTheoThang(thang, nam);
            int stt = 1;
            foreach (var kt in thongke)
            {
                var cthd = adsv.FindChiTietHoaDonBan(kt.MaHoaDon);
                foreach (var aa in cthd)
                {
                    var tensp = adsv.FindMaSanPham(aa.MaSP);
                    aa.MaSP = tensp.TenSP;
                    int dem = 0;
                    foreach (var li in listthang)
                        if (aa.MaSP == li.MaSP)
                        {
                            dem = 1;
                            li.SoLuong = li.SoLuong + aa.SoLuong;
                            break;
                        }
                    if (dem == 0)
                    {
                        aa.MaCTHoaDon = stt + "";
                        stt++;
                        listthang.Add(aa);
                    }
                }
            }
            
            this.reportTKThang.LocalReport.DataSources.Clear();
            this.reportTKThang.LocalReport.DataSources.Add(new ReportDataSource("DataSetTheoNgay", listthang));
            this.reportTKThang.LocalReport.SetParameters(new ReportParameter("TieuDe", "Thống Kê Theo Tháng"));
            this.reportTKThang.LocalReport.SetParameters(new ReportParameter("ThoiGian", "Tháng: " + thang + " năm " + nam));
            this.reportTKThang.RefreshReport();
            this.reportTKThang.Refresh();
        }

        private void btntimtheonam_Click(object sender, EventArgs e)
        {
            string nam = cbbtheonam.SelectedItem.ToString();
            List<CTHoaDonBan> listnam = new List<CTHoaDonBan>();
            var thongke = adsv.ThongKeTheoNam(nam);
            int stt = 1;
            foreach (var kt in thongke)
            {
                var cthd = adsv.FindChiTietHoaDonBan(kt.MaHoaDon);
                foreach (var aa in cthd)
                {
                    var tensp = adsv.FindMaSanPham(aa.MaSP);
                    aa.MaSP = tensp.TenSP;
                    int dem = 0;
                    foreach (var li in listnam)
                        if (aa.MaSP == li.MaSP)
                        {
                            dem = 1;
                            li.SoLuong = li.SoLuong + aa.SoLuong;
                            break;
                        }
                    if (dem == 0)
                    {
                        aa.MaCTHoaDon = stt + "";
                        stt++;
                        listnam.Add(aa);
                    }
                }
            }
            
            this.reportTKNam.LocalReport.DataSources.Clear();
            this.reportTKNam.LocalReport.DataSources.Add(new ReportDataSource("DataSetTheoNgay", listnam));
            this.reportTKNam.LocalReport.SetParameters(new ReportParameter("TieuDe", "Thống Kê Theo Năm"));
            this.reportTKNam.LocalReport.SetParameters(new ReportParameter("ThoiGian", "Năm: " + nam));
            this.reportTKNam.RefreshReport();
            this.reportTKNam.Refresh();
        }
        public void CbbNam()
        {
            for (int i = 1950; i < 2100; i++)
                cbbtheonam.Items.Add(i);
        }
        public void CbbTheoThang()
        {
            for (int i = 1; i < 13; i++)
                cbbtimthang.Items.Add(i);            
        }
        public void CbbTheoNam()
        {
            for (int i = 1950; i < 2100; i++)
                cbbtimnam.Items.Add(i);
        }
    }
}
