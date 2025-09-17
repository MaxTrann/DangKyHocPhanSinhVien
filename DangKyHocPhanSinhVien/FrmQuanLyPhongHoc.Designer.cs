namespace DangKyHocPhanSinhVien
{
    partial class FrmQuanLyPhongHoc
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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.btnTimLopHoc = new System.Windows.Forms.Button();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlThem = new System.Windows.Forms.Panel();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThemLopHoc = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaMHDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapMaLopHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.numTietBD = new System.Windows.Forms.NumericUpDown();
            this.numTietKT = new System.Windows.Forms.NumericUpDown();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.pnlTimKiem.SuspendLayout();
            this.pnlThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietKT)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1453, 54);
            this.label4.TabIndex = 84;
            this.label4.Text = "Quản lý phòng học ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimKiem.Controls.Add(this.btnTimLopHoc);
            this.pnlTimKiem.Controls.Add(this.txtMaLopHoc);
            this.pnlTimKiem.Controls.Add(this.btnXoa);
            this.pnlTimKiem.Controls.Add(this.label5);
            this.pnlTimKiem.Controls.Add(this.label6);
            this.pnlTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTimKiem.Location = new System.Drawing.Point(16, 78);
            this.pnlTimKiem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1453, 74);
            this.pnlTimKiem.TabIndex = 85;
            // 
            // btnTimLopHoc
            // 
            this.btnTimLopHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLopHoc.Location = new System.Drawing.Point(1167, 14);
            this.btnTimLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTimLopHoc.Name = "btnTimLopHoc";
            this.btnTimLopHoc.Size = new System.Drawing.Size(127, 44);
            this.btnTimLopHoc.TabIndex = 80;
            this.btnTimLopHoc.Text = "Tìm kiếm";
            this.btnTimLopHoc.UseVisualStyleBackColor = false;
            this.btnTimLopHoc.Click += new System.EventHandler(this.btnTimLopHoc_Click);
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLopHoc.Location = new System.Drawing.Point(172, 23);
            this.txtMaLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(229, 32);
            this.txtMaLopHoc.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1310, 14);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 44);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Lớp Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 0;
            // 
            // pnlThem
            // 
            this.pnlThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThem.Controls.Add(this.dtpTGKT);
            this.pnlThem.Controls.Add(this.dtpTGBD);
            this.pnlThem.Controls.Add(this.numTietKT);
            this.pnlThem.Controls.Add(this.numTietBD);
            this.pnlThem.Controls.Add(this.cboHK);
            this.pnlThem.Controls.Add(this.cboGiangVien);
            this.pnlThem.Controls.Add(this.label18);
            this.pnlThem.Controls.Add(this.cboThu);
            this.pnlThem.Controls.Add(this.label15);
            this.pnlThem.Controls.Add(this.txtNam);
            this.pnlThem.Controls.Add(this.label16);
            this.pnlThem.Controls.Add(this.btnThemLopHoc);
            this.pnlThem.Controls.Add(this.label17);
            this.pnlThem.Controls.Add(this.label12);
            this.pnlThem.Controls.Add(this.label13);
            this.pnlThem.Controls.Add(this.label14);
            this.pnlThem.Controls.Add(this.label10);
            this.pnlThem.Controls.Add(this.txtPhong);
            this.pnlThem.Controls.Add(this.label11);
            this.pnlThem.Controls.Add(this.txtSoLuong);
            this.pnlThem.Controls.Add(this.label8);
            this.pnlThem.Controls.Add(this.label9);
            this.pnlThem.Controls.Add(this.txtMaMHDT);
            this.pnlThem.Controls.Add(this.label1);
            this.pnlThem.Controls.Add(this.txtNhapMaLopHoc);
            this.pnlThem.Controls.Add(this.label2);
            this.pnlThem.Controls.Add(this.label3);
            this.pnlThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlThem.Location = new System.Drawing.Point(16, 164);
            this.pnlThem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlThem.Name = "pnlThem";
            this.pnlThem.Size = new System.Drawing.Size(1453, 256);
            this.pnlThem.TabIndex = 86;
            // 
            // cboHK
            // 
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Location = new System.Drawing.Point(648, 126);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(204, 34);
            this.cboHK.TabIndex = 104;
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.FormattingEnabled = true;
            this.cboGiangVien.Location = new System.Drawing.Point(170, 71);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(256, 34);
            this.cboGiangVien.TabIndex = 103;
            // 
            // cboThu
            // 
            this.cboThu.FormattingEnabled = true;
            this.cboThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.cboThu.Location = new System.Drawing.Point(1081, 71);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(204, 34);
            this.cboThu.TabIndex = 102;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(911, 185);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 25);
            this.label15.TabIndex = 99;
            this.label15.Text = "TG kết thúc";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(648, 181);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(204, 32);
            this.txtNam.TabIndex = 98;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(497, 185);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 25);
            this.label16.TabIndex = 97;
            this.label16.Text = "Năm";
            // 
            // btnThemLopHoc
            // 
            this.btnThemLopHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLopHoc.Location = new System.Drawing.Point(1310, 104);
            this.btnThemLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemLopHoc.Name = "btnThemLopHoc";
            this.btnThemLopHoc.Size = new System.Drawing.Size(127, 53);
            this.btnThemLopHoc.TabIndex = 79;
            this.btnThemLopHoc.Text = "Thêm";
            this.btnThemLopHoc.UseVisualStyleBackColor = false;
            this.btnThemLopHoc.Click += new System.EventHandler(this.btnThemLopHoc_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 187);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 25);
            this.label17.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(911, 131);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 93;
            this.label12.Text = "TG bắt đầu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 185);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 25);
            this.label13.TabIndex = 91;
            this.label13.Text = "Tiết kết thúc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 25);
            this.label14.TabIndex = 89;
            this.label14.Text = "Tiết bắt đầu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 87;
            this.label10.Text = "Thứ";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(1081, 15);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(204, 32);
            this.txtPhong.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(911, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 85;
            this.label11.Text = "Phòng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(648, 72);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(204, 32);
            this.txtSoLuong.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 83;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = "Giảng viên";
            // 
            // txtMaMHDT
            // 
            this.txtMaMHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMHDT.Location = new System.Drawing.Point(648, 19);
            this.txtMaMHDT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaMHDT.Name = "txtMaMHDT";
            this.txtMaMHDT.Size = new System.Drawing.Size(204, 32);
            this.txtMaMHDT.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã MHDT";
            // 
            // txtNhapMaLopHoc
            // 
            this.txtNhapMaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaLopHoc.Location = new System.Drawing.Point(170, 15);
            this.txtNhapMaLopHoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNhapMaLopHoc.Name = "txtNhapMaLopHoc";
            this.txtNhapMaLopHoc.Size = new System.Drawing.Size(256, 32);
            this.txtNhapMaLopHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(497, 131);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 25);
            this.label18.TabIndex = 101;
            this.label18.Text = "Học kỳ";
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(16, 431);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.RowTemplate.Height = 24;
            this.dgvLopHoc.Size = new System.Drawing.Size(1453, 350);
            this.dgvLopHoc.TabIndex = 104;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1312, 791);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 53);
            this.btnBack.TabIndex = 111;
            this.btnBack.Text = "Quay trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numTietBD
            // 
            this.numTietBD.Location = new System.Drawing.Point(170, 127);
            this.numTietBD.Name = "numTietBD";
            this.numTietBD.Size = new System.Drawing.Size(163, 32);
            this.numTietBD.TabIndex = 105;
            // 
            // numTietKT
            // 
            this.numTietKT.Location = new System.Drawing.Point(170, 181);
            this.numTietKT.Name = "numTietKT";
            this.numTietKT.Size = new System.Drawing.Size(163, 32);
            this.numTietKT.TabIndex = 106;
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.Location = new System.Drawing.Point(1081, 127);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.Size = new System.Drawing.Size(204, 32);
            this.dtpTGBD.TabIndex = 107;
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.Location = new System.Drawing.Point(1081, 181);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.Size = new System.Drawing.Size(204, 32);
            this.dtpTGKT.TabIndex = 108;
            // 
            // FrmQuanLyPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.pnlThem);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyPhongHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyPhongHoc";
            this.Load += new System.EventHandler(this.FrmQuanLyPhongHoc_Load);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.pnlThem.ResumeLayout(false);
            this.pnlThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietKT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Button btnTimLopHoc;
        private System.Windows.Forms.TextBox txtMaLopHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel pnlThem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThemLopHoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaMHDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapMaLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboThu;
        private System.Windows.Forms.ComboBox cboGiangVien;
        private System.Windows.Forms.ComboBox cboHK;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.NumericUpDown numTietKT;
        private System.Windows.Forms.NumericUpDown numTietBD;
    }
}