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
    public class DBGiangVien
    {
        DAL db = null;
        public DBGiangVien()
        {
            db = new DAL();
        }

        public void GiangVienConnect()
        {
            db.changeStrConnectToGiangVien();
        }

        public DataSet DSGiangVien()
        {
            return db.MyExecuteQueryDataSet("NonP_DanhSachGV", CommandType.StoredProcedure);
        }

        public DataSet ThongTinGV(string MaGV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTO_ThongTinGV('{MaGV}')", CommandType.Text);
        }

        public bool ThemGV(ref string err, string TenDangNhap, string MatKhau, string HoTenGV, string MaKhoa)
        {
            return db.MyExecuteNonQuery("Re_ThemGV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@HoTenGV", HoTenGV),
                new SqlParameter("@MaKhoa", MaKhoa));
        }
        public bool XoaGV(ref string err, string MaGV)
        {
            return db.MyExecuteNonQuery("Re_XoaGV", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaGV", MaGV));
        }
    }
}
