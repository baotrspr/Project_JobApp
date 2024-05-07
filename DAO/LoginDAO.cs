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
            using (var db = new JobAppDFContext())
            {
                var account = new ACCOUNT
                {
                    userid = acc.Userid,
                    matkhau = acc.Matkhau,
                    vaitro = acc.Vaitro,
                };
                var query = db.ACCOUNT.Where(q => q.userid == acc.Userid && q.vaitro == acc.Vaitro).Single();

                if (query != null) return true;
                else return false;
            }
        }
    }
}
