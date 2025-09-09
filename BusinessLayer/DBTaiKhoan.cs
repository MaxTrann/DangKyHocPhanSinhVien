using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBTaiKhoan
    {
        DAL db = null;
        public DBTaiKhoan() 
        {
            db = new DAL();    
        } 
        public void SinhVienConnect()
        {
            db.changeStrConnectToSinhVien();
        }

        public void GiangVienConnect()
        {
            db.changeStrConnectToGiangVien();
        }

        // Thực hiện đăng nhập 
        public int DangNhap(string TenDangNhap, string MatKhau)
        {
            DataSet tk = db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTO_DangNhap('{TenDangNhap}', '{MatKhau}')", CommandType.Text);
            if (tk == null || tk.Tables.Count == 0 ||tk.Tables[0].Rows.Count == 0)
            {
                return 0; // sai
            }
            else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "Quản Lý")
            {
                return 1; // Trả về quản lý
            }
            else if (tk.Tables[0].Rows[0].Field<string>("VaiTro") == "Sinh Viên")
            {
                return 2; // Trả về sinh viên
            }
            else
            {
                return 3; // Trả về giảng viên
            }
        }

        // Đổi mật khẩu
        public bool DoiMatKhau(ref string err, string TenDangNhap, string MatKhau)
        {
            return db.MyExecuteNonQuery("Re_DoiMatKhau", CommandType.StoredProcedure, 
                ref err,
                new SqlParameter("@MatKhau", MatKhau), new SqlParameter("@TenDangNhap", TenDangNhap));
        }
    }
}
