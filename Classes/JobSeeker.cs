﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_JobApp.Classes
{
    public class JobSeeker
    {
        private string _userid;
        private string _ho;
        private string _ten;
        private string _ngsinh;
        private string _cmnd;
        private string _gioitinh;
        private string _diachi;
        private string _sdt;
        private string _email;
        private string _thongtin;

        public JobSeeker() { }
        public JobSeeker(string userid, string ho, string ten, string ngsinh, string cmnd, string gioitinh, string diachi, string sdt, string email, string thongtin)
        {
            Userid = userid;
            Ho = ho;
            Ten = ten;
            Ngsinh = ngsinh;
            Cmnd = cmnd;
            Gioitinh = gioitinh;
            Diachi = diachi;
            Sdt = sdt;
            Email = email;
            Thongtin = thongtin;
        }
        public string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
        public string Ho
        {
            get { return _ho; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                _ho = value; 
            }
        }
        public string Ten
        {
            get { return _ten; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                _ten = value; 
            }
        }
        public string Ngsinh
        {
            get { return _ngsinh; }
            set { _ngsinh = value; }
        }
        public string Cmnd
        {
            get { return _cmnd; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                _cmnd = value; 
            }
        }
        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string Diachi
        {
            get { return _diachi; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                _diachi = value; 
            }
        }
        public string Sdt
        {
            get { return _sdt; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                if (value.Length != 10)
                    throw new Exception("Không đúng định dạng!");
                _sdt = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                if (!value.Contains("@"))
                    throw new Exception("Không đúng định dạng!");
                _email = value;
            }
        }
        public string Thongtin
        {
            get { return _thongtin; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Không được bỏ trống trường này!");
                _thongtin = value; 
            }
        }
    }
}
