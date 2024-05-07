using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.DAO
{
    public class TaiKhoanDAO
    {
        DBAccess dba = new DBAccess();
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        CompanyDAO compDAO = new CompanyDAO();
        public TaiKhoanDAO() { }
        public bool DoiMK(Account acc)
        {
            using (var db = new JobAppDFContext())
            {
                var account = db.ACCOUNT.Where(s => s.userid == acc.Userid).Single();
                if (account != null)
                {
                    account.matkhau = acc.Matkhau;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool XoaTK(Account acc)
        {
            using (var db = new JobAppDFContext())
            {
                var account = db.ACCOUNT.Where(s => s.userid == acc.Userid).Single();
                if (account != null)
                {
                    db.ACCOUNT.Remove(account);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
