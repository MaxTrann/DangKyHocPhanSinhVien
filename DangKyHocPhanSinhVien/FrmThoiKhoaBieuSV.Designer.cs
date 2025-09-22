namespace DangKyHocPhanSinhVien
{
    partial class FrmThoiKhoaBieuSV
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnXoaDangKyLH = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1206, 54);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thời khóa biểu sinh viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(13, 81);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1207, 530);
            this.dgvDanhSach.TabIndex = 27;
            // 
            // btnXoaDangKyLH
            // 
            this.btnXoaDangKyLH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaDangKyLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDangKyLH.Location = new System.Drawing.Point(794, 651);
            this.btnXoaDangKyLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDangKyLH.Name = "btnXoaDangKyLH";
            this.btnXoaDangKyLH.Size = new System.Drawing.Size(189, 43);
            this.btnXoaDangKyLH.TabIndex = 106;
            this.btnXoaDangKyLH.Text = "Xóa Lớp Học";
            this.btnXoaDangKyLH.UseVisualStyleBackColor = false;
            this.btnXoaDangKyLH.Click += new System.EventHandler(this.btnXoaDangKyLH_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1030, 651);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(189, 43);
            this.btnReturn.TabIndex = 105;
            this.btnReturn.Text = "Quay trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 651);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 29);
            this.label6.TabIndex = 113;
            this.label6.Text = "Tổng số tín chỉ đã đăng ký ";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(301, 650);
            this.txtSoTinChi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(66, 30);
            this.txtSoTinChi.TabIndex = 114;
            // 
            // FrmThoiKhoaBieuSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 721);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaDangKyLH);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label4);
            this.Name = "FrmThoiKhoaBieuSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời khóa biểu siên viên";
            this.Load += new System.EventHandler(this.FrmThoiKhoaBieuSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnXoaDangKyLH;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTinChi;
    }
}