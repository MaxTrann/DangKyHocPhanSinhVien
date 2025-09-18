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
    public class DBLop
    {
        DAL db = null;
        public DBLop()
        {
            db = new DAL();
        }   

        public DataSet DSLop()
        {
            return db.MyExecuteQueryDataSet("NonP_DanhSachLop", CommandType.StoredProcedure);
        }

        public DataSet DSSVLop(string MaLop)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTO_ThongTinSVLop('{MaLop}')", CommandType.Text);
        }

        public bool ThemLop(ref string err, string MaLop, string TenLop, string MaNganh, string MaCTDT)
        {
            return db.MyExecuteNonQuery("Re_ThemLop", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLop", MaLop),
                new SqlParameter("@TenLop", TenLop),
                new SqlParameter("@MaNganh", MaNganh),
                new SqlParameter("@MaCTDT", MaCTDT));
        }
        public bool XoaLop(ref string err, string MaLop)
        {
            return db.MyExecuteNonQuery("Re_XoaLop", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLop", MaLop));
        }
    }
}
