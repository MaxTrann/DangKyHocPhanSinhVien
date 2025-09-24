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
    public partial class FrmChiTietLopHocAdmin : Form
    {
        private string _maLH;
        private string _maGV;
        DBLopHoc _lh = new DBLopHoc();
        DBGiangVien _gv = new DBGiangVien();

        public FrmChiTietLopHocAdmin(string maLopHoc, string maGV = null)
        {
            InitializeComponent();
            _maLH = maLopHoc?.Trim();
            _maGV = maGV?.Trim();
            Load += FrmChiTietLopHocAdmin_Load;
        }

        private void FrmChiTietLopHocAdmin_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_maLH))
            {
                MessageBox.Show("Thiếu mã lớp học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            try
            {
                // ====== 1. Hiển thị Mã lớp học trên label ======
                label1.Text = $"Chi tiết lớp học: {_maLH}";

                // ====== 2. Lấy thông tin giảng viên (nếu có) ======
                string tenGV = null;
                if (!string.IsNullOrWhiteSpace(_maGV))
                {
                    var dtGV = _gv.ThongTinGV(_maGV).Tables[0];
                    if (dtGV.Rows.Count > 0 && dtGV.Columns.Contains("HoTenGV"))
                        tenGV = dtGV.Rows[0]["HoTenGV"]?.ToString();
                }

                // Nếu muốn, có thể gắn thêm label khác để hiện GV:
                lblGV.Text = $"Giảng viên: {(!string.IsNullOrEmpty(tenGV) ? tenGV : _maGV)}";

                // ====== 3. Số sinh viên đã đăng ký ======
                int soDK = _lh.TongSVLH(_maLH);
                // Nếu muốn hiện thêm, bạn tạo thêm 1 label khác ví dụ lblSoDK
                lblSoDK.Text = $"Số SV đã đăng ký: {soDK}";

                // ====== 4. Danh sách sinh viên đã đăng ký ======
                var dtSV = _lh.DanhSachSVLH(_maLH).Tables[0];
                dgvShow.DataSource = dtSV;

                // ====== 5. Đặt header cho dgvShow ======
                if (dgvShow.Columns.Count >= 5)
                {
                    dgvShow.Columns[0].HeaderText = "Mã sinh viên";
                    dgvShow.Columns[1].HeaderText = "Họ và tên";
                    dgvShow.Columns[2].HeaderText = "Giới tính";
                    dgvShow.Columns[3].HeaderText = "Ngày sinh";
                    dgvShow.Columns[4].HeaderText = "Mã lớp";
                    dgvShow.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải chi tiết lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
