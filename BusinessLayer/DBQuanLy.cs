using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBQuanLy
    {
        DAL db = null;
        public DBQuanLy()
        {
            db = new DAL();
        }
        // Hiển thị thông tin quản lý   
        public DataSet ThongTin (string maso)
        {
            return db.MyExecuteQueryDataSet($"SELECT * FROM dbo.RTO_ThongTinQL('{maso}')", CommandType.Text);
        }
    }
}
