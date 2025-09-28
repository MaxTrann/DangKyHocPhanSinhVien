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
    public partial class FrmGiangVien : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBGiangVien gv = new DBGiangVien();
        DBLopHoc lh = new DBLopHoc();
        private enum GridMode { DanhSachGV, LichDay }
        private GridMode _mode = GridMode.DanhSachGV;
        public FrmGiangVien()
        {
            InitializeComponent();
            dgvGiangVien.ReadOnly = true;
            dgvGiangVien.MultiSelect = false;
            dgvGiangVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvGiangVien.CellDoubleClick += dgvGiangVien_CellDoubleClick;
        }
        public void LoadGiangVien()
        {
            dgvGiangVien.DataSource = gv.DSGiangVien().Tables[0];
            dgvGiangVien.Columns[0].HeaderText = "Mã giảng viên";
            dgvGiangVien.Columns[1].HeaderText = "Họ tên giảng viên";
            dgvGiangVien.Columns[2].HeaderText = "Khoa";

            dgvGiangVien.Columns[0].Width = 100;
            dgvGiangVien.Columns[1].Width = 120;
            dgvGiangVien.Columns[2].Width = 250;

            _mode = GridMode.DanhSachGV;         // <— đánh dấu

        }

        public void LoadKhoa()
        {
            var dt = khoa.DanhSachKhoa().Tables[0];

            DataView dv = dt.DefaultView;
            dv.Sort = "TenKhoa ASC";

            cboKhoa.DataSource = dv;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;

        }
        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            LoadGiangVien();
            LoadKhoa();
        }

        private void btnTimGV_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                //MessageBox.Show("Vui lòng nhập mã giảng viên cần tìm!", "Thông báo", MessageBoxButtons.OK);
                LoadGiangVien();
                return;
            }
            DataSet ds = gv.ThongTinGV(txtMaGV.Text);

            if (ds.Tables[0].Rows.Count == 0) // không có kết quả
            {
                MessageBox.Show("Không tìm thấy giảng viên với mã: " + txtMaGV.Text, "Thông báo", MessageBoxButtons.OK);
                dgvGiangVien.DataSource = null; // clear lưới (nếu muốn)
                return;
            }

            dgvGiangVien.DataSource = ds.Tables[0];
            dgvGiangVien.Columns[0].HeaderText = "Mã giảng viên";
            dgvGiangVien.Columns[1].HeaderText = "Họ tên giảng viên";
            dgvGiangVien.Columns[2].HeaderText = "Khoa";

            dgvGiangVien.Columns[0].Width = 100;
            dgvGiangVien.Columns[1].Width = 120;
            dgvGiangVien.Columns[2].Width = 250;

        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (string.IsNullOrWhiteSpace(txtMaGV.Text))
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                kq = gv.XoaGV(ref err, txtMaGV.Text);
                if (kq)
                {
                    LoadGiangVien();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!\n" + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                err = "Không thể xóa!";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";

            if (string.IsNullOrWhiteSpace(txtNhapMaGV.Text) || string.IsNullOrWhiteSpace(txtNhapMatKhau.Text) || string.IsNullOrWhiteSpace(txtNhapHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giảng viên!");
                return;
            }

            if (cboKhoa.SelectedIndex == -1) // vị trí "Vui lòng chọn khoa"
            {
                MessageBox.Show("Vui lòng chọn khoa!");
                return;
            }
            try
            {
                kq = gv.ThemGV(ref err, txtNhapMaGV.Text, txtNhapMatKhau.Text, txtNhapHoTen.Text, cboKhoa.SelectedValue.ToString());
                if (kq)
                {
                    LoadGiangVien();
                    MessageBox.Show("Thêm thành công!");
                    txtNhapMaGV.Clear();
                    txtNhapMatKhau.Clear();
                    txtNhapHoTen.Clear();
                    cboKhoa.SelectedIndex = -1; // bắt chọn lại
                }
                else
                {
                    MessageBox.Show("Thêm không thành công! " + err);
                }
            }
            catch (Exception ex)
            {
                err = "Không thể thêm!";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGiangVien.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgvGiangVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var maGV = dgvGiangVien.Rows[e.RowIndex].Cells[0]?.Value?.ToString();
            if (string.IsNullOrWhiteSpace(maGV)) return;

            //txtMaGV.Text = maGV;          // đổ mã GV vào textbox (nếu bạn muốn hiển thị)
            ShowLichDayGiangVien();       // gọi hàm xem lịch (đã viết ở phần trước)
        }

        private void ShowLichDayGiangVien()
        {
            //if (string.IsNullOrWhiteSpace(txtMaGV.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn hoặc nhập mã giảng viên!");
            //    return;
            //}
            var ds = lh.LichDayGiangVien(txtMaGV.Text.Trim(), "HK1", 2025);
            var dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có lịch đứng lớp cho giảng viên này theo điều kiện lọc.");
                return;
            }

            dgvGiangVien.DataSource = dt;

            dgvGiangVien.Columns["MaLopHoc"].HeaderText = "Mã lớp học";
            dgvGiangVien.Columns["MaMHDT"].HeaderText = "Mã MHĐT";
            dgvGiangVien.Columns["TenMH"].HeaderText = "Tên môn";
            dgvGiangVien.Columns["SoTinChi"].HeaderText = "Số TC";
            dgvGiangVien.Columns["TenPhong"].HeaderText = "Phòng";
            dgvGiangVien.Columns["Thu"].HeaderText = "Thứ";
            dgvGiangVien.Columns["TietBatDau"].HeaderText = "Tiết BĐ";
            dgvGiangVien.Columns["TietKetThuc"].HeaderText = "Tiết KT";
            dgvGiangVien.Columns["ThoiGianBatDau"].HeaderText = "Bắt đầu";
            dgvGiangVien.Columns["ThoiGianKetThuc"].HeaderText = "Kết thúc";
            dgvGiangVien.Columns["HocKy"].HeaderText = "Học kỳ";
            dgvGiangVien.Columns["Nam"].HeaderText = "Năm";
        }


    }
}
