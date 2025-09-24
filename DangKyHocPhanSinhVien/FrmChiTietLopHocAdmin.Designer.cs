namespace DangKyHocPhanSinhVien
{
    partial class FrmChiTietLopHocAdmin
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
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lblGV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblSoDK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChiTiet.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblChiTiet.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.ForeColor = System.Drawing.Color.Black;
            this.lblChiTiet.Location = new System.Drawing.Point(12, 9);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(1321, 65);
            this.lblChiTiet.TabIndex = 65;
            this.lblChiTiet.Text = "CHI TIẾT LỚP HỌC";
            this.lblChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGV
            // 
            this.lblGV.AutoSize = true;
            this.lblGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGV.Location = new System.Drawing.Point(12, 85);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(0, 25);
            this.lblGV.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 67;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BackgroundColor = System.Drawing.Color.White;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(17, 158);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1321, 519);
            this.dgvShow.TabIndex = 68;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1211, 699);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 42);
            this.btnThoat.TabIndex = 69;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblSoDK
            // 
            this.lblSoDK.AutoSize = true;
            this.lblSoDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDK.Location = new System.Drawing.Point(12, 117);
            this.lblSoDK.Name = "lblSoDK";
            this.lblSoDK.Size = new System.Drawing.Size(0, 25);
            this.lblSoDK.TabIndex = 70;
            // 
            // FrmChiTietLopHocAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 753);
            this.Controls.Add(this.lblSoDK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGV);
            this.Controls.Add(this.lblChiTiet);
            this.Name = "FrmChiTietLopHocAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietLopHocAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblSoDK;
    }
}