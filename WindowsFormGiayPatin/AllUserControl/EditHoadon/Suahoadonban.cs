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
    public partial class Suahoadonban : Form
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Suahoadonban(string mahd)
        {
            InitializeComponent();
            txtmahoadon.Text = mahd;
            cbtrangthai.SelectedIndex = 0;
        }

        private void btnluu_Click(object sender, EventArgs e)//Sữa trạng thái hóa đơn, cập nhật lại số lượng
        {
            try
            {
                if (cbtrangthai.SelectedIndex == 0)
                    MessageBox.Show("Chọn trạng thái hóa đơn!!!...");
                else
                {
                    string tinhtrang = "Hoàn thành";
                    if (cbtrangthai.SelectedIndex == 2)
                    {
                        tinhtrang = "Hủy";
                        var ktra = adsv.FindChiTietHoaDonBan(txtmahoadon.Text);
                        foreach (var kt in ktra)
                        {
                            adsv.UpdateSoLuong(kt.MaSP, kt.SoLuong);
                        }
                    }
                    adsv.UpdateHoaDonBan(txtmahoadon.Text, tinhtrang);
                    MessageBox.Show("Sửa thành công!!!...");
                    this.Close();
                }
            }
            catch {
                MessageBox.Show("Sửa thất bại!!!...");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
