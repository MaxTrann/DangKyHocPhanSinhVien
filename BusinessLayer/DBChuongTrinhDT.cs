using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBChuongTrinhDT
    {
        DAL db = null;
        public DBChuongTrinhDT()
        {
            db = new DAL();
        }

        public DataSet DanhSachCTDT()
        {
            return db.MyExecuteQueryDataSet("NonP_DanhSachCTDT", CommandType.StoredProcedure);
        }
    }
}
