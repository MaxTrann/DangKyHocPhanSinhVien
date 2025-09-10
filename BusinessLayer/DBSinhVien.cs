using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GiangVienConnect()
        {
            db.changeStrConnectToGiangVien();
        }

        // Hiển thị thông tin sinh viên
        public DataSet ThongTin(string _MaSV)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FORM dbo.fn_ThongTinSV('{_MaSV}')", CommandType.Text);
        }


    }
}
