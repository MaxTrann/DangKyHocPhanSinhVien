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
    public partial class FrmQuanLyKhoaNganh : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        public FrmQuanLyKhoaNganh()
        {
            InitializeComponent();

            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void loadDSKhoa() // Đổ vào combox, coi chừng lộn khi với showKhoa()
        {
            var dt = khoa.DanhSachKhoa().Tables[0];

            DataView dv = dt.DefaultView;
            dv.Sort = "TenKhoa ASC";

            cboKhoa.DataSource = dv;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.SelectedIndex = -1;
        }

        public void loadDSNganh()
        {
            dgvDanhSach.DataSource = nganh.DanhSachNganh().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã ngành";
            dgvDanhSach.Columns[1].HeaderText = "Tên ngành";
            dgvDanhSach.Columns[2].HeaderText = "Tên khoa";
        }

        public void showKhoa()
        {
            dgvDanhSach.DataSource = khoa.DanhSachKhoa().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã khoa";
            dgvDanhSach.Columns[1].HeaderText = "Tên khoa";
        }

        private void FrmQuanLyKhoaNganh_Load(object sender, EventArgs e)
        {
            loadDSKhoa();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text == "")
                {
                    showKhoa();
                    return;
                }
                var ds = khoa.TimKiemKhoa(txtMaKhoa.Text);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khoa phù hợp.", "Thông báo");
                    return;
                }

                dgvDanhSach.DataSource = ds.Tables[0];
                dgvDanhSach.Columns[0].HeaderText = "Mã khoa";
                dgvDanhSach.Columns[1].HeaderText = "Tên khoa";

                txtMaKhoa.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimNganh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNganh.Text == "")
                {
                    loadDSNganh();
                    return;
                }
                var ds = nganh.TimKiemNganh(txtNganh.Text);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy ngành phù hợp.", "Thông báo");
                    return;
                }
                dgvDanhSach.DataSource = ds.Tables[0];
                dgvDanhSach.Columns[0].HeaderText = "Mã ngành";
                dgvDanhSach.Columns[1].HeaderText = "Tên ngành";
                dgvDanhSach.Columns[2].HeaderText = "Tên khoa";

                txtNganh.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (txtNhapMaNganh.Text == "" || txtNhapTenNganh.Text == "" || cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngành và chọn khoa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                kq = nganh.ThemNganh(ref err, txtNhapMaNganh.Text, txtNhapTenNganh.Text, cboKhoa.SelectedValue.ToString());
                if (kq)
                {
                    loadDSNganh();
                    MessageBox.Show("Thêm ngành thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtNhapMaNganh.Clear();
                    txtNhapTenNganh.Clear();
                    cboKhoa.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                err = "Không thể thêm ngành!";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (txtNganh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã ngành cần xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!nganh.Exists(txtNganh.Text))
            {
                MessageBox.Show($"Mã ngành [{txtNganh.Text}] không tồn tại.");
                return;
            }
            if (MessageBox.Show($"Xác nhận xoá ngành [{txtNganh.Text}] ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                kq = nganh.XoaNganh(ref err, txtNganh.Text);
                if (kq)
                {
                    loadDSNganh();
                    MessageBox.Show("Xóa ngành thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtNganh.Clear();
                }
            }
            catch (Exception ex)
            {
                err = "Không thể xóa ngành!";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (txtNhapMaKhoa.Text == "" || txtNhapTenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khoa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                kq = khoa.ThemKhoa(ref err, txtNhapMaKhoa.Text, txtNhapTenKhoa.Text);
                if (kq)
                {
                    //loadDSKhoa();
                    showKhoa();
                    MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtNhapMaKhoa.Clear();
                    txtNhapTenKhoa.Clear();
                }
            }
            catch (Exception ex)
            {
                err = "Không thể thêm khoa!";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khoa cần xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!khoa.Exists(txtMaKhoa.Text))
            {
                MessageBox.Show($"Mã khoa [{txtMaKhoa.Text}] không tồn tại.");
                return;
            }
            if (MessageBox.Show($"Xác nhận xoá khoa [{txtMaKhoa.Text}] ?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                kq = khoa.XoaKhoa(ref err, txtMaKhoa.Text);
                if (kq)
                {
                    //loadDSKhoa();
                    showKhoa();
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtMaKhoa.Clear();
                }
            }
            catch (Exception ex)
            {
                err = "Không thể xóa khoa!";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
