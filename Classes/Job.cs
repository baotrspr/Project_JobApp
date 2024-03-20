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
        string tencv;
        string mucluong;
        string linhvuc;
        string thongtin;
        string trinhdo;
        string userid;
        
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
        public string Thongtin
        {
            get { return thongtin; }
            set { thongtin = value; }
        }
        public string Trinhdo
        {
            get { return trinhdo; }
            set { trinhdo = value; }
        }
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public Job(string jobid, string tencv, string mucluong, string linhvuc, string thongtin, string trinhdo, string userid)
        {
            Jobid = jobid;
            Tencv = tencv;
            Mucluong = mucluong;
            Linhvuc = linhvuc;
            Thongtin = thongtin;
            Trinhdo = trinhdo;
            Userid = userid;
        }

        public override string ToString()
        {
            return $"ID công việc: {Jobid} \n Tên công việc: {Tencv} \n Người tạo: {Userid} \n Mức lương: {Mucluong} \n Trình độ cần: {Trinhdo} \n Thông tin: {Thongtin}";
        }
    }
}
