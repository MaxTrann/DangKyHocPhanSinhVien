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
    public partial class FrmQuanLyPhongHoc : Form
    {
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();
        public FrmQuanLyPhongHoc()
        {
            InitializeComponent();
            dgvLopHoc.ReadOnly = true;
            dgvLopHoc.MultiSelect = false;
            dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void loadGiangVien()
        {
            var dt = gv.DSGiangVien().Tables[0];
            DataView dv = dt.DefaultView;
            dv.Sort = "HoTenGV ASC"; // sắp theo tên giảng viên

            cboGiangVien.DataSource = dv;
            cboGiangVien.DisplayMember = "HoTenGV"; // hiển thị tên
            cboGiangVien.ValueMember = "MaGV";      // lưu mã
            cboGiangVien.SelectedIndex = -1;        // chưa chọn
        }
        public void LoadHocKy()
        {
            cboHK.Items.Clear();
            cboHK.Items.Add("HK1");
            cboHK.Items.Add("HK2");
            cboHK.Items.Add("HK3");
            cboHK.SelectedIndex = -1;
        }
        public void loadDSLopHoc()
        {
            var dt = lh.DSLopHoc().Tables[0];
            DataView dv = dt.DefaultView;
            dv.Sort = "Thu ASC";   // hoặc DESC nếu muốn ngược lại

            dgvLopHoc.DataSource = dv;
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns[1].HeaderText = "Mã MHDT";
            dgvLopHoc.Columns[2].HeaderText = "Mã giảng viên";
            dgvLopHoc.Columns[3].HeaderText = "Số lượng";
            dgvLopHoc.Columns[4].HeaderText = "Tên Phòng";
            dgvLopHoc.Columns[5].HeaderText = "Thứ";
            dgvLopHoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
            dgvLopHoc.Columns[7].HeaderText = "Tiết Kết Thúc";
            dgvLopHoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
            dgvLopHoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
            dgvLopHoc.Columns[10].HeaderText = "Học kỳ";
            dgvLopHoc.Columns[11].HeaderText = "Năm";
        }

        private void FrmQuanLyPhongHoc_Load(object sender, EventArgs e)
        {
            loadDSLopHoc();
            loadGiangVien();
            LoadHocKy();

            // DateTimePicker cho ngày bắt đầu/kết thúc
            dtpTGBD.Format = DateTimePickerFormat.Custom;
            dtpTGBD.CustomFormat = "dd/MM/yyyy";
            dtpTGKT.Format = DateTimePickerFormat.Custom;
            dtpTGKT.CustomFormat = "dd/MM/yyyy";

            // NumericUpDown cho tiết & số lượng
            numTietBD.Minimum = 1; numTietBD.Maximum = 12;
            numTietKT.Minimum = 1; numTietKT.Maximum = 12;
        }

        private void btnTimLopHoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLopHoc.Text))
            {
                loadDSLopHoc();
                return;
            }

            var ds = lh.TimLopHoc(txtMaLopHoc.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy lớp học nào với mã lớp học đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvLopHoc.DataSource = ds.Tables[0];
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns[1].HeaderText = "Mã MHDT";
            dgvLopHoc.Columns[2].HeaderText = "Mã giảng viên";
            dgvLopHoc.Columns[3].HeaderText = "Số lượng";
            dgvLopHoc.Columns[4].HeaderText = "Tên Phòng";
            dgvLopHoc.Columns[5].HeaderText = "Thứ";
            dgvLopHoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
            dgvLopHoc.Columns[7].HeaderText = "Tiết Kết Thúc";
            dgvLopHoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
            dgvLopHoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
            dgvLopHoc.Columns[10].HeaderText = "Học kỳ";
            dgvLopHoc.Columns[11].HeaderText = "Năm";
        }

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            // 1) Bắt buộc nhập & chọn
            if (string.IsNullOrWhiteSpace(txtNhapMaLopHoc.Text) ||
                string.IsNullOrWhiteSpace(txtMaMHDT.Text) ||
               cboGiangVien.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtPhong.Text) ||
                cboThu.SelectedIndex < 0 ||                           // bắt buộc chọn Thứ
                cboHK.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtNam.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn Thứ.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Parse & validate kiểu dữ liệu
            if (!int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Giới hạn phải là số nguyên.", "Thông báo");
                return;
            }
            if (soLuong < 10 || soLuong > 100) // khớp CHECK (SoLuong BETWEEN 10 AND 100)
            {
                MessageBox.Show("Giới hạn phải nằm trong khoảng 10 đến 100.", "Thông báo");
                return;
            }

            // kiểm tra tiết học
            int tietBD = (int)numTietBD.Value;
            int tietKT = (int)numTietKT.Value;
            if (tietBD >= tietKT)
            {
                MessageBox.Show("Tiết bắt đầu phải nhỏ hơn tiết kết thúc.");
                return;
            }

            if (dtpTGBD.Value.Date > dtpTGKT.Value.Date)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.");
                return;
            }


            // 3) Giá trị đã hợp lệ → gọi BLL
            bool kq = false;
            string err = "";
            string thu = (cboThu.SelectedItem ?? "").ToString().Trim(); // ví dụ: "Thứ 2"
            string maGV = cboGiangVien.SelectedValue.ToString(); // lấy mã GV từ combo
            string hocKy = cboHK.SelectedItem.ToString();        // HK1/HK2/HK3
            try
            {
                kq = lh.ThemLopHoc(
                    ref err,
                    txtNhapMaLopHoc.Text.Trim(),
                    txtMaMHDT.Text.Trim(),
                    cboGiangVien.SelectedValue.ToString(),
                    soLuong,
                    txtPhong.Text.Trim(),
                    thu,
                    tietBD,
                    tietKT,
                    dtpTGBD.Value.ToString("yyyy-MM-dd"),
                    dtpTGKT.Value.ToString("yyyy-MM-dd"),
                    hocKy,
                    int.Parse(txtNam.Text)
                );

                if (kq)
                {
                    MessageBox.Show("Thêm lớp học thành công.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDSLopHoc();

                    // reset form
                    txtNhapMaLopHoc.Clear();
                    txtMaMHDT.Clear();
                    cboGiangVien.SelectedIndex = -1;
                    txtSoLuong.Clear();
                    txtPhong.Clear();
                    cboThu.SelectedIndex = -1;
                    numTietBD.Value = 1; 
                    numTietKT.Value = 1;
                    dtpTGBD.Value = DateTime.Today;
                    dtpTGKT.Value = DateTime.Today;
                    cboHK.SelectedIndex = -1;
                    txtNam.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm lớp học thất bại. Lỗi: " + err, "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lớp học thất bại. Lỗi: " + ex.Message, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLopHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool kq = false;
            string err = "";
            try
            {
                kq = lh.XoaLopHoc(ref err, txtMaLopHoc.Text);
                if (kq)
                {
                    MessageBox.Show("Xóa lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDSLopHoc();
                    txtMaLopHoc.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa lớp học thất bại. Lỗi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lớp học thất bại. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
