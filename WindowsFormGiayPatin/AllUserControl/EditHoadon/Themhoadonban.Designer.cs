namespace WindowsFormGiayPatin.AllUserControl.EditHoadon
{
    partial class Themhoadonban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnxoasp = new System.Windows.Forms.Button();
            this.btnthemhoadon = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datacthoadonban = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaGiamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTHoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datasanpham = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaGiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacthoadonban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.cbtinhtrang);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmasp);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.btnxoasp);
            this.panel1.Controls.Add(this.btnthemhoadon);
            this.panel1.Controls.Add(this.btnthemsp);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 444);
            this.panel1.TabIndex = 0;
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Items.AddRange(new object[] {
            "Đang xử lý",
            "Hoàn Thành"});
            this.cbtinhtrang.Location = new System.Drawing.Point(796, 21);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(139, 21);
            this.cbtinhtrang.TabIndex = 24;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(553, 22);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(139, 20);
            this.txtdiachi.TabIndex = 23;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(318, 22);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(139, 20);
            this.txtsdt.TabIndex = 22;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(60, 22);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(139, 20);
            this.txthoten.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tình trang:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Họ tên:";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(557, 348);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(84, 13);
            this.lbten.TabIndex = 19;
            this.lbten.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtmasp
            // 
            this.txtmasp.Enabled = false;
            this.txtmasp.Location = new System.Drawing.Point(558, 110);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 20);
            this.txtmasp.TabIndex = 4;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(558, 169);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 3;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // btnxoasp
            // 
            this.btnxoasp.Location = new System.Drawing.Point(586, 249);
            this.btnxoasp.Name = "btnxoasp";
            this.btnxoasp.Size = new System.Drawing.Size(33, 23);
            this.btnxoasp.TabIndex = 2;
            this.btnxoasp.Text = "<<";
            this.btnxoasp.UseVisualStyleBackColor = true;
            this.btnxoasp.Click += new System.EventHandler(this.btnxoasp_Click);
            // 
            // btnthemhoadon
            // 
            this.btnthemhoadon.Location = new System.Drawing.Point(956, 401);
            this.btnthemhoadon.Name = "btnthemhoadon";
            this.btnthemhoadon.Size = new System.Drawing.Size(107, 23);
            this.btnthemhoadon.TabIndex = 2;
            this.btnthemhoadon.Text = "Thêm";
            this.btnthemhoadon.UseVisualStyleBackColor = true;
            this.btnthemhoadon.Click += new System.EventHandler(this.btnthemhoadon_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Location = new System.Drawing.Point(586, 220);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(33, 23);
            this.btnthemsp.TabIndex = 2;
            this.btnthemsp.Text = ">>";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datacthoadonban);
            this.groupBox2.Location = new System.Drawing.Point(663, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm đã chọn";
            // 
            // datacthoadonban
            // 
            this.datacthoadonban.AutoGenerateColumns = false;
            this.datacthoadonban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn1,
            this.giaDataGridViewTextBoxColumn1,
            this.giaGiamDataGridViewTextBoxColumn1,
            this.soLuongDataGridViewTextBoxColumn1});
            this.datacthoadonban.DataSource = this.cTHoaDonBanBindingSource;
            this.datacthoadonban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datacthoadonban.Location = new System.Drawing.Point(3, 16);
            this.datacthoadonban.Name = "datacthoadonban";
            this.datacthoadonban.Size = new System.Drawing.Size(394, 292);
            this.datacthoadonban.TabIndex = 0;
            this.datacthoadonban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacthoadonban_CellClick);
            // 
            // maSPDataGridViewTextBoxColumn1
            // 
            this.maSPDataGridViewTextBoxColumn1.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn1.Name = "maSPDataGridViewTextBoxColumn1";
            // 
            // giaDataGridViewTextBoxColumn1
            // 
            this.giaDataGridViewTextBoxColumn1.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn1.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn1.Name = "giaDataGridViewTextBoxColumn1";
            // 
            // giaGiamDataGridViewTextBoxColumn1
            // 
            this.giaGiamDataGridViewTextBoxColumn1.DataPropertyName = "GiaGiam";
            this.giaGiamDataGridViewTextBoxColumn1.HeaderText = "Giá giảm";
            this.giaGiamDataGridViewTextBoxColumn1.Name = "giaGiamDataGridViewTextBoxColumn1";
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            // 
            // cTHoaDonBanBindingSource
            // 
            this.cTHoaDonBanBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.CTHoaDonBan);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datasanpham);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // datasanpham
            // 
            this.datasanpham.AutoGenerateColumns = false;
            this.datasanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.giaGiamDataGridViewTextBoxColumn});
            this.datasanpham.DataSource = this.sanPhamBindingSource;
            this.datasanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasanpham.Location = new System.Drawing.Point(3, 16);
            this.datasanpham.Name = "datasanpham";
            this.datasanpham.Size = new System.Drawing.Size(541, 292);
            this.datasanpham.TabIndex = 0;
            this.datasanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasanpham_CellClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // giaGiamDataGridViewTextBoxColumn
            // 
            this.giaGiamDataGridViewTextBoxColumn.DataPropertyName = "GiaGiam";
            this.giaGiamDataGridViewTextBoxColumn.HeaderText = "Giá giảm";
            this.giaGiamDataGridViewTextBoxColumn.Name = "giaGiamDataGridViewTextBoxColumn";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.SanPham);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(843, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 23);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Themhoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 444);
            this.Controls.Add(this.panel1);
            this.Name = "Themhoadonban";
            this.Text = "Thêm hóa đơn bán";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datacthoadonban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnxoasp;
        private System.Windows.Forms.Button btnthemhoadon;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datacthoadonban;
        private System.Windows.Forms.BindingSource cTHoaDonBanBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datasanpham;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaGiamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaGiamDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.ComboBox cbtinhtrang;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}