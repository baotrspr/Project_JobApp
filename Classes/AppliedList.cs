using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Classes
{
    public class AppliedList
    {
        string userid;
        string jobid;
        string tencv;
        string thoigian;
        string macty;
        string ttphanhoi;

        public AppliedList() { }

        public AppliedList(string userid, string jobid, string tencv, string thoigian, string macty, string ttphanhoi)
        {
            this.userid = userid;
            this.jobid = jobid;
            this.tencv = tencv;
            this.thoigian = thoigian;
            this.macty = macty;
            this.ttphanhoi = ttphanhoi;
        }
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Jobid
        {
            get { return jobid; }
            set { jobid = value; }
        }
        public string Tencv
        {
            get { return tencv; }
            set { tencv = value; }
        }
        public string Thoigian
        { 
            get { return thoigian; } 
            set { thoigian = value; }
        }
        public string Macty
        {
            get { return macty; }
            set { macty = value; }
        }
        public string TTphanhoi
        {
            get { return ttphanhoi; }
            set { ttphanhoi = value; }
        }
    }
}
