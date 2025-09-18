using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class DBSinhVien
    {
        DAL db = null;
        public DBSinhVien()
        {
            db = new DAL();
        }

        public void SinhVienConnect()
        {
            db.changeStrConnectToSinhVien();
        }

        // Hiển thị thông tin sinh viên
        public DataSet ThongTin(string MaSV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTO_ThongTinSV('{MaSV}')", CommandType.Text);
        }

        // Hiển thị học phần chương trình đào tạo
        public DataSet HocPhanCTDTSV (string MaSV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTM_HocPhanCTDTSV('{MaSV}')", CommandType.Text);
        }
        // Hiển thị danh sách sinh viên đăng kí môn học
        public DataSet DSSinhVienDKMH()
        {
            return db.MyExecuteQueryDataSet("NonP_DanhSachDKMH", CommandType.StoredProcedure);
        }
        // Thêm sinh viên 
        public bool ThemSV (ref string err, string TenDangNhap, string MatKhau, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop)
        {
            return db.MyExecuteNonQuery("Re_ThemSV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@HoTenSV", HoTenSV),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@MaLop", MaLop));
        }

        public bool XoaSV(ref string err, string MaSV)
        {
            return db.MyExecuteNonQuery("Re_XoaSV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaSV", MaSV));
        }

        public bool CapNhatSV(ref string err, string TenDangNhap,  string HoTenSV, string GioiTinh, string NgaySinh, string MaLop)
        {
            return db.MyExecuteNonQuery("Re_CapNhatSV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@HoTenSV", HoTenSV),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@MaLop", MaLop));
        }

    }
}
