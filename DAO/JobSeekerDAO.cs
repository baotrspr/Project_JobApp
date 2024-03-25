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
            string sqlStr = string.Format("insert into JOBSEEKER values (N'{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', '{7}', N'{8}' where userid = '{9}'",
                                           js.Ho, js.Ten, js.Ngsinh, js.Cmnd, js.Gioitinh, js.Diachi, js.Sdt, js.Email, js.Thongtin, js.Userid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public bool Chinhsua(JobSeeker js)
        {
            string sqlStr = string.Format("update JOBSEEKER set ho = N'{0}', ten = N'{1}', ngsinh = '{2}', cmnd = '{3}', gioitinh = N'{4}', diachi = N'{5}', sdt = '{6}', email = '{7}', thongtin = N'{8}' where userid = '{9}'",
                                           js.Ho, js.Ten, js.Ngsinh, js.Cmnd, js.Gioitinh, js.Diachi, js.Sdt, js.Email, js.Thongtin, js.Userid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }
        public void Xoa(string userid)
        {
            string sqlStr = string.Format("delete from JOBSEEKER where userid = '{0}'", userid);
            dba.ExecuteNonquery(sqlStr);
        }

        public JobSeeker GetInfo(string userid)
        {
            JobSeeker js = new JobSeeker();
            string sqlStr = string.Format("select userid, ho, ten, ngsinh, cmnd, gioitinh, diachi, sdt, email, thongtin from JOBSEEKER where userid = '{0}'", userid);
            DataTable dr = dba.SelectRow(sqlStr);
            if (dr != null)
            {
                js.Userid = dr.Rows[0]["userid"].ToString();
                js.Ho = dr.Rows[0]["ho"].ToString();
                js.Ten = dr.Rows[0]["ten"].ToString();
                js.Ngsinh = dr.Rows[0]["ngsinh"].ToString();
                js.Cmnd = dr.Rows[0]["cmnd"].ToString();
                js.Gioitinh = dr.Rows[0]["gioitinh"].ToString();
                js.Diachi = dr.Rows[0]["diachi"].ToString();
                js.Sdt = dr.Rows[0]["sdt"].ToString();
                js.Email = dr.Rows[0]["email"].ToString();
                js.Thongtin = dr.Rows[0]["thongtin"].ToString();
            }
            return js;
        }
    }
}
