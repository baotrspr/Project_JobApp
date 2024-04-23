using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.DAO
{
    public class JobSeekerDAO
    {
        DBAccess dba = new DBAccess();
        public bool Them(JobSeeker js)
        {
            try
            {
                using (var db = new JobAppDFContext())
                {
                    var jobseeker = new JOBSEEKER
                    {
                        userid = js.Userid,
                        ho = js.Ho,
                        ten = js.Ten,
                        ngsinh = js.Ngsinh,
                        cmnd = js.Cmnd,
                        gioitinh = js.Gioitinh,
                        diachi = js.Diachi,
                        sdt = js.Sdt,
                        email = js.Email,
                        thongtin = js.Thongtin,
                    };
                    db.JOBSEEKERs.Add(jobseeker);
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //string sqlStr = string.Format("insert into JOBSEEKER values (N'{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', '{7}', N'{8}' where userid = '{9}'",
            //                               js.Ho, js.Ten, js.Ngsinh, js.Cmnd, js.Gioitinh, js.Diachi, js.Sdt, js.Email, js.Thongtin, js.Userid);
            //if (dba.Execute(sqlStr))
            //{
            //    return true;
            //}
            //else return false;
        }

        public bool Chinhsua(JobSeeker js)
        {
            using (var db = new JobAppDFContext())
            {
                var jobseeker = db.JOBSEEKERs.Where(s => s.userid == js.Userid).Single();
                if (jobseeker != null)
                {
                    jobseeker.ho = js.Ho;
                    jobseeker.ten = js.Ten;
                    jobseeker.ngsinh = js.Ngsinh;
                    jobseeker.cmnd = js.Cmnd;
                    jobseeker.gioitinh = js.Gioitinh;
                    jobseeker.diachi = js.Diachi;
                    jobseeker.sdt = js.Sdt;
                    jobseeker.email = js.Email;
                    jobseeker.thongtin = js.Thongtin;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            //string sqlStr = string.Format("update JOBSEEKER set ho = N'{0}', ten = N'{1}', ngsinh = '{2}', cmnd = '{3}', gioitinh = N'{4}', diachi = N'{5}', sdt = '{6}', email = '{7}', thongtin = N'{8}' where userid = '{9}'",
            //                               js.Ho, js.Ten, js.Ngsinh, js.Cmnd, js.Gioitinh, js.Diachi, js.Sdt, js.Email, js.Thongtin, js.Userid);
            //if (dba.Execute(sqlStr))
            //{
            //    return true;
            //}
            //else return false;
        }
        public void Xoa(string userid)
        {
            using (var db = new JobAppDFContext())
            {
                var jobseeker = db.JOBSEEKERs.Where(s => s.userid == userid).Single();
                if (jobseeker != null)
                {
                    db.JOBSEEKERs.Remove(jobseeker);
                    db.SaveChanges();
                }
            }
            //string sqlStr = string.Format("delete from JOBSEEKER where userid = '{0}'", userid);
            //dba.ExecuteNonquery(sqlStr);
        }

        public JobSeeker GetInfo(string userid)
        {
            JobSeeker js = new JobSeeker();
            using (var db = new JobAppDFContext())
            {
                var jobseeker = db.JOBSEEKERs.Where(s => s.userid == userid).Single();
                if (jobseeker != null)
                {
                    js.Userid = jobseeker.userid;
                    js.Ho = jobseeker.ho;
                    js.Ten = jobseeker.ten;
                    js.Ngsinh = jobseeker.ngsinh;
                    js.Cmnd = jobseeker.cmnd;
                    js.Gioitinh = jobseeker.gioitinh;
                    js.Diachi = jobseeker.diachi;
                    js.Sdt = jobseeker.sdt;
                    js.Email = jobseeker.email;
                    js.Thongtin = jobseeker.thongtin;
                }
                return js;
            }
            //JobSeeker js = new JobSeeker();
            //string sqlStr = string.Format("select userid, ho, ten, ngsinh, cmnd, gioitinh, diachi, sdt, email, thongtin from JOBSEEKER where userid = '{0}'", userid);
            //DataTable dr = dba.SelectRow(sqlStr);
            //if (dr != null)
            //{
            //    js.Userid = dr.Rows[0]["userid"].ToString();
            //    js.Ho = dr.Rows[0]["ho"].ToString();
            //    js.Ten = dr.Rows[0]["ten"].ToString();
            //    js.Ngsinh = dr.Rows[0]["ngsinh"].ToString();
            //    js.Cmnd = dr.Rows[0]["cmnd"].ToString();
            //    js.Gioitinh = dr.Rows[0]["gioitinh"].ToString();
            //    js.Diachi = dr.Rows[0]["diachi"].ToString();
            //    js.Sdt = dr.Rows[0]["sdt"].ToString();
            //    js.Email = dr.Rows[0]["email"].ToString();
            //    js.Thongtin = dr.Rows[0]["thongtin"].ToString();
            //}
            //return js;
        }
    }
}
