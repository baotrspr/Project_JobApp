using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    public class AppliedListDAO
    {
        DBAccess dba = new DBAccess();
        public AppliedListDAO() { }
        
        public bool KiemtraUT(string userid)
        {
            using (var db = new JobAppDFContext())
            {
                var acc = db.UNGTUYEN.Where(s => s.userid == userid).ToList();
                if (acc.Count > 0 )
                {
                    return true;
                }
                return false;
            }
            //string sqlStr = string.Format("select * from UNGTUYEN where userid = '{0}'", userid);
            //DataTable dt = dba.ExecuteSelect(sqlStr);
            //if (dt.Rows.Count > 0)
            //    return true;
            //return false;
        }

        public DataTable GetJobData(string seekerid)
        {
            using (var db = new JobAppDFContext())
            {
                var acc = db.UNGTUYEN.Where(s => s.userid == seekerid).ToList();
                if (acc.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("userid", typeof(string));
                    dt.Columns.Add("jobid", typeof(string));
                    dt.Columns.Add("tencv", typeof(string));
                    dt.Columns.Add("thoigian", typeof(string));
                    dt.Columns.Add("congty", typeof(string));
                    dt.Columns.Add("trangthaiphanhoi", typeof(string));
                    dt.Columns.Add("loinhan", typeof(string));
                    foreach (var item in acc)
                    {
                        dt.Rows.Add(item.userid, item.jobid, item.tencv, item.thoigian, item.congty, item.trangthaiphanhoi, item.loinhan);
                    }
                    return dt;
                }
                return null;
            }
        }

        public bool Them(UngTuyen ap)
        {
            using (var db = new JobAppDFContext())
            {
                var ut = new UNGTUYEN
                {
                    userid = ap.Userid,
                    jobid = ap.Jobid,
                    tencv = ap.Tencv,
                    thoigian = ap.Thoigian,
                    congty = ap.Macty,
                    trangthaiphanhoi = ap.TTphanhoi,
                    loinhan = "none",
                };

                db.UNGTUYEN.Add(ut);
                db.SaveChanges();
                return true;
            }
        }

        public bool ChapNhan(UngTuyen ap)
        {
            using (var db = new JobAppDFContext())
            {
                var ut = db.UNGTUYEN.Where(s => s.userid == ap.Userid && s.jobid == ap.Jobid).Single();
                ut.trangthaiphanhoi = "accepted";
                ut.loinhan = ap.Loinhan;
                db.SaveChanges();
                return true;
            }
        }
        public bool TuChoi(UngTuyen ap)
        {
            using (var db = new JobAppDFContext())
            {
                var ut = db.UNGTUYEN.Where(s => s.userid == ap.Userid && s.jobid == ap.Jobid).Single();
                ut.trangthaiphanhoi = "rejected";
                ut.loinhan = ap.Loinhan;
                db.SaveChanges();
                return true;
            }
        }
        public bool Xoa(UngTuyen ap)
        {
            using (var db = new JobAppDFContext())
            {
                var ut = db.UNGTUYEN.Where(s => s.userid == ap.Userid && s.jobid == ap.Jobid).Single();
                db.UNGTUYEN.Remove(ut);
                db.SaveChanges();
                return true;
            }
        }
    }
}
