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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSVKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVienKhoa = new System.Windows.Forms.DataGridView();
            this.btnLOPSV = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 44);
            this.label4.TabIndex = 98;
            this.label4.Text = "Sinh viên khoa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 44);
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
            this.pnlKhoa.Location = new System.Drawing.Point(12, 68);
            this.pnlKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(472, 75);
            this.pnlKhoa.TabIndex = 104;
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(337, 16);
            this.btnTimKiemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(106, 43);
            this.btnTimKiemKhoa.TabIndex = 59;
            this.btnTimKiemKhoa.Text = "Tìm kiếm";
            this.btnTimKiemKhoa.UseVisualStyleBackColor = false;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(108, 24);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(216, 26);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khoa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(550, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 75);
            this.panel2.TabIndex = 106;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(342, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 43);
            this.button2.TabIndex = 59;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(112, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã ngành";
            // 
            // txtSVKhoa
            // 
            this.txtSVKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSVKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVKhoa.Location = new System.Drawing.Point(151, 161);
            this.txtSVKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSVKhoa.Name = "txtSVKhoa";
            this.txtSVKhoa.Size = new System.Drawing.Size(216, 26);
            this.txtSVKhoa.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Tổng sinh viên";
            // 
            // dgvSinhVienKhoa
            // 
            this.dgvSinhVienKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVienKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSinhVienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVienKhoa.Location = new System.Drawing.Point(12, 204);
            this.dgvSinhVienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSinhVienKhoa.Name = "dgvSinhVienKhoa";
            this.dgvSinhVienKhoa.RowHeadersVisible = false;
            this.dgvSinhVienKhoa.RowHeadersWidth = 51;
            this.dgvSinhVienKhoa.RowTemplate.Height = 24;
            this.dgvSinhVienKhoa.Size = new System.Drawing.Size(1010, 404);
            this.dgvSinhVienKhoa.TabIndex = 109;
            // 
            // btnLOPSV
            // 
            this.btnLOPSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLOPSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOPSV.Location = new System.Drawing.Point(641, 645);
            this.btnLOPSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLOPSV.Name = "btnLOPSV";
            this.btnLOPSV.Size = new System.Drawing.Size(170, 43);
            this.btnLOPSV.TabIndex = 60;
            this.btnLOPSV.Text = "Quản lý lớp - sinh viên";
            this.btnLOPSV.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(893, 645);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 43);
            this.btnBack.TabIndex = 110;
            this.btnBack.Text = "Quay trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // FrmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLOPSV);
            this.Controls.Add(this.dgvSinhVienKhoa);
            this.Controls.Add(this.txtSVKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "FrmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLySinhVien";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSVKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVienKhoa;
        private System.Windows.Forms.Button btnLOPSV;
        private System.Windows.Forms.Button btnBack;
    }
}