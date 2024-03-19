using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Display(Feeds feeds)
        {

        }
    }
}
