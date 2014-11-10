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
    public partial class Main_HoaDonBan : UserControl
    {
        AdminWinformClient adsv = new AdminWinformClient();
        public Main_HoaDonBan(string value)
        {
            InitializeComponent();
            datahoadonban.DataSource = adsv.FindAllHoaDonBan(); // Hiện tất cả hóa đơn bán vào bảng datahoadonban
            lbten.Text = value;
            lbten.Hide();
            btnsua.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)// Hiện Form Themhoadonban
        {
            EditHoadon.Themhoadonban hdb = new EditHoadon.Themhoadonban(lbten.Text);
            hdb.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)// Hiện Form Suahoadonban
        {    
            EditHoadon.Suahoadonban hdb = new EditHoadon.Suahoadonban(lbmahd.Text);
            hdb.Show();  
        }

        private void btntimkiem_Click(object sender, EventArgs e)//Tìm kiếm
        {
            string timkiem = txttimkiem.Text;
            datahoadonban.DataSource = adsv.FindHoaDonBan(timkiem);
        }
        // Nếu hóa đơn có tình trạng = "Đang xử lý" thì cho phép sửa, Hiện chi tiết hóa đơn
        private void datahoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            { 
                int rowIndex = e.RowIndex;
                DataGridViewRow row = datahoadonban.Rows[rowIndex];
                string mahd = row.Cells[0].Value.ToString();
                lbmahd.Text = mahd;
                lbtinhtrang.Text = row.Cells[5].Value.ToString();
                if (lbtinhtrang.Text == "Đang xử lý")
                    btnsua.Enabled = true;
                else
                    btnsua.Enabled = false;
                lbmahd.Hide();
                lbtinhtrang.Hide();
                datachitiethdb.DataSource = adsv.FindChiTietHoaDonBan(mahd);
            }
            catch { }
        }

        private void btncapnhat_Click(object sender, EventArgs e)// cập nhật lại bảng hóa đơn bán
        {
            datahoadonban.DataSource = adsv.FindAllHoaDonBan();
        }
    }
}
