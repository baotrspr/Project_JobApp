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
            using (var db = new JobAppDFContext())
            {
                var company = db.COMPANies.Where(s => s.userid == userid).Single();
                if (company != null)
                {
                    cp.Userid = company.userid;
                    cp.Ten = company.ten;
                    cp.Ngaythanhlap = company.ngaythanhlap;
                    cp.Ngdungdau = company.ngdungdau;
                    cp.Diachi = company.diachi;
                    cp.Email = company.email;
                    cp.Thongtin = company.thongtin;
                    cp.Linhvuc = company.linhvuc;
                    cp.Masothue = company.masothue;
                    cp.Website = company.website;
                    cp.Sdt = company.sdt;
                }
                return cp;
            }
            //Company cp = new Company();
            //string sqlStr = string.Format("select * from COMPANY where userid = '{0}'", userid);
            //DataTable dr = dba.SelectRow(sqlStr);
            //if (dr != null)
            //{
            //    cp.Userid = dr.Rows[0]["userid"].ToString();
            //    cp.Ten = dr.Rows[0]["ten"].ToString();
            //    cp.Ngaythanhlap = dr.Rows[0]["ngaythanhlap"].ToString();
            //    cp.Ngdungdau = dr.Rows[0]["ngdungdau"].ToString();
            //    cp.Diachi = dr.Rows[0]["diachi"].ToString();
            //    cp.Email = dr.Rows[0]["email"].ToString();
            //    cp.Thongtin = dr.Rows[0]["thongtin"].ToString();
            //    cp.Linhvuc = dr.Rows[0]["linhvuc"].ToString();
            //    cp.Masothue = dr.Rows[0]["masothue"].ToString();
            //    cp.Website = dr.Rows[0]["website"].ToString();
            //    cp.Sdt = dr.Rows[0]["sdt"].ToString();
            //}
            //return cp;
        }
        public void Xoa(string userid)
        {
            using (var db = new JobAppDFContext())
            {
                var company = db.COMPANies.Where(s => s.userid == userid).Single();
                if ( company != null )
                {
                    db.COMPANies.Remove(company);
                    db.SaveChanges();
                }
            }
            //string sqlStr = string.Format("delete from COMPANY where userid = '{0}'", userid);
            //dba.ExecuteNonquery(sqlStr);
        }
        public bool Chinhsua(Company cp)
        {
            using (var db = new JobAppDFContext())
            {
                var company = db.COMPANies.Where(s => s.userid == cp.Userid).Single();
                if (company != null ) 
                {
                    company.ten = cp.Ten;
                    company.ngaythanhlap = cp.Ngaythanhlap;
                    company.website = cp.Website;
                    company.ngdungdau = cp.Ngdungdau;
                    company.diachi = cp.Diachi;
                    company.sdt = cp.Sdt;
                    company.masothue = cp.Masothue;
                    company.linhvuc = cp.Linhvuc;
                    company.email = cp.Email;
                    company.thongtin = cp.Thongtin;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
                //string sqlStr = string.Format("update COMPANY set ten = N'{0}', ngaythanhlap = N'{1}', website = '{2}', ngdungdau = N'{3}', diachi = N'{4}', sdt = '{5}', masothue = N'{6}', linhvuc = N'{7}', email = '{8}', thongtin = N'{9}' where userid = '{10}'",
                //                               cp.Ten, cp.Ngaythanhlap, cp.Website, cp.Ngdungdau, cp.Diachi, cp.Sdt, cp.Masothue, cp.Linhvuc, cp.Email, cp.Thongtin, cp.Userid);
                //if (dba.Execute(sqlStr))
                //{
                //    return true;
                //}
                //else return false;
            }

        public DataTable GetJobList(Account acc)
        {
            string sqlStr = string.Format("select * from CONGVIEC where userid = '{0}'", acc.Userid);
            return dba.ExecuteSelect(sqlStr);
        }
    }
}
