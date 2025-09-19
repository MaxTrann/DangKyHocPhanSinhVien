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
    public partial class FrmTrangGiangVien : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangGiangVien()
        {
            InitializeComponent();
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauGV dmk = new FrmDoiMatKhauGV();    
            dmk.Maso = maso;
            dmk.ShowDialog();
        }

        private void FrmTrangGiangVien_Load(object sender, EventArgs e)
        {
            txtTenGV.Text = gv.ThongTinGV(maso).Tables[0].Rows[0].Field<string>("HoTenGV");

            DataTable dt = lh.ThoiKhoaBieuGV(maso).Tables[0];

            // Thêm cột phụ để map thứ -> số
            dt.Columns.Add("ThuSo", typeof(int));
            foreach (DataRow row in dt.Rows)
            {
                var thu = row["Thu"] == DBNull.Value ? string.Empty : row["Thu"].ToString().Trim();
                row["ThuSo"] = MapThu(thu);
            }

            // Sort bằng DataView
            DataView dv = dt.DefaultView;
            dv.Sort = "ThuSo ASC, TietBatDau ASC"; // trùng thứ thì xếp theo tiết

            dgvDanhSach.DataSource = dv.ToTable();

            dgvDanhSach.Columns[0].HeaderText = "Mã lớp học";
            dgvDanhSach.Columns[1].HeaderText = "Tên môn học";
            dgvDanhSach.Columns[2].HeaderText = "Thứ";
            dgvDanhSach.Columns[3].HeaderText = "Tiết bắt đầu";
            dgvDanhSach.Columns[4].HeaderText = "Tiết kết thúc";
            dgvDanhSach.Columns[5].HeaderText = "Phòng";

            // Ẩn cột phụ
            if (dgvDanhSach.Columns.Contains("ThuSo"))
                dgvDanhSach.Columns["ThuSo"].Visible = false;
        }
        private static int MapThu(string thu)
        {
            switch (thu)
            {
                case "Thứ 2": return 2;
                case "Thứ 3": return 3;
                case "Thứ 4": return 4;
                case "Thứ 5": return 5;
                case "Thứ 6": return 6;
                case "Thứ 7": return 7;
                case "CN":
                case "Chủ nhật": return 8; 
                default: return 9;           
            }
        }

        private void btnDSLH_Click(object sender, EventArgs e)
        {
            FrmDanhSachLopHocGV ds = new FrmDanhSachLopHocGV();
            ds.MaSo = maso;
            ds.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
