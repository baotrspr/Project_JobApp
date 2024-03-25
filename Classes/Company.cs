using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Classes
{
    public class Company
    {
        string userid;
        string ten;
        string ngaythanhlap;
        string giayphep;
        string ngdungdau;
        string diachi;
        string sdt;
        string masothue;
        string linhvuc;
        string email;
        string thongtin;

        public Company() { }
        public Company(string userid, string ten, string ngaythanhlap, string giayphep, string ngdungdau, string diachi, string sdt, string masothue, string linhvuc, string email, string thongtin)
        {
            Userid = userid;
            Ten = ten;
            Ngaythanhlap = ngaythanhlap;
            Giayphep = giayphep;
            Ngdungdau = ngdungdau;
            Diachi = diachi;
            Sdt = sdt;
            Masothue = masothue;
            Linhvuc = linhvuc;
            Email = email;
            Thongtin = thongtin;
        }
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public string Ngaythanhlap
        {
            get { return ngaythanhlap; }
            set { ngaythanhlap = value;}
        }
        public string Giayphep
        {
            get { return giayphep; }
            set { giayphep = value;}
        }
        public string Ngdungdau
        {
            get { return ngdungdau;}
            set { ngdungdau = value;}
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value;}
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value;}
        }
        public string Masothue
        {
            get { return masothue; }
            set { masothue = value;}
        }
        public string Linhvuc
        {
            get { return linhvuc; }
            set { linhvuc = value;}
        }
        public string Email
        {
            get { return email; }
            set { email = value;}
        }
        public string Thongtin
        {
            get { return thongtin; }
            set { thongtin = value;}
        }
    }
}
