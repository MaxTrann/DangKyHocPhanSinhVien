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
    public partial class FrmTraCuuMonHoc : Form
    {
        DBLopHoc lh = new DBLopHoc();   
        public FrmTraCuuMonHoc()
        {
            InitializeComponent();
            //lh.SinhVienConnect();
            dgvDanhSachLopHoc.ReadOnly = true;
            dgvDanhSachLopHoc.MultiSelect = false;
            dgvDanhSachLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void loadDSLopHoc()
        {
            var dt = lh.DSLopHoc().Tables[0];
            DataView dv = dt.DefaultView;
            dv.Sort = "Thu ASC";   // hoặc DESC nếu muốn ngược lại
            dgvDanhSachLopHoc.DataSource = dv;
            dgvDanhSachLopHoc.Columns[0].HeaderText = "Mã lớp học";
            dgvDanhSachLopHoc.Columns[1].HeaderText = "Mã MHDT";
            dgvDanhSachLopHoc.Columns[2].HeaderText = "Mã giảng viên";
            dgvDanhSachLopHoc.Columns[3].HeaderText = "Số lượng";
            dgvDanhSachLopHoc.Columns[4].HeaderText = "Tên Phòng";
            dgvDanhSachLopHoc.Columns[5].HeaderText = "Thứ";
            dgvDanhSachLopHoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
            dgvDanhSachLopHoc.Columns[7].HeaderText = "Tiết Kết Thúc";
            dgvDanhSachLopHoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
            dgvDanhSachLopHoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
            dgvDanhSachLopHoc.Columns[10].HeaderText = "Học kỳ";
            dgvDanhSachLopHoc.Columns[11].HeaderText = "Năm";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maMH = (txtMonHoc.Text).Trim();
            if (string.IsNullOrWhiteSpace(maMH))
            {
                MessageBox.Show("Vui lòng nhập mã lớp học để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var ds = lh.TimKiemLopHocTheoMH(maMH);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy lớp học nào với mã môn học đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvDanhSachLopHoc.DataSource = ds.Tables[0];
                dgvDanhSachLopHoc.Columns[0].HeaderText = "Mã lớp học";
                dgvDanhSachLopHoc.Columns[1].HeaderText = "Tên môn học";
                dgvDanhSachLopHoc.Columns[2].HeaderText = "Mã giảng viên";
                dgvDanhSachLopHoc.Columns[3].HeaderText = "Số lượng";
                dgvDanhSachLopHoc.Columns[4].HeaderText = "Tên Phòng";
                dgvDanhSachLopHoc.Columns[5].HeaderText = "Thứ";
                dgvDanhSachLopHoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
                dgvDanhSachLopHoc.Columns[7].HeaderText = "Tiết Kết Thúc";
                dgvDanhSachLopHoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
                dgvDanhSachLopHoc.Columns[9].HeaderText = "Thời gian Kết Thúc";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
