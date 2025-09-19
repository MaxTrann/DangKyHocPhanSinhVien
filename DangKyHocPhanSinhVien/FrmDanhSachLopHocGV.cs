using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhanSinhVien
{
    public partial class FrmDanhSachLopHocGV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDanhSachLopHocGV()
        {
            InitializeComponent();
            dgvShow.ReadOnly = true;
            dgvShow.MultiSelect = false;
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvShow.SelectionChanged += dgvShow_SelectionChanged;

        }

        public void loadChiTiet()
        {
            dgvShow.DataSource = lh.ChiTietLopHocGV(maso).Tables[0];
            dgvShow.Columns[0].Name = "MaLopHoc";
            dgvShow.Columns[0].HeaderText = "Mã lớp học";
            dgvShow.Columns[1].HeaderText = "Tên môn mọc";
            dgvShow.Columns[2].HeaderText = "Thứ";
            dgvShow.Columns[3].HeaderText = "Tiết bắt đầu";
            dgvShow.Columns[4].HeaderText = "Tiết kết thúc";
            dgvShow.Columns[5].HeaderText = "Tên phòng";
            dgvShow.Columns[6].HeaderText = "Số lượng sinh viên";
        }

        private void btnTimKiemLH_Click(object sender, EventArgs e)
        {
            txtSVLH.Text = lh.TongSVLH(txtMaLH.Text).ToString();

            dgvShow.DataSource = lh.DanhSachSVLH(txtMaLH.Text).Tables[0];
            dgvShow.Columns[0].HeaderText = "Mã sinh viên";
            dgvShow.Columns[1].HeaderText = "Họ và tên sinh viên";
            dgvShow.Columns[2].HeaderText = "Giới tính";
            dgvShow.Columns[3].HeaderText = "Ngày sinh";
            dgvShow.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvShow.Columns[4].HeaderText = "Mã lớp";
            dgvShow.Columns[4].Name = "MaLopHoc";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDanhSachLopHocGV_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }
        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow == null) return;
            if (!dgvShow.Columns.Contains("MaLopHoc")) return;

            var maLopHoc = dgvShow.CurrentRow.Cells["MaLopHoc"]?.Value?.ToString();
            if (!string.IsNullOrEmpty(maLopHoc))
                txtMaLH.Text = maLopHoc;
        }

    }
}
