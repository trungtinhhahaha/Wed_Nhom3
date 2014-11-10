namespace WindowsFormGiayPatin.AllUserControl.EditHoadon
{
    partial class Themhoadonnhap
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
            this.cTHoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbten = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.btnxoasp = new System.Windows.Forms.Button();
            this.btnthemhoadon = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datacthoadonnhap = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datasanpham = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaGiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacthoadonnhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // cTHoaDonNhapBindingSource
            // 
            this.cTHoaDonNhapBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.CTHoaDonNhap);
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.SanPham);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.lbten);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmasp);
            this.panel1.Controls.Add(this.txtgia);
            this.panel1.Controls.Add(this.btnxoasp);
            this.panel1.Controls.Add(this.btnthemhoadon);
            this.panel1.Controls.Add(this.btnthemsp);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 444);
            this.panel1.TabIndex = 1;
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(573, 357);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(84, 13);
            this.lbten.TabIndex = 18;
            this.lbten.Text = "Tên Đăng Nhập";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(560, 159);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(97, 20);
            this.txtsoluong.TabIndex = 8;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtmasp
            // 
            this.txtmasp.Enabled = false;
            this.txtmasp.Location = new System.Drawing.Point(560, 54);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 20);
            this.txtmasp.TabIndex = 4;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(560, 104);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(100, 20);
            this.txtgia.TabIndex = 3;
            // 
            // btnxoasp
            // 
            this.btnxoasp.Location = new System.Drawing.Point(589, 226);
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
            this.btnthemhoadon.Click += new System.EventHandler(this.btnthemhoadon_Click_1);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Location = new System.Drawing.Point(589, 197);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(33, 23);
            this.btnthemsp.TabIndex = 2;
            this.btnthemsp.Text = ">>";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datacthoadonnhap);
            this.groupBox2.Location = new System.Drawing.Point(663, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm đã chọn";
            // 
            // datacthoadonnhap
            // 
            this.datacthoadonnhap.AutoGenerateColumns = false;
            this.datacthoadonnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn1,
            this.giaDataGridViewTextBoxColumn1,
            this.soLuongDataGridViewTextBoxColumn1});
            this.datacthoadonnhap.DataSource = this.cTHoaDonNhapBindingSource;
            this.datacthoadonnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datacthoadonnhap.Location = new System.Drawing.Point(3, 16);
            this.datacthoadonnhap.Name = "datacthoadonnhap";
            this.datacthoadonnhap.Size = new System.Drawing.Size(394, 342);
            this.datacthoadonnhap.TabIndex = 0;
            this.datacthoadonnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacthoadonnhap_CellClick);
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
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datasanpham);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 361);
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
            this.datasanpham.Size = new System.Drawing.Size(541, 342);
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(843, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 23);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Themhoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 444);
            this.Controls.Add(this.panel1);
            this.Name = "Themhoadonnhap";
            this.Text = "Thêm hóa đơn nhập";
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datacthoadonnhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.BindingSource cTHoaDonNhapBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Button btnxoasp;
        private System.Windows.Forms.Button btnthemhoadon;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datacthoadonnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datasanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaGiamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Button btnThoat;
    }
}