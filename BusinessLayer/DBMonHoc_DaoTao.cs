using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
