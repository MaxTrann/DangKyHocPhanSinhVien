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
    public partial class FrmTrangAdmin : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();
        DBQuanLy ql = new DBQuanLy();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangAdmin()
        {
            InitializeComponent();
            dgvDsSinhVien.ReadOnly = true;
            dgvDsSinhVien.MultiSelect = false;
            dgvDsSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void FrmTrangAdmin_Load(object sender, EventArgs e)
        {
            this.txtTenQL.Text = ql.ThongTin(MaSo).Tables[0].Rows[0].Field<string>("TenQL");
            txtTenQL.ReadOnly = true;
            this.dgvDsSinhVien.DataSource = sv.DSSinhVienDKMH().Tables[0];

            dgvDsSinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvDsSinhVien.Columns[1].HeaderText = "Họ Tên";
            dgvDsSinhVien.Columns[2].HeaderText = "Tên Ngành";

            dgvDsSinhVien.Columns[0].Width = 150;
            dgvDsSinhVien.Columns[1].Width = 200;
            dgvDsSinhVien.Columns[2].Width = 200;

            dgvDsSinhVien.ReadOnly = true;
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            FrmQuanLySinhVien frmQuanLySinhVien = new FrmQuanLySinhVien();
            frmQuanLySinhVien.Show();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            FrmGiangVien frmGiangVien = new FrmGiangVien();
            frmGiangVien.Show();
        }

        private void btnQLK_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhoaNganh frmQuanLyKhoaNganh = new FrmQuanLyKhoaNganh();
            frmQuanLyKhoaNganh.Show();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            FrmQuanLyMonHoc frmQuanLyMonHoc = new FrmQuanLyMonHoc();
            frmQuanLyMonHoc.Show();
        }

        private void btnQLPH_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhongHoc frmQuanLyPhongHoc = new FrmQuanLyPhongHoc();
            frmQuanLyPhongHoc.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
