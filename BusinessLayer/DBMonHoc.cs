using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BusinessLayer
{
    public class DBMonHoc
    {
        DAL db = null;
        public DBMonHoc()
        {
            db = new DAL();
        }

        public DataSet DSMonHoc()
        {
            return db.MyExecuteQueryDataSet("NonP_DanhSachMH", CommandType.StoredProcedure);
        }

        public DataSet TimKiemMH(String MaMH)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTO_TimKiemMonHoc('{MaMH}')", CommandType.Text);
        }

        public bool ThemMH (ref string err, string MaMH, string TenMH, int SoTinChi, string MaKhoa)
        {
            return db.MyExecuteNonQuery("Re_ThemMH", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMH", MaMH),
                new SqlParameter("@TenMH", TenMH),
                new SqlParameter("@SoTinChi", SoTinChi),
                new SqlParameter("@MaKhoaPhuTrach", MaKhoa));
        }

        public bool XoaMH (ref string err, string MaMH)
        {
            return db.MyExecuteNonQuery("Re_XoaMH", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaMH", MaMH));
        }

        public bool Exists(string maMH)
        {
            var ds = db.MyExecuteDataSetParam(
                "SELECT 1 FROM MONHOC WHERE MaMH = @MaMH",
                CommandType.Text,
                new SqlParameter("@MaMH", maMH)
            );
            return ds.Tables[0].Rows.Count > 0;
        }
    }
}
