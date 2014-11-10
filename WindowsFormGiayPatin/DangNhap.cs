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

namespace WindowsFormGiayPatin
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)//Thoát chương trình
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)// Ktra đăng nhập nếu đúng thì hiện Form Quanly
        {
            AdminWinformClient adsv = new AdminWinformClient();
            if(adsv.DangNhapNguoiDung(txtdangnhap.Text, txtmatkhau.Text))
            {
                QuanLy ql = new QuanLy(txtdangnhap.Text);
                ql.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!!...");
            }
        }
    }
}
