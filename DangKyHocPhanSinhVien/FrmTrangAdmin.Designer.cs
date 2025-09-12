namespace DangKyHocPhanSinhVien
{
    partial class FrmTrangAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtTenQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQLPH = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnQLK = new System.Windows.Forms.Button();
            this.btnQLGV = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.dgvDsSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1232, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.txtTenQL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1110, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(981, 26);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(116, 39);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // txtTenQL
            // 
            this.txtTenQL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQL.Location = new System.Drawing.Point(153, 29);
            this.txtTenQL.Name = "txtTenQL";
            this.txtTenQL.Size = new System.Drawing.Size(284, 27);
            this.txtTenQL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản trị viên: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQLPH);
            this.groupBox2.Controls.Add(this.btnQLMH);
            this.groupBox2.Controls.Add(this.btnQLK);
            this.groupBox2.Controls.Add(this.btnQLGV);
            this.groupBox2.Controls.Add(this.btnQLSV);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 470);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHỨC NĂNG";
            // 
            // btnQLPH
            // 
            this.btnQLPH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPH.Location = new System.Drawing.Point(12, 258);
            this.btnQLPH.Name = "btnQLPH";
            this.btnQLPH.Size = new System.Drawing.Size(189, 43);
            this.btnQLPH.TabIndex = 4;
            this.btnQLPH.Text = "Quản lý phòng học";
            this.btnQLPH.UseVisualStyleBackColor = false;
            this.btnQLPH.Click += new System.EventHandler(this.btnQLPH_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMH.Location = new System.Drawing.Point(12, 204);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(189, 43);
            this.btnQLMH.TabIndex = 3;
            this.btnQLMH.Text = "Quản lý môn học";
            this.btnQLMH.UseVisualStyleBackColor = false;
            this.btnQLMH.Click += new System.EventHandler(this.btnQLMH_Click);
            // 
            // btnQLK
            // 
            this.btnQLK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLK.Location = new System.Drawing.Point(12, 148);
            this.btnQLK.Name = "btnQLK";
            this.btnQLK.Size = new System.Drawing.Size(189, 43);
            this.btnQLK.TabIndex = 2;
            this.btnQLK.Text = "Quản lý Khoa";
            this.btnQLK.UseVisualStyleBackColor = false;
            this.btnQLK.Click += new System.EventHandler(this.btnQLK_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.Location = new System.Drawing.Point(12, 89);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(189, 43);
            this.btnQLGV.TabIndex = 1;
            this.btnQLGV.Text = "Quản lý giảng viên";
            this.btnQLGV.UseVisualStyleBackColor = false;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.Location = new System.Drawing.Point(12, 32);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(189, 43);
            this.btnQLSV.TabIndex = 0;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // dgvDsSinhVien
            // 
            this.dgvDsSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsSinhVien.Location = new System.Drawing.Point(233, 221);
            this.dgvDsSinhVien.Name = "dgvDsSinhVien";
            this.dgvDsSinhVien.RowHeadersWidth = 51;
            this.dgvDsSinhVien.Size = new System.Drawing.Size(993, 470);
            this.dgvDsSinhVien.TabIndex = 3;
            // 
            // FrmTrangAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.dgvDsSinhVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTrangAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrangAdmin";
            this.Load += new System.EventHandler(this.FrmTrangAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDsSinhVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtTenQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLPH;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Button btnQLK;
        private System.Windows.Forms.Button btnQLGV;
        private System.Windows.Forms.Button btnQLSV;
    }
}