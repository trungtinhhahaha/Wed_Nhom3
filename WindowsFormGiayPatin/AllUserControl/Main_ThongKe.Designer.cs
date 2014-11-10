namespace WindowsFormGiayPatin.AllUserControl
{
    partial class Main_ThongKe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cTHoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabngay = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportTKNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btntimtheongay = new System.Windows.Forms.Button();
            this.datetheongay = new System.Windows.Forms.DateTimePicker();
            this.tabthang = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbtimnam = new System.Windows.Forms.ComboBox();
            this.cbbtimthang = new System.Windows.Forms.ComboBox();
            this.reportTKThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btntimtheothang = new System.Windows.Forms.Button();
            this.tabnam = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbbtheonam = new System.Windows.Forms.ComboBox();
            this.reportTKNam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btntimtheonam = new System.Windows.Forms.Button();
            this.hoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabngay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabthang.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabnam.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cTHoaDonBanBindingSource
            // 
            this.cTHoaDonBanBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.CTHoaDonBan);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 513);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabngay);
            this.tabControl1.Controls.Add(this.tabthang);
            this.tabControl1.Controls.Add(this.tabnam);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1269, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabngay
            // 
            this.tabngay.Controls.Add(this.panel2);
            this.tabngay.Location = new System.Drawing.Point(4, 22);
            this.tabngay.Name = "tabngay";
            this.tabngay.Padding = new System.Windows.Forms.Padding(3);
            this.tabngay.Size = new System.Drawing.Size(1261, 481);
            this.tabngay.TabIndex = 0;
            this.tabngay.Text = "Theo ngày";
            this.tabngay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportTKNgay);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btntimtheongay);
            this.panel2.Controls.Add(this.datetheongay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 475);
            this.panel2.TabIndex = 0;
            // 
            // reportTKNgay
            // 
            reportDataSource1.Name = "DataSetTheoNgay";
            reportDataSource1.Value = this.cTHoaDonBanBindingSource;
            this.reportTKNgay.LocalReport.DataSources.Add(reportDataSource1);
            this.reportTKNgay.LocalReport.ReportEmbeddedResource = "WindowsFormGiayPatin.AllUserControl.Report1.rdlc";
            this.reportTKNgay.Location = new System.Drawing.Point(21, 77);
            this.reportTKNgay.Name = "reportTKNgay";
            this.reportTKNgay.Size = new System.Drawing.Size(661, 378);
            this.reportTKNgay.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormGiayPatin.Properties.Resources.aaa;
            this.panel3.Location = new System.Drawing.Point(832, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 300);
            this.panel3.TabIndex = 11;
            // 
            // btntimtheongay
            // 
            this.btntimtheongay.Location = new System.Drawing.Point(247, 26);
            this.btntimtheongay.Name = "btntimtheongay";
            this.btntimtheongay.Size = new System.Drawing.Size(75, 23);
            this.btntimtheongay.TabIndex = 8;
            this.btntimtheongay.Text = "Xem";
            this.btntimtheongay.UseVisualStyleBackColor = true;
            this.btntimtheongay.Click += new System.EventHandler(this.btntimtheongay_Click);
            // 
            // datetheongay
            // 
            this.datetheongay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetheongay.Location = new System.Drawing.Point(21, 26);
            this.datetheongay.Name = "datetheongay";
            this.datetheongay.Size = new System.Drawing.Size(200, 20);
            this.datetheongay.TabIndex = 7;
            this.datetheongay.Value = new System.DateTime(2014, 10, 29, 0, 0, 0, 0);
            // 
            // tabthang
            // 
            this.tabthang.Controls.Add(this.panel4);
            this.tabthang.Location = new System.Drawing.Point(4, 22);
            this.tabthang.Name = "tabthang";
            this.tabthang.Padding = new System.Windows.Forms.Padding(3);
            this.tabthang.Size = new System.Drawing.Size(1261, 481);
            this.tabthang.TabIndex = 2;
            this.tabthang.Text = "Theo tháng";
            this.tabthang.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbtimnam);
            this.panel4.Controls.Add(this.cbbtimthang);
            this.panel4.Controls.Add(this.reportTKThang);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btntimtheothang);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1255, 475);
            this.panel4.TabIndex = 1;
            // 
            // cbbtimnam
            // 
            this.cbbtimnam.FormattingEnabled = true;
            this.cbbtimnam.Location = new System.Drawing.Point(115, 26);
            this.cbbtimnam.Name = "cbbtimnam";
            this.cbbtimnam.Size = new System.Drawing.Size(106, 21);
            this.cbbtimnam.TabIndex = 16;
            // 
            // cbbtimthang
            // 
            this.cbbtimthang.FormattingEnabled = true;
            this.cbbtimthang.Location = new System.Drawing.Point(21, 26);
            this.cbbtimthang.Name = "cbbtimthang";
            this.cbbtimthang.Size = new System.Drawing.Size(88, 21);
            this.cbbtimthang.TabIndex = 15;
            // 
            // reportTKThang
            // 
            reportDataSource2.Name = "DataSetTheoNgay";
            reportDataSource2.Value = this.cTHoaDonBanBindingSource;
            this.reportTKThang.LocalReport.DataSources.Add(reportDataSource2);
            this.reportTKThang.LocalReport.ReportEmbeddedResource = "WindowsFormGiayPatin.AllUserControl.Report1.rdlc";
            this.reportTKThang.Location = new System.Drawing.Point(21, 77);
            this.reportTKThang.Name = "reportTKThang";
            this.reportTKThang.Size = new System.Drawing.Size(661, 378);
            this.reportTKThang.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WindowsFormGiayPatin.Properties.Resources.aaa;
            this.panel5.Location = new System.Drawing.Point(832, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 300);
            this.panel5.TabIndex = 11;
            // 
            // btntimtheothang
            // 
            this.btntimtheothang.Location = new System.Drawing.Point(247, 26);
            this.btntimtheothang.Name = "btntimtheothang";
            this.btntimtheothang.Size = new System.Drawing.Size(75, 23);
            this.btntimtheothang.TabIndex = 8;
            this.btntimtheothang.Text = "Xem";
            this.btntimtheothang.UseVisualStyleBackColor = true;
            this.btntimtheothang.Click += new System.EventHandler(this.btntimtheothang_Click);
            // 
            // tabnam
            // 
            this.tabnam.Controls.Add(this.panel6);
            this.tabnam.Location = new System.Drawing.Point(4, 22);
            this.tabnam.Name = "tabnam";
            this.tabnam.Padding = new System.Windows.Forms.Padding(3);
            this.tabnam.Size = new System.Drawing.Size(1261, 481);
            this.tabnam.TabIndex = 3;
            this.tabnam.Text = "Theo năm";
            this.tabnam.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbbtheonam);
            this.panel6.Controls.Add(this.reportTKNam);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.btntimtheonam);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1255, 475);
            this.panel6.TabIndex = 1;
            // 
            // cbbtheonam
            // 
            this.cbbtheonam.FormattingEnabled = true;
            this.cbbtheonam.Location = new System.Drawing.Point(21, 26);
            this.cbbtheonam.Name = "cbbtheonam";
            this.cbbtheonam.Size = new System.Drawing.Size(200, 21);
            this.cbbtheonam.TabIndex = 15;
            // 
            // reportTKNam
            // 
            reportDataSource3.Name = "DataSetTheoNgay";
            reportDataSource3.Value = this.cTHoaDonBanBindingSource;
            this.reportTKNam.LocalReport.DataSources.Add(reportDataSource3);
            this.reportTKNam.LocalReport.ReportEmbeddedResource = "WindowsFormGiayPatin.AllUserControl.Report1.rdlc";
            this.reportTKNam.Location = new System.Drawing.Point(21, 77);
            this.reportTKNam.Name = "reportTKNam";
            this.reportTKNam.Size = new System.Drawing.Size(661, 378);
            this.reportTKNam.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::WindowsFormGiayPatin.Properties.Resources.aaa;
            this.panel7.Location = new System.Drawing.Point(832, 105);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(311, 300);
            this.panel7.TabIndex = 11;
            // 
            // btntimtheonam
            // 
            this.btntimtheonam.Location = new System.Drawing.Point(247, 26);
            this.btntimtheonam.Name = "btntimtheonam";
            this.btntimtheonam.Size = new System.Drawing.Size(75, 23);
            this.btntimtheonam.TabIndex = 8;
            this.btntimtheonam.Text = "Xem";
            this.btntimtheonam.UseVisualStyleBackColor = true;
            this.btntimtheonam.Click += new System.EventHandler(this.btntimtheonam_Click);
            // 
            // hoaDonBanBindingSource
            // 
            this.hoaDonBanBindingSource.DataSource = typeof(WindowsFormGiayPatin.ServiceReferenceAdmin.HoaDonBan);
            // 
            // Main_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_ThongKe";
            this.Size = new System.Drawing.Size(1284, 538);
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabngay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabthang.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabnam.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabngay;
        private System.Windows.Forms.TabPage tabthang;
        private System.Windows.Forms.TabPage tabnam;
        private System.Windows.Forms.BindingSource cTHoaDonBanBindingSource;
        private System.Windows.Forms.BindingSource hoaDonBanBindingSource;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportTKNgay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btntimtheongay;
        private System.Windows.Forms.DateTimePicker datetheongay;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer reportTKThang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btntimtheothang;
        private System.Windows.Forms.Panel panel6;
        private Microsoft.Reporting.WinForms.ReportViewer reportTKNam;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btntimtheonam;
        private System.Windows.Forms.ComboBox cbbtimnam;
        private System.Windows.Forms.ComboBox cbbtimthang;
        private System.Windows.Forms.ComboBox cbbtheonam;
    }
}
