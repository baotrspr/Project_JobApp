﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Classes
{
    public class UngTuyen
    {
        string userid;
        string jobid;
        string tencv;
        string thoigian;
        string macty;
        string ttphanhoi;
        string loinhan;

        public UngTuyen() { }

        public UngTuyen(string userid, string jobid, string tencv, string thoigian, string macty, string ttphanhoi, string loinhan)
        {
            this.userid = userid;
            this.jobid = jobid;
            this.tencv = tencv;
            this.thoigian = thoigian;
            this.macty = macty;
            this.ttphanhoi = ttphanhoi;
            this.loinhan = loinhan;
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
        public string Loinhan
        {
            get { return loinhan; }
            set { loinhan = value; }
        }
    }
}
