using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    internal class LoginDAO
    {
        DBAccess dba = new DBAccess();
        public LoginDAO() { }

        public bool CheckLogin(Account acc)
        {
            string sqlStr = string.Format("select * from TAIKHOAN where userid = '{0}' and matkhau = '{1}' and vaitro = '{2}'", acc.Userid, acc.Matkhau, acc.Vaitro);
            DataTable dt = dba.ExecuteSelect(sqlStr);
            return dt.Rows.Count > 0;
        }
    }
}
