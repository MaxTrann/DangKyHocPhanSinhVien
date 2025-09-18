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
    public partial class FrmDangNhap : Form
    {
        DBTaiKhoan tk = new DBTaiKhoan();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBao.ResetText();
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";
            int check = tk.DangNhap(txtDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
            if (check == 1)
            {
                FrmTrangAdmin ad = new FrmTrangAdmin();
                ad.MaSo = txtDangNhap.Text.Trim(); // gán mã số để biết user nào đang đăng nhập
                ad.ShowDialog(); // mở form
                txtDangNhap.ResetText();
                txtMatKhau.ResetText();
                this.Hide();
                this.Show();
            }
            else if (check == 2)
            {
                FrmTrangSinhVien sv = new FrmTrangSinhVien();
                sv.Maso = txtDangNhap.Text.Trim(); // gán mã số để biết user nào đang đăng nhập
                sv.ShowDialog();
                txtDangNhap.ResetText();
                txtMatKhau.ResetText();
                this.Hide();
                this.Show();
            }
            else if (check == 3)
            {
                FrmTrangGiangVien gv = new FrmTrangGiangVien();
                gv.Maso = txtDangNhap.Text.Trim(); // gán mã số để biết user nào đang đăng nhập
                gv.ShowDialog();
                txtDangNhap.ResetText();
                txtMatKhau.ResetText();
                this.Hide();
                this.Show();
            }
            else
            {
                lblThongBao.Text = err;
                txtDangNhap.ResetText();
                txtMatKhau.ResetText();
                txtDangNhap.Focus();
            }
        }

        private void cboHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cboHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
