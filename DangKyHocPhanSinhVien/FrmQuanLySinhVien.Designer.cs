namespace DangKyHocPhanSinhVien
{
    partial class FrmQuanLySinhVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.pnlKhoa = new System.Windows.Forms.Panel();
            this.btnTimKiemKhoa = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiemNganh = new System.Windows.Forms.Button();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSVKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVienKhoa = new System.Windows.Forms.DataGridView();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSVNganh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlKhoa.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(629, 54);
            this.label4.TabIndex = 98;
            this.label4.Text = "Sinh viên khoa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(733, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(629, 54);
            this.label2.TabIndex = 103;
            this.label2.Text = "Sinh viên ngành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.BackColor = System.Drawing.Color.Snow;
            this.pnlKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKhoa.Controls.Add(this.btnTimKiemKhoa);
            this.pnlKhoa.Controls.Add(this.txtMaKhoa);
            this.pnlKhoa.Controls.Add(this.label5);
            this.pnlKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlKhoa.Location = new System.Drawing.Point(16, 84);
            this.pnlKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(629, 92);
            this.pnlKhoa.TabIndex = 104;
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(449, 20);
            this.btnTimKiemKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(141, 53);
            this.btnTimKiemKhoa.TabIndex = 59;
            this.btnTimKiemKhoa.Text = "Tìm kiếm";
            this.btnTimKiemKhoa.UseVisualStyleBackColor = false;
            this.btnTimKiemKhoa.Click += new System.EventHandler(this.btnTimKiemKhoa_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(144, 30);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(287, 30);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khoa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTimKiemNganh);
            this.panel2.Controls.Add(this.txtMaNganh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(733, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 92);
            this.panel2.TabIndex = 106;
            // 
            // btnTimKiemNganh
            // 
            this.btnTimKiemNganh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNganh.Location = new System.Drawing.Point(456, 20);
            this.btnTimKiemNganh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTimKiemNganh.Name = "btnTimKiemNganh";
            this.btnTimKiemNganh.Size = new System.Drawing.Size(141, 53);
            this.btnTimKiemNganh.TabIndex = 59;
            this.btnTimKiemNganh.Text = "Tìm kiếm";
            this.btnTimKiemNganh.UseVisualStyleBackColor = false;
            this.btnTimKiemNganh.Click += new System.EventHandler(this.btnTimKiemNganh_Click);
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.Location = new System.Drawing.Point(149, 30);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(287, 30);
            this.txtMaNganh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã ngành";
            // 
            // txtSVKhoa
            // 
            this.txtSVKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSVKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVKhoa.Location = new System.Drawing.Point(269, 200);
            this.txtSVKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSVKhoa.Name = "txtSVKhoa";
            this.txtSVKhoa.Size = new System.Drawing.Size(287, 30);
            this.txtSVKhoa.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 108;
            this.label1.Text = "Tổng sinh viên khoa";
            // 
            // dgvSinhVienKhoa
            // 
            this.dgvSinhVienKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVienKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSinhVienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVienKhoa.Location = new System.Drawing.Point(16, 251);
            this.dgvSinhVienKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvSinhVienKhoa.Name = "dgvSinhVienKhoa";
            this.dgvSinhVienKhoa.RowHeadersVisible = false;
            this.dgvSinhVienKhoa.RowHeadersWidth = 51;
            this.dgvSinhVienKhoa.RowTemplate.Height = 24;
            this.dgvSinhVienKhoa.Size = new System.Drawing.Size(1347, 497);
            this.dgvSinhVienKhoa.TabIndex = 109;
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.Location = new System.Drawing.Point(855, 794);
            this.btnAddSV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(227, 53);
            this.btnAddSV.TabIndex = 60;
            this.btnAddSV.Text = "Quản lý lớp - sinh viên";
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1191, 794);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 53);
            this.btnBack.TabIndex = 110;
            this.btnBack.Text = "Quay trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSVNganh
            // 
            this.txtSVNganh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSVNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVNganh.Location = new System.Drawing.Point(975, 198);
            this.txtSVNganh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSVNganh.Name = "txtSVNganh";
            this.txtSVNganh.Size = new System.Drawing.Size(287, 30);
            this.txtSVNganh.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(728, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 29);
            this.label6.TabIndex = 112;
            this.label6.Text = "Tổng sinh viên ngành";
            // 
            // FrmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 875);
            this.Controls.Add(this.txtSVNganh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.dgvSinhVienKhoa);
            this.Controls.Add(this.txtSVKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLySinhVien";
            this.Load += new System.EventHandler(this.FrmQuanLySinhVien_Load);
            this.pnlKhoa.ResumeLayout(false);
            this.pnlKhoa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlKhoa;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiemNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSVKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVienKhoa;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSVNganh;
        private System.Windows.Forms.Label label6;
    }
}