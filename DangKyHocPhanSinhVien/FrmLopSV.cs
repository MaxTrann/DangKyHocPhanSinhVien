using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace DangKyHocPhanSinhVien
{
    public partial class FrmLopSV : Form
    {
        DBLop lop = new DBLop();
        DBSinhVien sv = new DBSinhVien();
        DBChuongTrinhDT ctdt = new DBChuongTrinhDT();
        DBNganh nganh = new DBNganh();

        public FrmLopSV()
        {
            InitializeComponent();
            dgvThongTin.ReadOnly = true;
            dgvThongTin.MultiSelect = false;
            dgvThongTin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvThongTin.CellClick += dgvThongTin_CellClick;
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvThongTin.CurrentRow == null) return;
            try
            {
                var row = dgvThongTin.CurrentRow;
                if (IsShowingStudents())
                {
                    // Columns: 0 MaSV, 1 HoTen, 2 GioiTinh, 3 NgaySinh, (có thể 4 MaLop)
                    string maSV = row.Cells[0]?.Value?.ToString();
                    txtMaSV.Text = maSV;
                    txtNhapMssv.Text = maSV;

                    txtHoTen.Text = row.Cells[1]?.Value?.ToString();
                    txtNhapGioiTinh.Text = row.Cells[2]?.Value?.ToString();

                    if (DateTime.TryParse(row.Cells[3]?.Value?.ToString(), out var d))
                        dtpNgaySinh.Value = d;


                    if (row.Cells.Count > 4)
                        txtNhapLop.Text = row.Cells[4]?.Value?.ToString() ?? string.Empty;
                }
                else
                {
                    // Columns: 0 MaLop, 1 TenLop, 2 TenNganh (hoặc MaNganh tùy SP), 3 TenCTDT
                    var maLop = row.Cells[0]?.Value?.ToString();
                    txtMaLop.Text = maLop;
                    txtNhapMaLop.Text = maLop;
                    txtNhapTenLop.Text = row.Cells[1]?.Value?.ToString();

                    var tenNganh = row.Cells[2]?.Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(tenNganh) && cboNganh.DataSource is DataTable dn)
                    {
                        for (int i = 0; i < dn.Rows.Count; i++)
                        {
                            if (string.Equals(dn.Rows[i]["TenNganh"]?.ToString(), tenNganh, StringComparison.OrdinalIgnoreCase))
                            {
                                cboNganh.SelectedIndex = i;
                                break;
                            }
                        }
                    }

                    var tenCt = row.Cells[3]?.Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(tenCt) && cboCTDT.DataSource is DataTable dt)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (string.Equals(dt.Rows[i]["TenCTDT"]?.ToString(), tenCt, StringComparison.OrdinalIgnoreCase))
                            {
                                cboCTDT.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadNganh()
        {
            var ds = nganh.DanhSachNganh();
            if (ds == null || ds.Tables.Count == 0) return;

            cboNganh.DataSource = ds.Tables[0];
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            cboNganh.SelectedIndex = -1;
        }


        public void loadCTDT()
        {
            var ds = ctdt.DanhSachCTDT();
            if (ds == null || ds.Tables.Count == 0) return;

            cboCTDT.DataSource = ds.Tables[0];
            cboCTDT.DisplayMember = "TenCTDT";
            cboCTDT.ValueMember = "MaCTDT";
            cboCTDT.SelectedIndex = -1;
        }

        public void loadLop()
        {
            var ds = lop.DSLop();
            if (ds == null || ds.Tables.Count == 0)
            {
                dgvThongTin.DataSource = null;
                return;
            }

            dgvThongTin.DataSource = ds.Tables[0];
            if (dgvThongTin.Columns.Count >= 4)
            {
                dgvThongTin.Columns[0].HeaderText = "Mã Lớp";
                dgvThongTin.Columns[1].HeaderText = "Tên Lớp";
                dgvThongTin.Columns[2].HeaderText = "Tên Ngành";
                dgvThongTin.Columns[3].HeaderText = "Chương Trình Đào Tạo";
            }
        }

        private void FrmLopSV_Load(object sender, EventArgs e)
        {
            loadCTDT();
            loadLop();
            loadNganh();
        }
        private void btnTimLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                loadLop();
                return;
            }
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNhapGioiTinh.Clear();
            txtNhapMaLop.Clear();
            cboNganh.SelectedIndex = -1;
            cboCTDT.SelectedIndex = -1;
            txtNhapMatKhau.Clear();
            txtNhapMssv.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtNhapTenLop.Clear();

            var ds = lop.DSSVLop(txtMaLop.Text);
            if (ds == null || ds.Tables.Count == 0)
            {
                dgvThongTin.DataSource = null;
                return;
            }
            dgvThongTin.DataSource = ds.Tables[0];
            dgvThongTin.Columns[0].HeaderText = "Mã sinh viên";
            dgvThongTin.Columns[1].HeaderText = "Họ tên sinh viên";
            dgvThongTin.Columns[2].HeaderText = "Giới Tính";
            dgvThongTin.Columns[3].HeaderText = "Ngày Sinh";
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            try
            {
                var maLop = txtMaLop.Text.Trim();
                if (string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng nhập mã lớp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show($"Bạn có chắc muốn xóa lớp '{maLop}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                string err = "";
                var kq = lop.XoaLop(ref err, maLop);
                if (kq)
                {
                    MessageBox.Show("Xóa lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLop();
                    ClearClassInputs();
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

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtHoTen.Clear();
            txtNhapGioiTinh.Clear();
            txtNhapMaLop.Clear();
            cboNganh.SelectedIndex = -1;
            cboCTDT.SelectedIndex = -1;
            txtNhapMatKhau.Clear();
            txtNhapMssv.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtNhapTenLop.Clear();
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var ds = sv.ThongTin(txtMaSV.Text);
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào với mã sinh viên đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvThongTin.DataSource = ds.Tables[0];

                dgvThongTin.Columns[0].HeaderText = "Mã sinh viên";
                dgvThongTin.Columns[1].HeaderText = "Họ tên sinh viên";
                dgvThongTin.Columns[2].HeaderText = "Giới Tính";
                dgvThongTin.Columns[3].HeaderText = "Ngày Sinh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            try
            {
                var maSV = string.IsNullOrWhiteSpace(txtMaSV.Text) ? txtNhapMssv.Text.Trim() : txtMaSV.Text.Trim();
                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên '{maSV}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                string err = "";
                var kq = sv.XoaSV(ref err, maSV);
                if (kq)
                {
                    MessageBox.Show("Xóa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLop();
                    ClearStudentInputs();
                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại. Lỗi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa sinh viên thất bại. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SinhVienExists(string maSV)
        {
            try
            {
                var ds = sv.ThongTin(maSV);
                return ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
            }
            catch
            {
                return false;
            } 
            
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var newMaSV = txtNhapMssv.Text.Trim();
                var tenDangNhap = string.IsNullOrWhiteSpace(txtMaSV.Text) ? txtNhapMssv.Text.Trim() : txtMaSV.Text.Trim();
                var hoTen = txtHoTen.Text.Trim();
                var gioiTinh = txtNhapGioiTinh.Text.Trim();
                var ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                var maLop = txtNhapLop.Text.Trim();


                if (string.IsNullOrEmpty(tenDangNhap) ||
                    string.IsNullOrEmpty(hoTen) ||
                    string.IsNullOrEmpty(gioiTinh) ||
                    string.IsNullOrEmpty(ngaySinh) ||
                    string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!SinhVienExists(tenDangNhap))
                {
                    MessageBox.Show($"Không tìm thấy sinh viên với mã sinh viên '{tenDangNhap}'. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (newMaSV != tenDangNhap && SinhVienExists(newMaSV))
                {
                    MessageBox.Show($"Mã sinh viên mới '{newMaSV}' đã tồn tại. Vui lòng chọn mã khác.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Gợi ý format yyyy-MM-dd để SQL dễ parse (không bắt buộc)
                if (DateTime.TryParse(ngaySinh, out var d)) ngaySinh = d.ToString("yyyy-MM-dd");

                string err = "";
                var kq = sv.CapNhatSV(ref err, tenDangNhap, hoTen, gioiTinh, ngaySinh, maLop, newMaSV);
                if (kq)
                {
                    MessageBox.Show("Cập nhật sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLop();
                    ClearStudentInputs();
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại. Lỗi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật sinh viên thất bại. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool LopExists(string maLop)
        {
            var ds = lop.DSLop();
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) 
                return false;
            return ds.Tables[0].AsEnumerable()
             .Any(r => r["MaLop"].ToString() == maLop);

        }


        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                var tenDangNhap = txtNhapMssv.Text.Trim();
                var matKhau = txtNhapMatKhau.Text.Trim();
                var hoTen = txtHoTen.Text.Trim();
                var gioiTinh = txtNhapGioiTinh.Text.Trim();
                var maLop = txtNhapLop.Text.Trim();
                var ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");


                if (string.IsNullOrEmpty(tenDangNhap) ||
                    string.IsNullOrEmpty(matKhau) ||
                    string.IsNullOrEmpty(hoTen) ||
                    string.IsNullOrEmpty(gioiTinh) ||
                    string.IsNullOrEmpty(ngaySinh) ||
                    string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!LopExists(maLop))
                {
                    MessageBox.Show($"Không tìm thấy lớp với mã lớp '{maLop}'. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gợi ý format yyyy-MM-dd để SQL dễ parse (không bắt buộc)
                if (DateTime.TryParse(ngaySinh, out var d)) ngaySinh = d.ToString("yyyy-MM-dd");

                string err = "";
                var kq = sv.ThemSV(ref err, tenDangNhap, matKhau, hoTen, gioiTinh, ngaySinh, maLop);
                if (kq)
                {
                    MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLop();
                    ClearStudentInputs();
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại. Lỗi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sinh viên thất bại. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // tiện ích
        private bool IsShowingStudents()
        {
            if (dgvThongTin.Columns.Count == 0) return false;
            var h0 = dgvThongTin.Columns[0].HeaderText?.Trim();
            return string.Equals(h0, "Mã sinh viên", StringComparison.OrdinalIgnoreCase);


        }
        private void ClearStudentInputs()
        {
            txtMaSV.Clear();
            txtNhapMssv.Clear();
            txtNhapMatKhau.Clear();
            txtHoTen.Clear();
            txtNhapGioiTinh.Clear();
            dtpNgaySinh.Value = DateTime.Now;   
            txtNhapLop.Clear();   // textbox nhập mã lớp cho SV
        }

        private void ClearClassInputs()
        {
            txtMaLop.Clear();
            txtNhapMaLop.Clear();
            // txtNhapMaNganh.Clear();  // bỏ nếu đã remove textbox
            txtNhapTenLop.Clear();
            if (cboCTDT.Items.Count > 0) cboCTDT.SelectedIndex = -1;
            if (cboNganh.Items.Count > 0) cboNganh.SelectedIndex = -1;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                var maLop = txtNhapMaLop.Text.Trim();
                var tenLop = txtNhapTenLop.Text.Trim();
                var maNganh = cboNganh.SelectedValue?.ToString();
                var maCTDT = cboCTDT.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(maLop) ||
                    string.IsNullOrEmpty(tenLop) ||
                    string.IsNullOrEmpty(maNganh) ||
                    string.IsNullOrEmpty(maCTDT))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string err = "";
                var kq = lop.ThemLop(ref err, maLop, tenLop, maNganh, maCTDT);
                if (kq)
                {
                    MessageBox.Show("Thêm lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLop();
                    ClearClassInputs();
                }
                else
                {
                    MessageBox.Show("Thêm lớp học thất bại. Lỗi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lớp học thất bại. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
