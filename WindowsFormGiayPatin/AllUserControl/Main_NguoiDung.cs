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

namespace WindowsFormGiayPatin.AllUserControl
{
    public partial class Main_NguoiDung : UserControl
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Main_NguoiDung()
        {
            InitializeComponent();
            datanguoidung.DataSource = adsv.FindAllNguoiDung();
            cbbquyen.SelectedIndex = 0;
        }
        // Chỉ cho phép nhập số
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        // Hiện thông tin người dùng theo từng hàng của table người dùng
        private void datanguoidung_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datanguoidung.Rows[rowIndex];
                txttendangnhap.Enabled = false;
                string tendangnhap = row.Cells[0].Value.ToString();
                string matkhau = row.Cells[1].Value.ToString();
                string hoten = row.Cells[2].Value.ToString();
                string quyen = row.Cells[3].Value.ToString();
                string gioitinh = row.Cells[4].Value.ToString();
                string ngaysinh = row.Cells[5].Value.ToString();
                string diachi = row.Cells[6].Value.ToString();
                string email = row.Cells[7].Value.ToString();
                string sdt = row.Cells[8].Value.ToString();
                txttendangnhap.Text = tendangnhap;
                txtmatkhau.Text = matkhau;
                txthoten.Text = hoten;
                if (quyen == "1")
                    cbbquyen.SelectedIndex = 0;
                else
                    cbbquyen.SelectedIndex = 1;
                if (gioitinh == "Nam")
                    rdnam.Checked = true;
                else
                    rdnu.Checked = true;
                datengaysinh.Value = DateTime.Parse(ngaysinh);
                txtsdt.Text = sdt;
                txtdiachi.Text = diachi;
                txtemail.Text = email;
            }
            catch { }
        }

        private void btntimkiem_Click(object sender, EventArgs e) // Tìm kiếm người dùng
        { 
            string timkiem = txttimkiem.Text;
            datanguoidung.DataSource = adsv.FindNguoiDung(timkiem);
        }

        private bool ktra()
        {
            if (txttendangnhap.Text == "")
            {
                MessageBox.Show("Nhập tên đăng nhập!!!...");
                return false;
            }
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Nhập tên mật khẩu!!!...");
                return false;
            }
            if (txthoten.Text == "")
            {
                MessageBox.Show("Nhập họ tên!!!...");
                return false;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ!!!...");
                return false;
            }
            return true;
                
        } // Ktra thông tin nhập

        public void Xoathongtin() // Xóa thông tin trên các trường
        {
            txttendangnhap.Text = "";
            txtmatkhau.Text = "";
            txtsdt.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            cbbquyen.SelectedIndex = 0;
            rdnam.Checked = true;
            datengaysinh.Value = DateTime.Today;
        }

        private void btnthem_Click(object sender, EventArgs e) // Thêm người dùng
        { 
            try
            {
                if (txttendangnhap.Enabled == false)
                {
                    txttendangnhap.Enabled = true;
                    Xoathongtin();
                }
                else
                {
                    if (ktra())
                    {
                        int quyen = 2;
                        string gioitinh = "Nam";
                        if (cbbquyen.SelectedIndex == 0)
                        {
                            quyen = 1;
                        }
                        if (rdnu.Checked == true)
                        {
                            gioitinh = "Nữ";
                        }
                        if (adsv.InsertNguoiDung(txttendangnhap.Text, txtmatkhau.Text, txthoten.Text, quyen, datengaysinh.Value.ToString(),
                        gioitinh, txtdiachi.Text, txtemail.Text, txtsdt.Text))
                        {
                            datanguoidung.DataSource = adsv.FindAllNguoiDung();
                            Xoathongtin();
                            MessageBox.Show("Thêm thành công !!!...");
                        }
                        else
                            MessageBox.Show("Thêm thất bại !!!...");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại !!!...");
            }

        }
        
        private void btnsua_Click(object sender, EventArgs e) // Sửa người dùng
        {
            try
            {
                if(txttendangnhap.Enabled == false)
                if (ktra())
                {
                    int quyen = 2;
                    string gioitinh = "Nam";
                    if (cbbquyen.SelectedIndex == 0)
                    {
                        quyen = 1;
                    }
                    if (rdnu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }
                    if (
                    adsv.UpdateNguoiDung(txttendangnhap.Text, txtmatkhau.Text, txthoten.Text, quyen, datengaysinh.Value.ToString(),
                        gioitinh, txtdiachi.Text, txtemail.Text, txtsdt.Text))
                    {
                        datanguoidung.DataSource = adsv.FindAllNguoiDung();
                        MessageBox.Show("Sửa thành công !!!...");
                    }
                    else
                        MessageBox.Show("Sửa thất bại !!!...");
                }
            }
            catch {
                MessageBox.Show("Sửa thất bại !!!...");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e) // Xóa người dùng
        {
            try
            {
                if (txttendangnhap.Text != "")
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa !!!...", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(adsv.DeleteNguoiDung(txttendangnhap.Text))
                        {
                            datanguoidung.DataSource = adsv.FindAllNguoiDung();
                            Xoathongtin();
                            MessageBox.Show("Xóa thành công !!!...");
                        }
                        else
                            MessageBox.Show("Xóa thất bại !!!..."); 
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại !!!...");
            }
        }

    }
}
