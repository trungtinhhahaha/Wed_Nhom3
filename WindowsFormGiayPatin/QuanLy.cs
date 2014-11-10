using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGiayPatin
{
    public partial class QuanLy : Form
    {
        public QuanLy(string value)
        {
            InitializeComponent();
            lbten.Text = value;
            lbten.Hide();
            LoadMain();
        }
        public void LoadMain()//Load User Control Main_Chinh
        {
            var main = new WindowsFormGiayPatin.AllUserControl.Main_Chinh();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(main);
        }
        private void vềTrangChínhToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_Chinh
        {
            var main = new WindowsFormGiayPatin.AllUserControl.Main_Chinh();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(main);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)//Thoát chương trình
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)//đăng xuất và trở về Form đăng nhập
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_NguoiDung
        {
            var mainnd = new WindowsFormGiayPatin.AllUserControl.Main_NguoiDung();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(mainnd);
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_SanPham
        {
            var mainsp = new WindowsFormGiayPatin.AllUserControl.Main_SanPham();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(mainsp);
        }

        private void quảnLýPhânLoạiToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_PhanLoai
        {
            var mainpl = new WindowsFormGiayPatin.AllUserControl.Main_PhanLoai();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(mainpl);
        }

        private void quảnLýHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_HoaDonBan
        {
            var mainhdb = new WindowsFormGiayPatin.AllUserControl.Main_HoaDonBan(lbten.Text);
            panelmain.Controls.Clear();
            panelmain.Controls.Add(mainhdb);
        }

        private void quảnLýHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_HoaDonNhap
        {
            var mainhdn = new WindowsFormGiayPatin.AllUserControl.Main_HoaDonNhap(lbten.Text);
            panelmain.Controls.Clear();
            panelmain.Controls.Add(mainhdn);
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)//Load User Control Main_ThongKe
        {
            var mainthongke = new WindowsFormGiayPatin.AllUserControl.Main_ThongKe();
            panelmain.Controls.Clear();
            panelmain.Controls.Add(mainthongke);
        }
    }
}
