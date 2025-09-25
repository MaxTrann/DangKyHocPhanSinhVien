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
            string username = txtDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";

            int check = tk.DangNhap(username, password);
            if (check > 0) // đăng nhập thành công
            {
                // === ĐỔI CONNECTION STRING TOÀN CỤC ===
                DataLayer.DAL.SetConnection(username, password);

                // 2) (Debug) xác minh kết nối đang là ai
                //var dal = new DataLayer.DAL(); // tạo DAL mới để dùng chuỗi vừa set
                //var who = dal.MyExecuteQueryDataSet(
                //    "SELECT SYSTEM_USER, ORIGINAL_LOGIN()", CommandType.Text);
                //MessageBox.Show($"SYSTEM_USER={who.Tables[0].Rows[0][0]}; ORIGINAL_LOGIN={who.Tables[0].Rows[0][1]}");

                if (check == 1) // quản lý
                {
                    FrmTrangAdmin ad = new FrmTrangAdmin();
                    ad.MaSo = username;
                    this.Hide();
                    ad.ShowDialog();
                    this.Show();
                }
                else if (check == 2) // sinh viên
                {
                    FrmTrangSinhVien sv = new FrmTrangSinhVien();
                    sv.MaSo = username;
                    this.Hide();
                    sv.ShowDialog();
                    this.Show();
                }
                else if (check == 3) // giảng viên
                {
                    FrmTrangGiangVien gv = new FrmTrangGiangVien();
                    gv.MaSo = username;
                    this.Hide();
                    gv.ShowDialog();
                    this.Show();
                }

                txtDangNhap.ResetText();
                txtMatKhau.ResetText();
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
