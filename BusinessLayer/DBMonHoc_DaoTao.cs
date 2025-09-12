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
    public class DBMonHoc_DaoTao
    {
        DAL db = null;
        public DBMonHoc_DaoTao()
        {
            db = new DAL();
        }

        public DataSet DsMHDT()
        {
            return db.MyExecuteQueryDataSet("NonP_DanhSachMHDT", CommandType.StoredProcedure);
        }

        public DataSet TimKiemMHDT(string MaMDHT)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTO_TimKiemMHDT('{MaMDHT}')", CommandType.Text);
        }

        public bool ThemMHDT (ref string err, string MaMHDT, string MaMH, string MaCTDT, string MaNganh)
        {
            return db.MyExecuteNonQuery("Re_ThemMHDT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMHDT", MaMHDT),
                new SqlParameter("@MaMH", MaMH),
                new SqlParameter("@MaCTDT", MaCTDT),
                new SqlParameter("@MaNganh", MaNganh));
        }
        public bool XoaMHDT(ref string err, string MaMHDT)
        {
            return db.MyExecuteNonQuery("Re_XoaMHDT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMHDT", MaMHDT));
        }   
    }
}
