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
    public class DBLopHoc
    {
        DAL db = null;
        public DBLopHoc()
        {
            db = new DAL();
        }

        public DataSet DSLopHoc()
        {
            string sql = "SELECT * FROM LOPHOC";
            return db.MyExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimLopHoc(string MaLH)
        {
            return db.MyExecuteDataSetParam($"HasP_TimKiemLop", CommandType.StoredProcedure, new SqlParameter("@MaLH", MaLH));
        }

        public bool ThemLopHoc(ref string err, string MaLopHoc, string MaMHDT, string MaGV, int SoLuong, string Phong, string Thu, int TietBatDau, int TietKetThuc, string ThoiGianBatDau, string ThoiGianKetThuc, string HocKy, int nam)
        {
            return db.MyExecuteNonQuery("Re_ThemLH", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLopHoc", MaLopHoc),
                new SqlParameter("@MaMHDT", MaMHDT),
                new SqlParameter("@MaGV", MaGV),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@Phong", Phong),
                new SqlParameter("@Thu", Thu),
                new SqlParameter("@TietBatDau", TietBatDau),
                new SqlParameter("@TietKetThuc", TietKetThuc),
                new SqlParameter("@ThoiGianBatDau", ThoiGianBatDau),
                new SqlParameter("@ThoiGianKetThuc", ThoiGianKetThuc),
                new SqlParameter("@HocKy", HocKy),
                new SqlParameter("@Nam", nam));
        }

        public bool XoaLopHoc(ref string err, string MaLH)
        {
            return db.MyExecuteNonQuery("Re_XoaLH", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLopHoc", MaLH));
        }

        public DataSet TimKiemLopHocTheoMH(string MaMH)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTM_TimKiemLopHocTheoMon(N'{MaMH}')", CommandType.Text);
        }

        public DataSet ThoiKhoaBieuSV(string MaSV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTM_XemTKB('{MaSV}')", CommandType.Text);
        }

        public DataSet DanhSachSVLH(string MaLH)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTO_DanhSachSVLopHoc('{MaLH}')", CommandType.Text);
        }
        public DataSet ThoiKhoaBieuGV(String MaGV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTM_XemTKBGV(N'{MaGV}')", CommandType.Text);
        }

        public DataSet ChiTietLopHocGV(String MaGV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTM_ChiTietLHGV(N'{MaGV}')", CommandType.Text);
        }
        public int TongSVLH(string MaLH)
        {
            return db.MyExecuteScalarFunction($"SELECT dbo.RNO_TongSVLopHoc(N'{MaLH}')");
        }

        public DataSet DanhSachLH(string MaLH, string MaSV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM RTM_TimKiemLHDK('{MaLH}', '{MaSV}')", CommandType.Text);

        }
    }
}
