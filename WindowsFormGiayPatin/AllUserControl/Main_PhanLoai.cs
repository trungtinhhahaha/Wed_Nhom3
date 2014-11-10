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
    public partial class Main_PhanLoai : UserControl
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Main_PhanLoai()
        {
            InitializeComponent();
            dataphanloai.DataSource = adsv.FindAllPhanLoai();
        }
        // Hiện thông tin trên các trường theo các hàng của bảng phân loại
        private void dataphanloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataphanloai.Rows[rowIndex];
                txtmaloai.Enabled = false;
                string maloai = row.Cells[0].Value.ToString();
                string tenloai = row.Cells[1].Value.ToString();
                txtmaloai.Text = maloai;
                txttenloai.Text = tenloai;
            }
            catch { }
        }

        private void btntimkiem_Click(object sender, EventArgs e)// Tìm kiếm
        {
            string timkiem = txttimkiem.Text;
            dataphanloai.DataSource = adsv.FindPhanLoai(timkiem);
        }
        public bool ktra() // Kiểm tra thông tin nhập
        {
            if(txtmaloai.Text == "")
            {
                MessageBox.Show("Nhập mã loại!!!...");
                return false;
            }
            if(txttenloai.Text == "")
            {
                MessageBox.Show("Nhập tên loại!!!...");
                return false;
            }
            return true;

        }
        private void btnthem_Click(object sender, EventArgs e) // Thêm phân loại
        {
            try
            {
                if (txtmaloai.Enabled == false)
                {
                    txtmaloai.Enabled = true;
                    txtmaloai.Text = "";
                    txttenloai.Text = "";
                }
                else
                {
                    if (ktra())
                    {
                        if (adsv.InsertPhanLoai(txtmaloai.Text, txttenloai.Text))
                        {
                            dataphanloai.DataSource = adsv.FindAllPhanLoai();
                            txtmaloai.Text = "";
                            txttenloai.Text = "";
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

        private void btnsua_Click(object sender, EventArgs e) // Sửa phân loại
        {
            try
            {
                if (txtmaloai.Enabled == false)
                if (ktra())
                {
                    if (adsv.UpdatePhanLoai(txtmaloai.Text, txttenloai.Text))
                    {
                        dataphanloai.DataSource = adsv.FindAllPhanLoai();
                        MessageBox.Show("Sửa thành công !!!...");
                    }
                    else
                        MessageBox.Show("Sửa thất bại !!!...");
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại !!!...");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e) // Xóa phân loại
        {
            try
            {
                if (txtmaloai.Text != "")
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa !!!...", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (adsv.DeletePhanLoai(txtmaloai.Text))
                        {
                            dataphanloai.DataSource = adsv.FindAllPhanLoai();
                            txtmaloai.Text = "";
                            txttenloai.Text = "";
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
