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
    public partial class FrmDangKy : Form
    {
        private string maso;
        private string mamh;
        public string TenMh { get; set; }


        DBSinhVien sv = new DBSinhVien();
        DBLopHoc lh = new DBLopHoc();
        DBDangKy dk = new DBDangKy();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        public string MaMh
        {
            get { return mamh; }
            set { mamh = value; }
        }

        public FrmDangKy()
        {
            InitializeComponent();
            dgvShow.ReadOnly = true;
            dgvShow.MultiSelect = false;
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            groupBox1.Text = $"{TenMh}";
            loadLopHoc();
        }

        public void loadLopHoc()
        {
            try
            {
                DataSet ds = lh.DanhSachLH(mamh, maso);
                dgvShow.DataSource = ds.Tables[0];

                dgvShow.Columns[0].HeaderText = "Mã lớp học";
                dgvShow.Columns[1].HeaderText = "Tên giảng viên";
                dgvShow.Columns[2].HeaderText = "Giới hạn";
                dgvShow.Columns[3].HeaderText = "Đã đăng ký";
                dgvShow.Columns[4].HeaderText = "Phòng";
                dgvShow.Columns[5].HeaderText = "Thứ";
                dgvShow.Columns[6].HeaderText = "Tiết bắt đầu";
                dgvShow.Columns[7].HeaderText = "Tiết kết thúc";
                dgvShow.Columns[8].HeaderText = "Thời gian bắt đầu";
                dgvShow.Columns[9].HeaderText = "Thời gian kết thúc";

                dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvShow.Columns[0].FillWeight = 20;  // Mã lớp học
                dgvShow.Columns[1].FillWeight = 25;  // Tên giảng viên
                dgvShow.Columns[2].FillWeight = 10;  // Giới hạn
                dgvShow.Columns[3].FillWeight = 10;  // Phòng
                dgvShow.Columns[4].FillWeight = 10;  // Thứ
                dgvShow.Columns[5].FillWeight = 10;  // Tiết bắt đầu
                dgvShow.Columns[6].FillWeight = 15;  // Tiết kết thúc
                dgvShow.Columns[7].FillWeight = 15;  // Thời gian bắt đầu
                dgvShow.Columns[8].FillWeight = 20;  // Thời gian kết thúc
                dgvShow.Columns[9].FillWeight = 20;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maLH = dgvShow.CurrentRow.Cells["MaLopHoc"].Value.ToString();

            if (dgvShow.CurrentRow == null) return;

            if (MessageBox.Show($"Đăng ký lớp {maLH} cho {MaSo}?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;


            string err = "";
            bool kq = false;

            try
            {
                kq = dk.DangKyLH(ref err, maLH, maso);
                if (kq)
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLopHoc();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Đăng ký thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
