using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;

namespace Project_JobApp.Classes
{
    public class Account
    {
        private string _userid;
        private string _matkhau;
        private string _vaitro;
        private string _ho;
        private string _ten;
        private string _ngsinh;
        private string _cmnd;
        private string _gioitinh;
        private string _diachi;
        private string _sdt;
        private string _email;
        private string _thongtin;

        //string[] invalid = "!_@_#_$_%_^_&_*_(_)_<_>_?_+_*_/_-_`_~_ _,_"'_";

        public Account() { }
        public Account(string userid, string matkhau, string vaitro, string ho, string ten, string ngsinh, string cmnd, string gioitinh, string diachi, string sdt, string email, string thongtin)
        {
            Userid = userid;
            Matkhau = matkhau;
            Vaitro = vaitro;
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
        public Account(string userid, string matkhau)
        {
            Userid = userid;
            Matkhau = matkhau;
        }
        public Account(string userid, string matkhau, string vaitro)
        {
            Userid = userid;
            Matkhau = matkhau;
            Vaitro = vaitro;
        }

        public Account(string userid, string ho, string ten, string ngsinh, string cmnd, string gioitinh, string diachi, string sdt, string email, string thongtin)
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
        public string Matkhau
        {
            get { return _matkhau;}
            set { _matkhau = value;}
        }
        public string Vaitro
        {
            get { return _vaitro;}
            set { _vaitro = value;}
        }
        public string Ho
        {
            get { return _ho;}
            set { _ho = value;}
        }
        public string Ten
        {
            get { return _ten;}
            set { _ten = value;}
        }
        public string Ngsinh
        {
            get { return _ngsinh;}
            set { _ngsinh = value;}
        }
        public string Cmnd
        {
            get { return _cmnd;}
            set { _cmnd = value;}
        }
        public string Gioitinh
        {
            get { return _gioitinh;}
            set { _gioitinh = value;}
        }
        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value;}
        }
        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value;}
        }
        public string Email
        {
            get { return _email; }
            set { _email = value;}
        }
        public string Thongtin
        {
            get { return _thongtin;}
            set { _thongtin = value;}
        }
    }
}
