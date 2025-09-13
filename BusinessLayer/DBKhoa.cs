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
    public class DBKhoa
    {
        DAL db = null;
        public DBKhoa()
        {
            db = new DAL();
        }   

        public int TongSVKhoa(string khoa)
        {
            return db.MyExecuteScalarFunction($"SELECT dbo.RNO_TongSVKhoa(N'{khoa}')");
        }

        public DataSet DanhSachSVKhoa(string khoa)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTM_DsSVKhoa(N'{khoa}')", CommandType.Text);
        }

        public DataSet DanhSachKhoa()
        {
            return db.MyExecuteQueryDataSet("SELECT * FROM dbo.RTO_DanhSachKhoa()", CommandType.Text);
        }

        public DataSet TimKiemKhoa(string khoa)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTO_TimKiemKhoa(N'{khoa}')", CommandType.Text);
        }

        public bool ThemKhoa(ref string err, string MaKhoa, string TenKhoa)
        {
            return db.MyExecuteNonQuery("Re_ThemKhoa", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhoa", MaKhoa),
                new SqlParameter("@TenKhoa", TenKhoa));
        }

        public bool XoaKhoa(ref string err, string MaKhoa)
        {
            return db.MyExecuteNonQuery("Re_XoaKhoa", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKhoa", MaKhoa));
        }
        public bool Exists(string maKhoa)
        {
            var ds = db.MyExecuteDataSetParam(
                "SELECT 1 FROM KHOA WHERE MaKhoa = @MaKhoa",
                CommandType.Text,
                new SqlParameter("@MaKhoa", maKhoa)
            );
            return ds.Tables[0].Rows.Count > 0;
        }
    }
}
