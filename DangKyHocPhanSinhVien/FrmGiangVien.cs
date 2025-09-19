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
        public FrmGiangVien()
        {
            InitializeComponent();
            dgvGiangVien.ReadOnly = true;
            dgvGiangVien.MultiSelect = false;
            dgvGiangVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                MessageBox.Show("Vui lòng nhập mã giảng viên cần tìm!", "Thông báo", MessageBoxButtons.OK);
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
    }
}
