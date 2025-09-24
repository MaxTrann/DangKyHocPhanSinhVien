namespace DangKyHocPhanSinhVien
{
    partial class FrmDanhSachLopHocGV
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
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnTimKiemLH = new System.Windows.Forms.Button();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSVLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1321, 65);
            this.label4.TabIndex = 64;
            this.label4.Text = "Đăng ký môn học";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BackgroundColor = System.Drawing.Color.White;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(12, 254);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1321, 425);
            this.dgvShow.TabIndex = 65;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1211, 699);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 42);
            this.btnThoat.TabIndex = 66;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Snow;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnTimKiemLH);
            this.panel.Controls.Add(this.txtMaLH);
            this.panel.Controls.Add(this.label5);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(12, 98);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(557, 75);
            this.panel.TabIndex = 109;
            // 
            // btnTimKiemLH
            // 
            this.btnTimKiemLH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLH.Location = new System.Drawing.Point(411, 18);
            this.btnTimKiemLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemLH.Name = "btnTimKiemLH";
            this.btnTimKiemLH.Size = new System.Drawing.Size(107, 43);
            this.btnTimKiemLH.TabIndex = 59;
            this.btnTimKiemLH.Text = "Tìm kiếm";
            this.btnTimKiemLH.UseVisualStyleBackColor = false;
            this.btnTimKiemLH.Click += new System.EventHandler(this.btnTimKiemLH_Click);
            // 
            // txtMaLH
            // 
            this.txtMaLH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Location = new System.Drawing.Point(157, 24);
            this.txtMaLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(216, 30);
            this.txtMaLH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Lớp Học";
            // 
            // txtSVLH
            // 
            this.txtSVLH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSVLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVLH.Location = new System.Drawing.Point(212, 196);
            this.txtSVLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSVLH.Name = "txtSVLH";
            this.txtSVLH.ReadOnly = true;
            this.txtSVLH.Size = new System.Drawing.Size(216, 30);
            this.txtSVLH.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 111;
            this.label1.Text = "Tổng sinh viên";
            // 
            // FrmDanhSachLopHocGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 753);
            this.Controls.Add(this.txtSVLH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.label4);
            this.Name = "FrmDanhSachLopHocGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachLopHocGV";
            this.Load += new System.EventHandler(this.FrmDanhSachLopHocGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnTimKiemLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSVLH;
        private System.Windows.Forms.Label label1;
    }
}