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
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormGiayPatin.AllUserControl
{
    public partial class Main_SanPham : UserControl
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Main_SanPham()
        {
            InitializeComponent();
            datasanpham.DataSource = adsv.FindAllSanPham();
            loadcbbox();
        }
        private void loadcbbox()
        {
            PhanLoai[] d = adsv.FindAllPhanLoai();
            cbbmaloai.DataSource = d;
            cbbmaloai.DisplayMember = "TenLoai";
            cbbmaloai.ValueMember = "MaLoai";
            cbbmaloai.SelectedIndex = 0;
        }
        private void txtbaohanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void txtsoluong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtgia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtgiagiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        OpenFileDialog fd1 = new OpenFileDialog();
        private void btnhinhanh_Click_1(object sender, EventArgs e)
        {
            fd1.Filter = "image files|*.jpg;*.png;.*gif;*.icon;.*;";
            DialogResult dres2 = fd1.ShowDialog();
            if (dres2 == DialogResult.Abort)
                return;
            if (dres2 == DialogResult.Cancel)
                return;
            using (var stream = File.OpenRead(fd1.FileName))
            {
                byte[] imageData = new byte[stream.Length];
                stream.Read(imageData, 0, imageData.Length);
                if(imageData.Length > 200000)
                {
                    MessageBox.Show("Duong lượng hình ảnh quá lớn");
                }
                else
                {
                    txthinhanh.Text = fd1.FileName;
                }
            }
        }
        
        private void datasanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datasanpham.Rows[rowIndex];
                txtmasp.Enabled = false;
                string masp = row.Cells[0].Value.ToString();
                string tensp = row.Cells[1].Value.ToString();
                string maloai = row.Cells[2].Value.ToString();
                string trangthai = row.Cells[3].Value.ToString();
                string baohanh = row.Cells[4].Value.ToString();
                string loaimau = row.Cells[5].Value.ToString();
                string kichco = row.Cells[6].Value.ToString();
                string soluong = row.Cells[7].Value.ToString();
                string gia = row.Cells[8].Value.ToString();
                string giagiam = row.Cells[9].Value.ToString();
                txtmasp.Text = masp;
                txttensp.Text = tensp;
                cbbmaloai.SelectedValue = maloai.Trim();
                if (trangthai == "Mới")
                    rdmoi.Checked = true;
                else
                    rdcu.Checked = true;
                txtbaohanh.Text = baohanh;
                txtloaimau.Text = loaimau;
                txtkichco.Text = kichco;
                txtsoluong.Text = soluong;
                txtgia.Text = gia;
                txtgiagiam.Text = giagiam;
                //byte[] imge = (byte[])row.Cells[10].Value;
                //byte[] img_arr1 = (byte[])imge;
                //    MemoryStream ms1 = new MemoryStream(img_arr1);
                //    ms1.Seek(0, SeekOrigin.Begin);
                //    pictureBox1.Image = Image.FromStream(ms1);
            }
            catch { }
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            datasanpham.DataSource = adsv.FindSanPham(timkiem);
        }
        public void Xoathongtin()
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            cbbmaloai.SelectedIndex = 0;
            rdmoi.Checked = true;
            txtbaohanh.Text = "";
            txtloaimau.Text = "";
            txtkichco.Text = "";
            txtsoluong.Text = "";
            txtgia.Text = "";
            txtgiagiam.Text = "";
            txthinhanh.Text = "";
        }
        private bool ktra()
        {
            if (txtmasp.Text == "")
            {
                MessageBox.Show("Nhập mã sản phẩm!!!...");
                return false;
            }
            if (txttensp.Text == "")
            {
                MessageBox.Show("Nhập tên sản phẩm!!!...");
                return false;
            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Nhập số lượng!!!...");
                return false;
            }
            if (txtgia.Text == "")
            {
                MessageBox.Show("Nhập giá!!!...");
                return false;
            }
            //if (txthinhanh.Text == "")
            //{
            //    MessageBox.Show("Chọn hình ảnh!!!...");
            //    return false;
            //}
            return true;

        }
        //byte[] ReadFile(string sPath)
        //{
        //    byte[] data = null;
        //    FileInfo fInfo = new FileInfo(sPath);
        //    long numBytes = fInfo.Length;
        //    FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fStream);
        //    data = br.ReadBytes((int)numBytes);

        //    return data;
        //}

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasp.Enabled == false)
                {
                    txtmasp.Enabled = true;
                    Xoathongtin();
                }
                else
                {
                    if (ktra())
                        if (txthinhanh.Text == "")
                            MessageBox.Show("Chọn Hình Ảnh!!!...");
                        else
                        {
                            //byte[] imageData = null;
                            //if (txthinhanh.Text != "")
                            //    imageData = ReadFile(txthinhanh.Text);
                            string trangthai = "Mới";
                            if (rdcu.Checked)
                                trangthai = "Cũ";
                            if (txtbaohanh.Text == "")
                                txtbaohanh.Text = "0";
                            if (txtgiagiam.Text == "")
                                txtgiagiam.Text = "0";
                            if (adsv.InsertSanPham(txtmasp.Text, txttensp.Text, cbbmaloai.SelectedValue.ToString(), Int32.Parse(txtbaohanh.Text), trangthai, txtloaimau.Text,
                               txtkichco.Text, Int32.Parse(txtsoluong.Text), Int32.Parse(txtgia.Text), Int32.Parse(txtgiagiam.Text), txthinhanh.Text))
                            {
                                datasanpham.DataSource = adsv.FindAllSanPham();
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasp.Enabled == false)
                    if (ktra())
                    {
                        string trangthai = "Mới";
                        if (rdcu.Checked)
                            trangthai = "Cũ";
                        if (txtbaohanh.Text == "")
                            txtbaohanh.Text = "0";
                        if (txtgiagiam.Text == "")
                            txtgiagiam.Text = "0";
                        if (adsv.UpdateSanPham(txtmasp.Text, txttensp.Text, cbbmaloai.SelectedValue.ToString(), Int32.Parse(txtbaohanh.Text), trangthai, txtloaimau.Text,
                           txtkichco.Text, Int32.Parse(txtsoluong.Text), Int32.Parse(txtgia.Text), Int32.Parse(txtgiagiam.Text), txthinhanh.Text))
                        {
                            datasanpham.DataSource = adsv.FindAllSanPham();
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasp.Text != "")
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa !!!...", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (adsv.DeleteSanPham(txtmasp.Text))
                        {
                            datasanpham.DataSource = adsv.FindAllSanPham();
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
