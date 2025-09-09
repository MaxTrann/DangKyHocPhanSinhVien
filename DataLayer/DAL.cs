using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAL
    {
        SqlConnection conn = null;  
        SqlCommand cmd = null;  
        SqlDataAdapter da = null;

        string strConnect = "Data Source=.;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;";

        public DAL()
        {
            conn = new SqlConnection(strConnect);
            cmd = conn.CreateCommand();
        }
        // Persist Security Info=False: nếu ai đọc đọc lại connection.ConnectionString thì không thấy User/Password nữa
        // 
        public void changeStrConnectToSinhVien()
        {
            strConnect = "Data Source=.;Initial Catalog=QUANLYSINHVIEN;User ID=sinhvien;Password=sinhvien;Persist Security Info=False;MultipleActiveResultSets=True;";
            conn = new SqlConnection(strConnect);
            cmd = conn.CreateCommand();
        }

        public void changeStrConnectToGiangVien()
        {
            strConnect = "Data Source=.;Initial Catalog=QUANLYSINHVIEN;User ID=giangvien;Password=giangvien;Persist Security Info=False;MultipleActiveResultSets=True;";
            conn = new SqlConnection(strConnect);
            cmd = conn.CreateCommand();
        }

        public DataSet MyExecuteQueryDataSet (string strSql, CommandType ct) // SELECT / EXEC SP không tham số -> trả về DataSet
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.CommandText = strSql;
                cmd.CommandType = ct;
                cmd.Parameters.Clear(); // xóa tham số cũ
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            finally { conn.Close(); }
            
        }

        public DataSet MyExecuteDataSetParam(string strSql, CommandType ct, params SqlParameter[] param) //// SELECT / EXEC SP có tham số -> trả DataSet
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                cmd.CommandText = strSql;
                cmd.CommandType = ct;
                cmd.Parameters.Clear(); // xóa tham số cũ

                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            finally { conn.Close(); }
        }

        // Thực thi lệnh không trả dữ liệu (Thêm/sửa/xóa). Nếu thành công trả về true, ngược lại false và gán error
        public bool MyExecuteNonQuery (string strSql, CommandType ct, ref string error, params SqlParameter[] param) 
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSql;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            try {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public int MyExecuteScalarFunction(string strSql) // chạy lệnh trả về một giá trị (ô đầu tiên hàng đầu tiên) và ép về int.
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = strSql;
                cmd.CommandType = CommandType.Text;

                int result = 0;

                int? count = cmd.ExecuteScalar() as int?;
                if (count != null)
                {
                    result = count.Value;
                }
                return result;
            }
            finally { conn.Close(); }
        }

        public string MyExecuteQueryXML (string strSql, CommandType ct, params SqlParameter[] p) // chạy SELECT/SP và trả về chuỗi XML của DataSet
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                cmd.CommandText = strSql;
                cmd.CommandType = ct;
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.GetXml();
            }
            finally { conn.Close(); }
        }
    }
}
