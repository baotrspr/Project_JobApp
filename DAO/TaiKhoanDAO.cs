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
    public class TaiKhoanDAO
    {
        DBAccess dba = new DBAccess();
        public bool Chinhsua(Account acc)
        {
            string sqlStr = string.Format("update TAIKHOAN set ho = N'{0}', ten = N'{1}', ngsinh = '{2}', cmnd = '{3}', gioitinh = N'{4}', diachi = N'{5}', sdt = '{6}', email = '{7}', thongtin = N'{8}' where userid = '{9}'",
                                            acc.Ho, acc.Ten, acc.Ngsinh, acc.Cmnd, acc.Gioitinh, acc.Diachi, acc.Sdt, acc.Email, acc.Thongtin, acc.Userid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }
        public void GetInfo(ref Account acc)
        {
            string sqlStr = string.Format("select ho, ten, ngsinh, cmnd, gioitinh, diachi, sdt, email, thongtin from TAIKHOAN where userid = '{0}'", acc.Userid);
            MessageBox.Show(sqlStr);
            DataTable dr = dba.SelectRow(sqlStr);
            if (dr != null)
            {
                acc.Ho = dr.Rows[0]["ho"].ToString();
                acc.Ten = dr.Rows[0]["ten"].ToString();
                acc.Ngsinh = dr.Rows[0]["ngsinh"].ToString();
                acc.Cmnd =  dr.Rows[0]["cmnd"].ToString();
                acc.Gioitinh = dr.Rows[0]["gioitinh"].ToString();
                acc.Diachi = dr.Rows[0]["diachi"].ToString();
                acc.Sdt = dr.Rows[0]["sdt"].ToString();
                acc.Email = dr.Rows[0]["email"].ToString();
                acc.Thongtin = dr.Rows[0]["thongtin"].ToString();
            }
        }
    }
}
