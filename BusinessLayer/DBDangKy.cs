using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBDangKy
    {
        DAL db = null;
        public DBDangKy()
        {
            db = new DAL();
        }   
        public bool DangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            return db.MyExecuteNonQuery("Re_DangKyLH", System.Data.CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@MaLopHoc", MaLopHoc),
                new System.Data.SqlClient.SqlParameter("@MaSV", MaSV));
        }

        public bool XoaDangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            return db.MyExecuteNonQuery("Re_XoaDangKyLH", System.Data.CommandType.StoredProcedure, ref err,
                new System.Data.SqlClient.SqlParameter("@MaLopHoc", MaLopHoc),
                new System.Data.SqlClient.SqlParameter("@MaSV", MaSV));
        }
    }
}
