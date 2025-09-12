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
    public class DBNganh
    {
        DAL db = null;
        public DBNganh()
        {
            db = new DAL();
        }

        public int TongSVNganh(string nganh)
        {
            return db.MyExecuteScalarFunction($"SELECT dbo.RNO_TongSVNganh(N'{nganh}')");
        }

        public DataSet DanhSachSVNganh (string nganh)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTM_DsSVNganh(N'{nganh}')", CommandType.Text);
        }

        public DataSet DanhSachNganh()
        {
            return db.MyExecuteQueryDataSet("SELECT * FROM dbo.RTO_DanhSachNganh()", CommandType.Text);
        }

        public DataSet TimKiemNganh(string nganh)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTO_TimKiemNganh(N'{nganh}')", CommandType.Text);
        }

        public bool ThemNganh(ref string err, string MaNganh, string TenNganh, string TenKhoa)
        {
            return db.MyExecuteNonQuery("Re_ThemNganh", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNganh", MaNganh),
                new SqlParameter("@TenNganh", TenNganh),
                new SqlParameter("@TenKhoa", TenKhoa));
        }

        public bool XoaNganh(ref string err, string MaNganh)
        {
            return db.MyExecuteNonQuery("Re_XoaNganh", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNganh", MaNganh));
        }
    }
}
