using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Database
{
    internal class SeekerDAO
    {
        DBAccess connect = new DBAccess();

        public DataTable ReloadFeed()
        {
            string sqlStr = "select * from BAIDANG";
            return connect.Reload(sqlStr);
        }
    }
}
