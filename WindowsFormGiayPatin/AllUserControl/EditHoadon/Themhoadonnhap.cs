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
    public partial class Themhoadonnhap : Form
    {
        AdminWinformClient adsv = new AdminWinformClient();
        List<SanPham> list = new List<SanPham>();
        public Themhoadonnhap(string value)
        {
            InitializeComponent();
            datasanpham.DataSource = adsv.FindAllSanPham();
            lbten.Text = value;
            lbten.Hide();
        }
    
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)//Chỉ nhập số
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void datasanpham_CellClick(object sender, DataGridViewCellEventArgs e)// Sự kiện cell click
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datasanpham.Rows[rowIndex];
                string masp = row.Cells[0].Value.ToString();
                string gia = row.Cells[3].Value.ToString();
                txtmasp.Text = masp;
                txtgia.Text = gia;
                txtsoluong.Text = "1";
                btnxoasp.Enabled = false;
                btnthemsp.Enabled = true;
            }
            catch { }
        }

        private void datacthoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)// Sự kiện cell click
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datacthoadonnhap.Rows[rowIndex];
                string masp = row.Cells[0].Value.ToString();
                string gia = row.Cells[1].Value.ToString();
                string soluong = row.Cells[2].Value.ToString();
                txtmasp.Text = masp;
                txtgia.Text = gia;
                txtsoluong.Text = soluong;
                btnxoasp.Enabled = true;
                btnthemsp.Enabled = true;
            }
            catch { }
        }

        private void btnthemsp_Click(object sender, EventArgs e)//Thêm sản phẩm và số lượng vào bảng datacthoadonnhap
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
                    sp.Gia = Int32.Parse(txtgia.Text);
                    sp.SoLuong = Int32.Parse(txtsoluong.Text);
                    foreach (var ktra in list)
                    {
                        if (ktra.MaSP == sp.MaSP)
                        {
                            ktra.SoLuong = ktra.SoLuong + Int32.Parse(txtsoluong.Text);
                            ktra.Gia = Int32.Parse(txtgia.Text);
                            dem = 1;
                        }
                    }
                    if (dem == 0)
                        list.Add(sp);

                    datacthoadonnhap.DataSource = null;
                    datacthoadonnhap.DataSource = list;
                }
            }
        }

        private void btnxoasp_Click(object sender, EventArgs e)//Xóa sản phẩm và số lượng từ bảng datacthoadonnhap 
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
                            txtgia.Text = "";
                        }
                        break;
                    }
                }
                datacthoadonnhap.DataSource = null;
                datacthoadonnhap.DataSource = list;
            }
        }

        private void btnthemhoadon_Click_1(object sender, EventArgs e)//Thêm hóa đơn nhập
        {
            try
            {
                if (list.Count() > 0)
                {
                    float tongtien = 0;
                    string mahd = DateTime.Now.Ticks.ToString();
                    string tendangnhap = lbten.Text;
                    foreach (var tong in list)
                    {
                        tongtien = tongtien + (float)tong.SoLuong * tong.Gia;
                    }
                    if (adsv.InsertHoaDonNhap(mahd, tendangnhap, tongtien))
                    {
                        foreach (var ctsp in list)
                        {
                            adsv.InsertChiTietHoaDonNhap(mahd, ctsp.MaSP, ctsp.SoLuong, ctsp.Gia);
                            adsv.UpdateSoLuong(ctsp.MaSP, ctsp.SoLuong);
                        }
                    }
                    MessageBox.Show("Thêm thành công!!!...");
                    this.Close();
                }
            }
            catch {
                MessageBox.Show("Thêm thất bại!!!...");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
