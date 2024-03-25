using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Classes
{
    public class Job
    {
        string jobid;
        string userid;
        string tencv;
        string ngaytao;
        string vitri;
        string mucluong;
        string linhvuc;
        string phucloi;
        string yeucau;
        string trangthai;
        public Job() { }

        public Job(string jobid, string userid, string tencv, string ngaytao, string vitri, string mucluong, string linhvuc, string phucloi, string yeucau, string trangthai)
        {
            Jobid = jobid;
            Userid = userid;
            Tencv = tencv;
            Ngaytao = ngaytao;
            Vitri = vitri;
            Mucluong = mucluong;
            Linhvuc = linhvuc;
            Phucloi = phucloi;
            Yeucau = yeucau;
            this.trangthai = trangthai;
        }

        public string Jobid
        {
            get { return jobid; }
            set { jobid = value; }
        }
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Tencv
        {
            get { return tencv; }
            set { tencv = value; }
        }
        public string Ngaytao
        {
            get { return ngaytao; }
            set { ngaytao = value; }
        }
        public string Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        public string Mucluong
        {
            get { return mucluong; }
            set { mucluong = value; }
        }
        public string Linhvuc
        {
            get { return linhvuc; }
            set { linhvuc = value; }
        }
        public string Phucloi
        {
            get { return phucloi; }
            set { phucloi = value; }
        }
        public string Yeucau
        {
            get { return yeucau; }
            set { yeucau = value; }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
