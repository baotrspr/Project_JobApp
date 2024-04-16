using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.DAO
{
    public class AppliedListDAO
    {
        DBAccess dba = new DBAccess();
        public AppliedListDAO() { }
        
        public bool KiemtraUT(string userid)
        {
            string sqlStr = string.Format("select * from UNGTUYEN where userid = '{0}'", userid);
            DataTable dt = dba.ExecuteSelect(sqlStr);
            return dt.Rows.Count > 0;
        }

        public DataTable GetSeekerData(string companyid)
        {
            string sqlStr = string.Format("select * from UNGTUYEN where congty = '{0}'", companyid);
            return dba.ExecuteSelect(sqlStr);
        }

        public DataTable GetJobData(string seekerid)
        {
            string sqlStr = string.Format("select * from UNGTUYEN where userid = '{0}'", seekerid);
            return dba.ExecuteSelect(sqlStr);
        }

        public bool Them(AppliedList ap)
        {
            string sqlStr = string.Format("insert into UNGTUYEN values ('{0}','{1}',N'{2}','{3}','{4}','{5}')",
                                            ap.Userid, ap.Jobid, ap.Tencv, ap.Thoigian, ap.Macty, ap.TTphanhoi);
            return dba.Execute(sqlStr);
        }

        public bool ChapNhan(AppliedList ap)
        {
            string sqlStr = string.Format("update UNGTUYEN set trangthaiphanhoi = '{0}' where userid = '{1}'", "accepted", ap.Userid);
            return dba.Execute(sqlStr);
        }
        public bool TuChoi(AppliedList ap)
        {
            string sqlStr = string.Format("update UNGTUYEN set trangthaiphanhoi = '{0}' where userid = '{1}'", "rejected", ap.Userid);
            return dba.Execute(sqlStr);
        }
        public bool Xoa(AppliedList ap)
        {
            string sqlStr = string.Format("delete from UNGTUYEN where userid = '{0}' and jobid = '{1}'", ap.Userid, ap.Jobid);
            return dba.Execute(sqlStr);
        }
    }
}
