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
    public partial class FrmDanhSachHocPhan : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDanhSachHocPhan()
        {
            InitializeComponent();

            dgvShow.ReadOnly = true;
            dgvShow.MultiSelect = false;
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShow.AutoGenerateColumns = false;

            buildCol();
        }

        // Thêm cột bằng code
        private void buildCol()
        {
            dgvShow.Columns.Clear();

            dgvShow.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaMH",
                HeaderText = "Mã môn học",
                DataPropertyName = "MaMH",
                FillWeight = 20
            });

            dgvShow.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TenMH",
                HeaderText = "Tên môn học",
                DataPropertyName = "TenMH",
                FillWeight = 50
            });

            dgvShow.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SoTinChi",
                HeaderText = "Số tín chỉ",
                DataPropertyName = "SoTinChi",
                FillWeight = 15
            });

            dgvShow.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLHP",
                HeaderText = "Số LHP",
                DataPropertyName = "SoLHP",
                FillWeight = 10,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            var btn = new DataGridViewButtonColumn
            {
                Name = "DangKy",
                HeaderText = "",
                Text = "Đăng ký",
                UseColumnTextForButtonValue = true,
                FillWeight = 10
            };
            dgvShow.Columns.Add(btn);

            dgvShow.RowTemplate.Height = 30; 
            dgvShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        public void loadHocPhan()
        {
            DataTable dt = sv.HocPhanCTDTSV(maso).Tables[0];
            dgvShow.DataSource = dt;
        }

        private void FrmDanhSachHocPhan_Load(object sender, EventArgs e)
        {
            loadHocPhan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvShow.Columns[e.ColumnIndex].Name != "DangKy") return;

            var row = (dgvShow.Rows[e.RowIndex].DataBoundItem as DataRowView)?.Row;
            if (row == null) return;

            string maMH = row.Field<string>("MaMH");
            FrmDangKy dk = new FrmDangKy();
            dk.MaMh = maMH;
            dk.MaSo = maso;
            dk.TenMh = row.Field<string>("TenMH");
            dk.ShowDialog();

        }
    }
}
