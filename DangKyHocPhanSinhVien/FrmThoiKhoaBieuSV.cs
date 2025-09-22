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
    public partial class FrmThoiKhoaBieuSV : Form
    {
        private const string FIXED_HOCKY = "HK1";
        private const int FIXED_NAM = 2025;
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBDangKy dk = new DBDangKy();
        DBSinhVien sv = new DBSinhVien();
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        public FrmThoiKhoaBieuSV()
        {
            InitializeComponent();
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDanhSach.AutoGenerateColumns = false;   // rất quan trọng
            BuildCols();

            // Cập nhật lại STT mỗi khi bind/sort
            dgvDanhSach.DataBindingComplete += (s, e) => UpdateSTT(); // sau khi gán dữ liệu xong gọi hàm để update STT
            dgvDanhSach.Sorted += (s, e) => UpdateSTT(); // sau khi sắp xếp xong gọi hàm để update STT

        }
        public void loadTKB()
        {
            try
            {
                DataSet ds = lh.ThoiKhoaBieuSV(maso);
                dgvDanhSach.DataSource = ds.Tables[0];
                UpdateSTT();

                int tong = sv.TongSoTinChiDK(maso, FIXED_HOCKY, FIXED_NAM);
                txtSoTinChi.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BuildCols()
        {
            dgvDanhSach.Columns.Clear();

            // STT (không bind)
            var colStt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT",
                ReadOnly = true,
                FillWeight = 6,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvDanhSach.Columns.Add(colStt);

            // Mã lớp học
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaLopHoc",
                HeaderText = "Mã lớp học",
                DataPropertyName = "MaLopHoc",  // map từ function
                FillWeight = 15
            });

            // Tên môn học
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenMH",
                HeaderText = "Tên môn học",
                DataPropertyName = "TenMH",
                FillWeight = 25
            });

            // Tên giảng viên
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTenGV",
                HeaderText = "Tên giảng viên",
                DataPropertyName = "HoTenGV",
                FillWeight = 20
            });

            // Thứ
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Thu",
                HeaderText = "Thứ",
                DataPropertyName = "Thu",
                FillWeight = 8
            });

            // Tiết bắt đầu
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TietBatDau",
                HeaderText = "Tiết bắt đầu",
                DataPropertyName = "TietBatDau",
                FillWeight = 8,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Tiết kết thúc
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TietKetThuc",
                HeaderText = "Tiết kết thúc",
                DataPropertyName = "TietKetThuc",
                FillWeight = 8,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Phòng
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenPhong",
                HeaderText = "Phòng",
                DataPropertyName = "TenPhong",
                FillWeight = 10
            });
        }

        private void UpdateSTT()
        {
            for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
            {
                var row = dgvDanhSach.Rows[i];
                if (!row.IsNewRow)
                    row.Cells["STT"].Value = (i + 1).ToString();
            }
        }


        private void FrmThoiKhoaBieuSV_Load(object sender, EventArgs e)
        {
            loadTKB();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaDangKyLH_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học để hủy đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLH = dgvDanhSach.CurrentRow.Cells["MaLopHoc"].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc muốn xóa đăng ký lớp {maLH} không?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            string err = "";
            bool kq = false;

            try
            {
                kq = dk.XoaDangKyLH(ref err, maLH, maso);
                if (kq)
                {
                    MessageBox.Show("Hủy đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTKB();
                }
                else
                {
                    MessageBox.Show("Hủy đăng ký thất bại. Lỗi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
