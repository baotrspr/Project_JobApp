using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    public class BaiDangDAO
    {
        DBAccess dba = new DBAccess();
        public BaiDangDAO() { }

        public DataTable GetData()
        {
            string sqlStr = string.Format("select * from BAIDANG");
            return dba.Reload(sqlStr);
        }

        public bool Them(Feeds f)
        {
            string sqlStr = string.Format("insert into BAIDANG values ('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}',N'{6}')",
                                            f.Feedid, f.Loaibai, f.Tieude, f.Noidung, f.NgDang, f.Userid, f.Jobdetail);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }
    }
}
