using System;
using System.Windows.Forms;

namespace DangKyHocPhanSinhVien
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap()); // form khởi động
        }
    }
}
