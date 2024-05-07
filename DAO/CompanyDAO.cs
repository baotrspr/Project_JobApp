using Project_JobApp.Classes;
using Project_JobApp.Database;
using Project_JobApp.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

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
                var company = db.COMPANY.Where(s => s.userid == userid).Single();
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
        }
        public void Xoa(string userid)
        {
            using (var db = new JobAppDFContext())
            {
                var company = db.COMPANY.Where(s => s.userid == userid).Single();
                if (company != null)
                {
                    db.COMPANY.Remove(company);
                    db.SaveChanges();
                }
            }
        }
        public bool Chinhsua(Company cp)
        {
            using (var db = new JobAppDFContext())
            {
                var company = db.COMPANY.Where(s => s.userid == cp.Userid).Single();
                if (company != null)
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
        }

        public DataTable GetJobList(Account acc)
        {
            using (var db = new JobAppDFContext())
            {
                var data = db.CONGVIEC.Where(s => s.userid == acc.Userid).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("jobid", typeof(string));
                dt.Columns.Add("userid", typeof(string));
                dt.Columns.Add("tencv", typeof(string));
                dt.Columns.Add("ngaytao", typeof(string));
                dt.Columns.Add("vitri", typeof(string));
                dt.Columns.Add("mucluong", typeof(string));
                dt.Columns.Add("linhvuc", typeof(string));
                dt.Columns.Add("thongtin", typeof(string));
                dt.Columns.Add("phucloi", typeof(string));
                dt.Columns.Add("yeucau", typeof(string));
                dt.Columns.Add("soluong", typeof(int));
                dt.Columns.Add("noilamviec", typeof(string));
                dt.Columns.Add("diadiem", typeof(string));
                dt.Columns.Add("handangki", typeof(string));
                dt.Columns.Add("trangthai", typeof(string));
                dt.Columns.Add("dadangki", typeof(int));

                foreach (var item in data)
                {
                    dt.Rows.Add(item.jobid, item.userid, item.tencv, item.ngaytao, item.vitri, item.mucluong, item.linhvuc, item.thongtin, item.phucloi,
                            item.yeucau, item.soluong, item.noilamviec, item.diadiem, item.handangki, item.trangthai, item.dadangki);
                }
                return dt;
            }

        }
    }
}
