namespace WindowsFormGiayPatin.AllUserControl
{
    partial class Main_HoaDonNhap
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
            this.lbten = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datachitiethdn = new System.Windows.Forms.DataGridView();
            this.maCTHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTHoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnthem = new System.Windows.Forms.Button();
            this.datahoadonnhap = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachitiethdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datahoadonnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 532);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hóa đơn nhập";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.lbten);
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
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(716, 27);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(84, 13);
            this.lbten.TabIndex = 17;
            this.lbten.Text = "Tên Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btncapnhat);
            this.panel2.Controls.Add(this.datachitiethdn);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.datahoadonnhap);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 453);
            this.panel2.TabIndex = 16;
            // 
            // datachitiethdn
            // 
            this.datachitiethdn.AutoGenerateColumns = false;
            this.datachitiethdn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCTHoaDonDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn});
            this.datachitiethdn.DataSource = this.cTHoaDonNhapBindingSource;
            this.datachitiethdn.Location = new System.Drawing.Point(715, 21);
            this.datachitiethdn.Name = "datachitiethdn";
            this.datachitiethdn.Size = new System.Drawing.Size(525, 292);
            this.datachitiethdn.TabIndex = 30;
            // 
            // maCTHoaDonDataGridViewTextBoxColumn
            // 
            this.maCTHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaCTHoaDon";
            this.maCTHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã chi tiết HD";
            this.maCTHoaDonDataGridViewTextBoxColumn.Name = "maCTHoaDonDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // cTHoaDonNhapBindingSource
            // 
            this.cTHoaDonNhapBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.CTHoaDonNhap);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(1165, 407);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 29;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datahoadonnhap
            // 
            this.datahoadonnhap.AllowUserToOrderColumns = true;
            this.datahoadonnhap.AutoGenerateColumns = false;
            this.datahoadonnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.datahoadonnhap.DataSource = this.hoaDonNhapBindingSource;
            this.datahoadonnhap.Location = new System.Drawing.Point(22, 21);
            this.datahoadonnhap.Name = "datahoadonnhap";
            this.datahoadonnhap.Size = new System.Drawing.Size(667, 409);
            this.datahoadonnhap.TabIndex = 11;
            this.datahoadonnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datahoadonnhap_CellClick);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // hoaDonNhapBindingSource
            // 
            this.hoaDonNhapBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.HoaDonNhap);
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
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(715, 333);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 33;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // Main_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_HoaDonNhap";
            this.Size = new System.Drawing.Size(1278, 532);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datachitiethdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datahoadonnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datachitiethdn;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView datahoadonnhap;
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.BindingSource cTHoaDonNhapBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Button btncapnhat;
    }
}
