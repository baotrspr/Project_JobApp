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
                    var jsr = db.JOBSEEKER.Where(s => s.userid == js.Userid).Single();
                    {
                        jsr.ho = js.Ho;
                        jsr.ten = js.Ten;
                        jsr.ngsinh = js.Ngsinh;
                        jsr.cmnd = js.Cmnd;
                        jsr.gioitinh = js.Gioitinh;
                        jsr.diachi = js.Diachi;
                        jsr.sdt = js.Sdt;
                        jsr.email = js.Email;
                        jsr.thongtin = js.Thongtin;
                    }
                    db.SaveChanges();
                }
                return true;
                //string sqlStr = string.Format("insert into JOBSEEKER values (N'{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', '{7}', N'{8}' where userid = '{9}'",
                //                               js.Ho, js.Ten, js.Ngsinh, js.Cmnd, js.Gioitinh, js.Diachi, js.Sdt, js.Email, js.Thongtin, js.Userid);
                //if (dba.Execute(sqlStr))
                //{
                //    return true;
                //}
                //else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Chinhsua(JobSeeker js)
        {
            try
            {
                using (var db = new JobAppDFContext())
                {
                    var jsr = db.JOBSEEKER.Where(s => s.userid == js.Userid).Single();
                    jsr.ho = js.Ho;
                    jsr.ten = js.Ten;
                    jsr.ngsinh = js.Ngsinh;
                    jsr.cmnd = js.Cmnd;
                    jsr.gioitinh = js.Gioitinh;
                    jsr.diachi = js.Diachi;
                    jsr.sdt = js.Sdt;
                    jsr.email = js.Email;
                    jsr.thongtin = js.Thongtin;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                using (var db = new JobAppDFContext())
                {
                    var jsr = db.JOBSEEKER.Where(s => s.userid == userid).Single();
                    db.JOBSEEKER.Remove(jsr);
                    db.SaveChanges(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public JobSeeker GetInfo(string userid)
        {
            JobSeeker js = new JobSeeker();

            using (var db = new JobAppDFContext())
            {
                var jsr = db.JOBSEEKER.Where(s => s.userid == userid).Single();

                js.Userid = jsr.userid;
                js.Ho = jsr.ho;
                js.Ten = jsr.ten;
                js.Ngsinh = jsr.ngsinh;
                js.Cmnd = jsr.cmnd;
                js.Gioitinh = jsr.gioitinh;
                js.Diachi = jsr.diachi;
                js.Sdt = jsr.sdt;
                js.Email = jsr.email;
                js.Thongtin = jsr.thongtin;
            }
            return js;

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
