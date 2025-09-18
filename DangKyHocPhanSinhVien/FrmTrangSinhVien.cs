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
    public partial class FrmTrangSinhVien : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();

        public string Maso 
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangSinhVien()
        {
            InitializeComponent();
            dgvShow.ReadOnly = true;
            dgvShow.MultiSelect = false;
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmTrangSinhVien_Load(object sender, EventArgs e)
        {
            loadThongTin();
        }
        void loadThongTin()
        {
            txtTenSV.Text = sv.ThongTin(maso).Tables[0].Rows[0].Field<string>("HoTenSV");
            txtMaSV.Text = sv.ThongTin(maso).Tables[0].Rows[0].Field<string>("MaSV");
            dgvShow.DataSource = sv.HocPhanCTDTSV(maso).Tables[0];

            dgvShow.Columns[0].HeaderText = "Mã môn học";
            dgvShow.Columns[1].HeaderText = "Tên môn học";
            dgvShow.Columns[2].HeaderText = "Số tín chỉ";
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FrmTraCuuMonHoc frmTraCuuMonHoc = new FrmTraCuuMonHoc();
            frmTraCuuMonHoc.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauSV dmk = new FrmDoiMatKhauSV();
            dmk.Maso = maso;
            dmk.ShowDialog();
        }
    }
}
