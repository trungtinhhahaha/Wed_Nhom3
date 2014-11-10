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
    public partial class Main_HoaDonNhap : UserControl
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Main_HoaDonNhap(string value)
        {
            InitializeComponent();
            datahoadonnhap.DataSource = adsv.FindAllHoaDonNhap();
            lbten.Text = value;
            lbten.Hide();
        }

        private void btntimkiem_Click(object sender, EventArgs e)// Tìm kiếm
        {
            string timkiem = txttimkiem.Text;
            datahoadonnhap.DataSource = adsv.FindHoaDonNhap(timkiem);
        }

        private void btnthem_Click(object sender, EventArgs e)// Hiện Form Themhoadonban
        { 
            EditHoadon.Themhoadonnhap hdn = new EditHoadon.Themhoadonnhap(lbten.Text);            
            hdn.Show();
        }
        // Hiện chi tiết hóa đơn nhập theo mã hóa đơn
        private void datahoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datahoadonnhap.Rows[rowIndex];
                string mahd = row.Cells[0].Value.ToString();
                datachitiethdn.DataSource = adsv.FindChiTietHoaDonNhap(mahd);
            }
            catch { }
        }

        private void btncapnhat_Click(object sender, EventArgs e)// Cập nhật lại bảng hóa đơn nhập
        { 
            datahoadonnhap.DataSource = adsv.FindAllHoaDonNhap();
        }
    }
}
