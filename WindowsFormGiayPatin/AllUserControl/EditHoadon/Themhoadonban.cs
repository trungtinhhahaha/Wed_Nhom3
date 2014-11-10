using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormGiayPatin.ServiceReferenceAdmin;

namespace WindowsFormGiayPatin.AllUserControl.EditHoadon
{
    public partial class Themhoadonban : Form
    {
        AdminWinformClient adsv = new AdminWinformClient();
        List<SanPham> list = new List<SanPham>();
        public Themhoadonban(string value)
        {
            InitializeComponent();
            datasanpham.DataSource = adsv.FindAllSanPham();
            cbtinhtrang.SelectedIndex = 0;
            lbten.Text = value;
            lbten.Hide();
        }

        private void datasanpham_CellClick(object sender, DataGridViewCellEventArgs e)// Sự kiện cell click
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datasanpham.Rows[rowIndex];
                string masp = row.Cells[0].Value.ToString();
                txtmasp.Text = masp;
                txtsoluong.Text = "1";
                btnxoasp.Enabled = false;
                btnthemsp.Enabled = true;
            }
            catch { }
        }

        private void datacthoadonban_CellClick(object sender, DataGridViewCellEventArgs e)// Sự kiện cell click
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datacthoadonban.Rows[rowIndex];
                string masp = row.Cells[0].Value.ToString();
                string soluong = row.Cells[3].Value.ToString();
                txtmasp.Text = masp;
                txtsoluong.Text = soluong;
                btnthemsp.Enabled = true;
                btnxoasp.Enabled = true;
            }
            catch { }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)// Chỉ cho nhập số
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnthemsp_Click(object sender, EventArgs e)//Thêm mã sản phẩm và số lượng vào bảng datacthoadon
        {
            if (txtsoluong.Text == "0")
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!!!...");
            }
            else
            {
                if (txtmasp.Text != "")
                {
                    var sp = adsv.FindMaSanPham(txtmasp.Text);
                    int soluong = sp.SoLuong;
                    int dem = 0;
                    if (sp.SoLuong > Int32.Parse(txtsoluong.Text))
                        sp.SoLuong = Int32.Parse(txtsoluong.Text);
                    foreach (var ktra in list)
                    {
                        if (ktra.MaSP == sp.MaSP)
                        {
                            ktra.SoLuong = ktra.SoLuong + Int32.Parse(txtsoluong.Text);
                            if (ktra.SoLuong > soluong)
                                ktra.SoLuong = soluong;
                            dem = 1;
                        }
                    }
                    if (dem == 0)
                        list.Add(sp);

                    datacthoadonban.DataSource = null;
                    datacthoadonban.DataSource = list;
                }
            }
        }

        private void btnxoasp_Click(object sender, EventArgs e)//Xóa mã sản phẩm và số lượng từ bảng datacthoadon
        {
            if (txtmasp.Text != "")
            {
                var sp = adsv.FindMaSanPham(txtmasp.Text);
                foreach (var ktra in list)
                {
                    if (ktra.MaSP == sp.MaSP)
                    {
                        ktra.SoLuong = ktra.SoLuong - Int32.Parse(txtsoluong.Text);
                        if (ktra.SoLuong < 1)
                        {
                            list.Remove(ktra);
                            txtsoluong.Text = "";
                            txtmasp.Text = "";
                        }
                        break;
                    }
                }
                datacthoadonban.DataSource = null;
                datacthoadonban.DataSource = list;
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)// Chỉ cho phép nhập số
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        public bool ktra()//Ktra thông tin nhập
        {
            if(txthoten.Text == "")
            {
                MessageBox.Show("Nhập Họ tên!!!...");
                return false;
            }
            if (txtsdt.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại!!!...");
                return false;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ!!!...");
                return false;
            }
            return true;
        }
        private void btnthemhoadon_Click(object sender, EventArgs e)//Thêm hóa đơn bán
        {
            try
            {
                if (list.Count() > 0)
                {
                    if (ktra())
                    {
                        float tongtien = 0;
                        string mahd = DateTime.Now.Ticks.ToString();
                        string tendangnhap = lbten.Text;
                        foreach (var tong in list)
                        {
                            tongtien = tongtien + (float)tong.SoLuong * tong.Gia;
                        }
                        string tinhtrang = "Đang xử lý";
                        if (cbtinhtrang.SelectedIndex == 1)
                            tinhtrang = "Hoàn thành";
                        if (adsv.InsertHoaDonBan(mahd, tendangnhap, tinhtrang, txthoten.Text, txtsdt.Text, txtdiachi.Text, tongtien))
                        {
                            foreach (var ctsp in list)
                            {
                                adsv.InsertChiTietHoaDonBan(mahd, ctsp.MaSP, ctsp.SoLuong, ctsp.Gia, ctsp.GiaGiam);
                                adsv.DeleteSoLuong(ctsp.MaSP, ctsp.SoLuong);
                            }
                        }
                        MessageBox.Show("Thêm thành công!!!...");
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!!!...");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
