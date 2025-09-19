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
    public partial class FrmQuanLyMonHoc : Form
    {
        DBMonHoc_DaoTao mhdt = new DBMonHoc_DaoTao();
        DBMonHoc mh = new DBMonHoc();
        DBNganh nganh = new DBNganh();
        DBChuongTrinhDT ctdt = new DBChuongTrinhDT();
        DBKhoa khoa = new DBKhoa();
        public FrmQuanLyMonHoc()
        {
            InitializeComponent();
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadMHDT()
        {
            var dt = mhdt.DsMHDT().Tables[0];

            DataView dv = dt.DefaultView;
            dv.Sort = "MaMHDT ASC";

            dgvDanhSach.DataSource = dv;
            dgvDanhSach.Columns[0].HeaderText = "Mã MHDT";
            dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[2].HeaderText = "Số tín chỉ";
            dgvDanhSach.Columns[3].HeaderText = "Tên Chương Trình Đào Tạo";
            dgvDanhSach.Columns[4].HeaderText = "Ngôn Ngữ Đào Tạo";
            dgvDanhSach.Columns[5].HeaderText = "Tên Ngành";

            dgvDanhSach.Columns[0].Width = 100;
            dgvDanhSach.Columns[1].Width = 200;
            dgvDanhSach.Columns[5].Width = 200;
        }

        public void loadMonHoc()
        {
            dgvDanhSach.DataSource = mh.DSMonHoc().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã Môn Học";
            dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[2].HeaderText = "Số Tín Chỉ";
        }

        public void loadcboMonHoc()
        {
            var dt = mh.DSMonHoc().Tables[0];

            // Sắp xếp theo tên môn học
            DataView dv = dt.DefaultView;
            dv.Sort = "TenMH ASC";

            cboMonHoc.DataSource = dv;
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
            cboMonHoc.SelectedIndex = -1;
        }
        public void loadcboNganh()
        {
            var dt = nganh.DanhSachNganh().Tables[0];
            DataView dv = dt.DefaultView;
            dv.Sort = "TenNganh ASC";

            cboNganh.DataSource = dv;
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            cboNganh.SelectedIndex = -1;
        }
        public void loadcboCTDT()
        {
            var dt = ctdt.DanhSachCTDT().Tables[0];
            DataView dv = dt.DefaultView;
            dv.Sort = "TenCTDT ASC";

            cboCTDT.DataSource = dv;
            cboCTDT.DisplayMember = "TenCTDT";
            cboCTDT.ValueMember = "MaCTDT";
            cboCTDT.SelectedIndex = -1; 
        }

        private void FrmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            loadMHDT();
            loadcboMonHoc();
            loadcboNganh();
            loadcboCTDT();
            loadKhoaMH();
        }
        public void loadKhoaMH()
        {
            var dt = khoa.DanhSachKhoa().Tables[0];

            DataView dv = dt.DefaultView;
            dv.Sort = "TenKhoa ASC";

            cboKhoaMH.DataSource = dv;
            cboKhoaMH.DisplayMember = "TenKhoa";
            cboKhoaMH.ValueMember = "MaKhoa";
            cboKhoaMH.SelectedIndex = -1;
        }
        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (string.IsNullOrWhiteSpace(txtNhapMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtNhapTenMH.Text) ||
                string.IsNullOrWhiteSpace(txtNhapTinChi.Text) ||
                cboKhoaMH.SelectedIndex == -1 || cboKhoaMH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và chọn khoa!", "Thông báo");
                return;
            }
            if (!int.TryParse(txtNhapTinChi.Text, out int soTinChi) || soTinChi <= 0)
            {
                MessageBox.Show("Số tín chỉ phải là một số nguyên dương!", "Thông báo");
                return;
            }

            try
            {
                kq = mh.ThemMH(ref err, txtNhapMaMH.Text, txtNhapTenMH.Text, soTinChi, cboKhoaMH.SelectedValue.ToString());
                if (kq)
                {
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo");
                    loadMonHoc();
                    loadcboMonHoc();
                    txtNhapMaMH.Clear();
                    txtNhapTenMH.Clear();
                    txtNhapTinChi.Clear();
                    cboKhoaMH.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại! Lỗi: " + err, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");

            }
        }

        private void btnThemMHDT_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            if (string.IsNullOrWhiteSpace(txtNhapMaMHDT.Text) ||
                cboMonHoc.SelectedIndex == -1 || cboMonHoc.SelectedValue == null ||
                cboCTDT.SelectedIndex == -1 || cboCTDT.SelectedValue == null ||
                cboNganh.SelectedIndex == -1 || cboNganh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và chọn môn học, chương trình đào tạo, ngành!", "Thông báo");
                return;
            }
            try
            {
                kq = mhdt.ThemMHDT(ref err, txtNhapMaMHDT.Text, cboMonHoc.SelectedValue.ToString(), cboCTDT.SelectedValue.ToString(), cboNganh.SelectedValue.ToString());
                if (kq)
                {
                    MessageBox.Show("Thêm môn học đào tạo thành công!", "Thông báo");
                    loadMHDT();
                    txtNhapMaMHDT.Clear();
                    cboMonHoc.SelectedIndex = -1;
                    cboCTDT.SelectedIndex = -1;
                    cboNganh.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm môn học đào tạo thất bại! Lỗi: " + err, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }

        }

        private void btnTimMH_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaMonHoc.Text))
            {
                loadMonHoc();
                return;
            }
            var ds = mh.TimKiemMH(txtMaMonHoc.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy môn học phù hợp.", "Thông báo");
                return;
            }
            dgvDanhSach.DataSource = ds.Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã Môn Học";
            dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[2].HeaderText = "Số Tín Chỉ";
            dgvDanhSach.Columns[3].HeaderText = "Mã Khoa Phụ Trách";
        }

        private void btnTimMHDT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMHDT.Text))
            {
                loadMHDT();
                return;
            }
            var ds = mhdt.TimKiemMHDT(txtMaMHDT.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy môn học đào tạo phù hợp.", "Thông báo");
                return;
            }
            dgvDanhSach.DataSource = ds.Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã MHDT";
            dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[2].HeaderText = "Số tín chỉ";
            dgvDanhSach.Columns[3].HeaderText = "Tên Chương Trình Đào Tạo";
            dgvDanhSach.Columns[4].HeaderText = "Ngôn Ngữ Đào Tạo";
            dgvDanhSach.Columns[5].HeaderText = "Tên Ngành";

        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần xóa.", "Thông báo");
                return;
            }
            if (mh.TimKiemMH(txtMaMonHoc.Text).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã môn học không tồn tại.", "Thông báo");
                return;
            }
            if (mhdt.ExistsByMaMH(txtMaMonHoc.Text))  
            {
                MessageBox.Show("Không thể xóa vì môn học đang được dùng trong chương trình đào tạo.", "Thông báo");
                return;
            }
            bool kq = false;
            string err = "";
            try
            {
                kq = mh.XoaMH(ref err, txtMaMonHoc.Text);
                if (kq)
                {
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo");
                    loadMonHoc();
                    loadcboMonHoc();
                    txtMaMonHoc.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa môn học thất bại! Lỗi: " + err, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btnXoaMHDT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMHDT.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn học đào tạo cần xóa.", "Thông báo");
                return;
            }
            if (mhdt.TimKiemMHDT(txtMaMHDT.Text).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Mã môn học đào tạo không tồn tại.", "Thông báo");
                return;
            }
            bool kq = false;
            string err = "";
            try
            {
                kq = mhdt.XoaMHDT(ref err, txtMaMHDT.Text);
                if (kq)
                {
                    MessageBox.Show("Xóa môn học đào tạo thành công!", "Thông báo");
                    loadMHDT();
                    txtMaMHDT.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa môn học đào tạo thất bại! Lỗi: " + err, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
