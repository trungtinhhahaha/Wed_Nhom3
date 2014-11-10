namespace WindowsFormGiayPatin.AllUserControl
{
    partial class Main_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbmaloai = new System.Windows.Forms.ComboBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhinhanh = new System.Windows.Forms.Button();
            this.txthinhanh = new System.Windows.Forms.TextBox();
            this.txtgiagiam = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtkichco = new System.Windows.Forms.TextBox();
            this.txtloaimau = new System.Windows.Forms.TextBox();
            this.txtbaohanh = new System.Windows.Forms.TextBox();
            this.rdcu = new System.Windows.Forms.RadioButton();
            this.rdmoi = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datasanpham = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kichCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaGiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 532);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sản phẩm";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.lbtimkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 513);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbbmaloai);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnhinhanh);
            this.panel2.Controls.Add(this.txthinhanh);
            this.panel2.Controls.Add(this.txtgiagiam);
            this.panel2.Controls.Add(this.txtgia);
            this.panel2.Controls.Add(this.txtsoluong);
            this.panel2.Controls.Add(this.txtkichco);
            this.panel2.Controls.Add(this.txtloaimau);
            this.panel2.Controls.Add(this.txtbaohanh);
            this.panel2.Controls.Add(this.rdcu);
            this.panel2.Controls.Add(this.rdmoi);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txttensp);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtmasp);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.datasanpham);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 453);
            this.panel2.TabIndex = 16;
            // 
            // cbbmaloai
            // 
            this.cbbmaloai.FormattingEnabled = true;
            this.cbbmaloai.Location = new System.Drawing.Point(1084, 91);
            this.cbbmaloai.Name = "cbbmaloai";
            this.cbbmaloai.Size = new System.Drawing.Size(156, 21);
            this.cbbmaloai.TabIndex = 44;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(1165, 407);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(1082, 407);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 42;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(997, 407);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhinhanh
            // 
            this.btnhinhanh.Location = new System.Drawing.Point(1188, 371);
            this.btnhinhanh.Name = "btnhinhanh";
            this.btnhinhanh.Size = new System.Drawing.Size(52, 23);
            this.btnhinhanh.TabIndex = 40;
            this.btnhinhanh.Text = "...";
            this.btnhinhanh.UseVisualStyleBackColor = true;
            this.btnhinhanh.Click += new System.EventHandler(this.btnhinhanh_Click_1);
            // 
            // txthinhanh
            // 
            this.txthinhanh.Enabled = false;
            this.txthinhanh.Location = new System.Drawing.Point(1084, 371);
            this.txthinhanh.Name = "txthinhanh";
            this.txthinhanh.Size = new System.Drawing.Size(98, 20);
            this.txthinhanh.TabIndex = 39;
            // 
            // txtgiagiam
            // 
            this.txtgiagiam.Location = new System.Drawing.Point(1084, 336);
            this.txtgiagiam.Name = "txtgiagiam";
            this.txtgiagiam.Size = new System.Drawing.Size(156, 20);
            this.txtgiagiam.TabIndex = 38;
            this.txtgiagiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiagiam_KeyPress);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(1084, 301);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(156, 20);
            this.txtgia.TabIndex = 37;
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress_1);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(1084, 266);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(156, 20);
            this.txtsoluong.TabIndex = 36;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress_1);
            // 
            // txtkichco
            // 
            this.txtkichco.Location = new System.Drawing.Point(1084, 231);
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(156, 20);
            this.txtkichco.TabIndex = 35;
            // 
            // txtloaimau
            // 
            this.txtloaimau.Location = new System.Drawing.Point(1084, 195);
            this.txtloaimau.Name = "txtloaimau";
            this.txtloaimau.Size = new System.Drawing.Size(156, 20);
            this.txtloaimau.TabIndex = 34;
            // 
            // txtbaohanh
            // 
            this.txtbaohanh.Location = new System.Drawing.Point(1084, 160);
            this.txtbaohanh.Name = "txtbaohanh";
            this.txtbaohanh.Size = new System.Drawing.Size(156, 20);
            this.txtbaohanh.TabIndex = 33;
            this.txtbaohanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbaohanh_KeyPress);
            // 
            // rdcu
            // 
            this.rdcu.AutoSize = true;
            this.rdcu.Location = new System.Drawing.Point(1132, 125);
            this.rdcu.Name = "rdcu";
            this.rdcu.Size = new System.Drawing.Size(38, 17);
            this.rdcu.TabIndex = 31;
            this.rdcu.TabStop = true;
            this.rdcu.Text = "Cũ";
            this.rdcu.UseVisualStyleBackColor = true;
            // 
            // rdmoi
            // 
            this.rdmoi.AutoSize = true;
            this.rdmoi.Checked = true;
            this.rdmoi.Location = new System.Drawing.Point(1084, 123);
            this.rdmoi.Name = "rdmoi";
            this.rdmoi.Size = new System.Drawing.Size(42, 17);
            this.rdmoi.TabIndex = 31;
            this.rdmoi.TabStop = true;
            this.rdmoi.Text = "Mới";
            this.rdmoi.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(994, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hình ảnh:";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(1084, 56);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(156, 20);
            this.txttensp.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(994, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Giá giảm:";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(1084, 21);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(156, 20);
            this.txtmasp.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(994, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(994, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(994, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kích cở:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Loại màu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(994, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(994, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(994, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(994, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // datasanpham
            // 
            this.datasanpham.AutoGenerateColumns = false;
            this.datasanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.baoHanhDataGridViewTextBoxColumn,
            this.loaiMauDataGridViewTextBoxColumn,
            this.kichCoDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.giaGiamDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn});
            this.datasanpham.DataSource = this.sanPhamBindingSource;
            this.datasanpham.Location = new System.Drawing.Point(22, 21);
            this.datasanpham.Name = "datasanpham";
            this.datasanpham.Size = new System.Drawing.Size(936, 409);
            this.datasanpham.TabIndex = 11;
            this.datasanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasanpham_CellClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(445, 17);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 14;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(100, 17);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(321, 20);
            this.txttimkiem.TabIndex = 10;
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.Location = new System.Drawing.Point(30, 20);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(55, 13);
            this.lbtimkiem.TabIndex = 9;
            this.lbtimkiem.Text = "Tìm kiếm: ";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.SanPham);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã Loại";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // baoHanhDataGridViewTextBoxColumn
            // 
            this.baoHanhDataGridViewTextBoxColumn.DataPropertyName = "BaoHanh";
            this.baoHanhDataGridViewTextBoxColumn.HeaderText = "Bảo Hàng";
            this.baoHanhDataGridViewTextBoxColumn.Name = "baoHanhDataGridViewTextBoxColumn";
            // 
            // loaiMauDataGridViewTextBoxColumn
            // 
            this.loaiMauDataGridViewTextBoxColumn.DataPropertyName = "LoaiMau";
            this.loaiMauDataGridViewTextBoxColumn.HeaderText = "Loại Màu";
            this.loaiMauDataGridViewTextBoxColumn.Name = "loaiMauDataGridViewTextBoxColumn";
            // 
            // kichCoDataGridViewTextBoxColumn
            // 
            this.kichCoDataGridViewTextBoxColumn.DataPropertyName = "KichCo";
            this.kichCoDataGridViewTextBoxColumn.HeaderText = "Kích Cở";
            this.kichCoDataGridViewTextBoxColumn.Name = "kichCoDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
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
            this.giaGiamDataGridViewTextBoxColumn.HeaderText = "Giá Giảm";
            this.giaGiamDataGridViewTextBoxColumn.Name = "giaGiamDataGridViewTextBoxColumn";
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "Hình Ảnh";
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            // 
            // Main_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_SanPham";
            this.Size = new System.Drawing.Size(1284, 538);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datasanpham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdcu;
        private System.Windows.Forms.RadioButton rdmoi;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtkichco;
        private System.Windows.Forms.TextBox txtloaimau;
        private System.Windows.Forms.TextBox txtbaohanh;
        private System.Windows.Forms.TextBox txthinhanh;
        private System.Windows.Forms.TextBox txtgiagiam;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Button btnhinhanh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbbmaloai;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kichCoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaGiamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
    }
}
