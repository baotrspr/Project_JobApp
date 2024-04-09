using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private readonly Regex passRule = new Regex(@"^\d{10}$");

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
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                ten = value; 
            }
        }
        public string Ngaythanhlap
        {
            get { return ngaythanhlap; }
            set { ngaythanhlap = value;}
        }
        public string Giayphep
        {
            get { return giayphep; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                giayphep = value;
            }
        }
        public string Ngdungdau
        {
            get { return ngdungdau;}
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                ngdungdau = value;
            }
        }
        public string Diachi
        {
            get { return diachi; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                diachi = value;
            }
        }
        public string Sdt
        {
            get { return sdt; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                //if (value.Length != 10)
                //    throw new Exception("Không đúng định dạng!");
                sdt = value;
            }
        }
        public string Masothue
        {
            get { return masothue; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                masothue = value;
            }
        }
        public string Linhvuc
        {
            get { return linhvuc; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                linhvuc = value;
            }
        }
        public string Email
        {
            get { return email; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                //if (!value.Contains("@"))
                //    throw new Exception("Không đúng định dạng!");
                email = value;
            }
        }
        public string Thongtin
        {
            get { return thongtin; }
            set 
            {
                //if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Không được bỏ trống trường này!");
                thongtin = value;
            }
        }
    }
}
