using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Text.RegularExpressions;

namespace Project_JobApp.Classes
{
    public class Account
    {
        private string _userid;
        private string _matkhau;
        private string _vaitro;

        private readonly Regex usernameRule = new Regex("^[a-zA-Z0-9]+$");

        public Account() { }

        public Account(string userid, string matkhau, string vaitro)
        {
            Userid = userid;
            Matkhau = matkhau;
            Vaitro = vaitro;
        }
        public Account(string userid, string matkhau)
        {
            Userid = userid;
            Matkhau = matkhau;
        }

        public string Userid
        {
            get { return _userid; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || !usernameRule.IsMatch(value))
                    throw new Exception("Username không đúng định dạng! (không chứa kí tự đặt biệt, không chứa khoảng trống, không trống)");
                _userid = value; 
            }
        }
        public string Matkhau
        {
            get { return _matkhau;}
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
                    throw new Exception("Mật khẩu phải tối thiểu 8 kí tự, không chứa khoảng trắng hoặc bỏ trống!");
                _matkhau = value;
            }
        }
        public string Vaitro
        {
            get { return _vaitro;}
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Vui lòng chọn vai trò của bạn!");
                _vaitro = value;
            }
        }
    }
}
