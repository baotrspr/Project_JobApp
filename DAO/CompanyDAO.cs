using Project_JobApp.Classes;
using Project_JobApp.Database;
using Project_JobApp.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    internal class CompanyDAO
    {
        DBAccess dba = new DBAccess();

        public Company GetInfo(string userid)
        {
            Company cp = new Company();
            string sqlStr = string.Format("select * from COMPANY where userid = '{0}'", userid);
            DataTable dr = dba.SelectRow(sqlStr);
            if (dr != null)
            {
                cp.Userid = dr.Rows[0]["userid"].ToString();
                cp.Ten = dr.Rows[0]["ten"].ToString();
                cp.Ngaythanhlap = dr.Rows[0]["ngaythanhlap"].ToString();
                cp.Ngdungdau = dr.Rows[0]["ngdungdau"].ToString();
                cp.Diachi = dr.Rows[0]["diachi"].ToString();
                cp.Email = dr.Rows[0]["email"].ToString();
                cp.Thongtin = dr.Rows[0]["thongtin"].ToString();
                cp.Linhvuc = dr.Rows[0]["linhvuc"].ToString();
                cp.Masothue = dr.Rows[0]["masothue"].ToString();
                cp.Giayphep = dr.Rows[0]["giayphep"].ToString();
                cp.Sdt = dr.Rows[0]["sdt"].ToString();
            }
            return cp;
        }
        public void Xoa(string userid)
        {
            string sqlStr = string.Format("delete from COMPANY where userid = '{0}'", userid);
            dba.ExecuteNonquery(sqlStr);
        }
        public bool Chinhsua(Company cp)
        {
            string sqlStr = string.Format("update COMPANY set ten = N'{0}', ngaythanhlap = N'{1}', giayphep = '{2}', ngdungdau = '{3}', diachi = N'{4}', sdt = '{5}', masothue = N'{6}', linhvuc = N'{7}', email = '{8}', thongtin = N'{9}' where userid = '{10}'",
                                           cp.Ten, cp.Ngaythanhlap, cp.Giayphep, cp.Ngdungdau, cp.Diachi, cp.Sdt, cp.Masothue, cp.Linhvuc, cp.Email, cp.Thongtin, cp.Userid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public DataTable GetJobList(Account acc)
        {
            string sqlStr = string.Format("select * from CONGVIEC where userid = '{0}'", acc.Userid);
            return dba.ExecuteSelect(sqlStr);
        }
    }
}
