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
            string sqlStr = string.Format("update ACCOUNT set matkhau = '{0}' where userid = '{1}'", acc.Matkhau, acc.Userid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public bool XoaTK(Account acc)
        {
            string sqlStr = string.Format("delete from ACCOUNT where userid = '{0}'", acc.Userid);
            if (dba.Execute(sqlStr))
            {
                if (acc.Vaitro == "JobSeeker")
                {
                    jsDAO.Xoa(acc.Userid);
                }
                else if (acc.Vaitro == "Company")
                {
                    compDAO.Xoa(acc.Userid);
                }
                return true;
            }
            else return false;
        }
    }
}
