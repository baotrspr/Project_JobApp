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

        //string[] invalid = "!_@_#_$_%_^_&_*_(_)_<_>_?_+_*_/_-_`_~_ _,_"'_";

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
    }
}
