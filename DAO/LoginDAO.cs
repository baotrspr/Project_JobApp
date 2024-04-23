using Project_JobApp.Classes;
using Project_JobApp.Database;
using Project_JobApp.Forms;
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
            using (var db = new LoginDFContext())
            {
                var account = new ACCOUNT
                {
                    userid = acc.Userid,
                    matkhau = acc.Matkhau,
                    vaitro = acc.Vaitro,
                };
                var query = (from q in db.ACCOUNTs where q.userid == acc.Userid select q).ToList();

                if (query.Count > 0) return true;
                else return false;
            }
            //string sqlStr = string.Format("select * from ACCOUNT where userid = '{0}' and matkhau = '{1}' and vaitro = '{2}'", acc.Userid, acc.Matkhau, acc.Vaitro);
            //DataTable dt = dba.ExecuteSelect(sqlStr);
            //return dt.Rows.Count > 0;
        }
    }
  
}
