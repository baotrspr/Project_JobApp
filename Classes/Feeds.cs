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
        string userid;
        string title;
        string date;
        string content;
        Image photo;
        string salary;
        string field;
        int like;

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
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Field
        {
            get { return field; }
            set {  field = value; }
        }
        public int Like
        {
            get { return like; }
            set { like = value; }
        }
        public string Content
        {
            get { return content; }
            set {  content = value; }
        }
        public Feeds(string feedid, string userid, string title, string date, Image photo, string content, string salary, string field, int like)
        {
            Feedid = feedid;
            Userid = userid;
            Title = title;
            Date = date;
            Content = content;
            Photo = photo;
            Salary = salary;
            Field = field;
            Like = like;
        }
    }
}
