using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Classes
{
    public class Feeds
    {
        string feedid;
        string genre;
        string userid;
        string title;
        string date;
        string content;
        string jobdetail;

        public Feeds() { }
        public string Feedid
        {
            get { return feedid; }
            set { feedid = value; }
        }
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Tieude
        {
            get { return title; }
            set { title = value; }
        }

        public string NgDang
        {
            get { return date; }
            set { date = value; }
        }
        public string Loaibai
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Noidung
        {
            get { return content; }
            set {  content = value; }
        }
        public string Jobdetail
        {
            get { return jobdetail; }
            set 
            {
                if (value != null)
                    jobdetail = value;
                else
                    jobdetail = "none";
            }
        }
        public Feeds(string feedid, string userid, string title, string date, string content, string genre, string jobdetail)
        {
            Feedid = feedid;
            Userid = userid;
            Tieude = title;
            NgDang = date;
            Noidung = content;
            Loaibai = genre;
            Jobdetail = jobdetail;
        }
    }
}
