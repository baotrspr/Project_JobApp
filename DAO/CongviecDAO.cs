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
    public class CongviecDAO
    {
        DBAccess dba = new DBAccess();
        public CongviecDAO() { }

        public DataTable GetData()
        {
            string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid");
            return dba.ExecuteSelect(sqlStr);
        }

        public DataTable GetData(string field)
        {
            string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid where linhvuc = N'{0}'", field);
            return dba.ExecuteSelect(sqlStr);
        }
        public DataTable GetData(int salary)
        {
            string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid where mucluong >= {0}", salary);
            return dba.ExecuteSelect(sqlStr);
        }

        public bool Them(CongViec j)
        {
            string sqlStr = string.Format("insert into CONGVIEC(jobid, userid, tencv, ngaytao, vitri, mucluong, linhvuc, thongtin, phucloi, yeucau, soluong, noilamviec, diadiem, handangki) " +
                                            "values ('{0}','{1}',N'{2}',N'{3}','{4}','{5}',N'{6}', N'{7}',N'{8}', N'{9}', '{10}', N'{11}', N'{12}', N'{13}')",
                                            j.Jobid, j.Userid, j.Tencv, j.Ngaytao, j.Vitri, j.Mucluong, j.Linhvuc, j.Thongtin, j.Phucloi, j.Yeucau, j.Soluong, j.Noilamviec, j.Diadiem, j.Handangki);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public bool Xoa(CongViec j)
        {
            string sqlStr = string.Format("delete from CONGVIEC where jobid = '{0}'", j.Jobid);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public bool Sua(CongViec j)
        {
            string sqlStr = string.Format("update CONGVIEC set jobid = '{0}', userid = '{1}', tencv = N'{2}', ngaytao = '{3}', vitri = N'{4}', mucluong = N'{5}', linhvuc = N'{6}', thongtin = N'{7}', phucloi = N'{8}', yeucau = N'{9}', soluong = N'{10}', noilamviec = N'{11}', diadiem = N'{12}', handangki = N'{13}'",
                                            j.Jobid, j.Userid, j.Tencv, j.Ngaytao, j.Vitri, j.Mucluong, j.Linhvuc, j.Thongtin, j.Phucloi, j.Yeucau, j.Soluong, j.Noilamviec, j.Diadiem, j.Handangki);
            if (dba.Execute(sqlStr))
            {
                return true;
            }
            else return false;
        }

        public CongViec GetThongtin(string jobid)
        {
            CongViec cv = new CongViec();
            string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid where jobid = '{0}'", jobid);
            DataTable dr = dba.SelectRow(sqlStr);
            if (dr != null)
            {
                cv.Tencv = dr.Rows[0]["tencv"].ToString();
                cv.Mucluong = dr.Rows[0]["mucluong"].ToString();
                cv.Thongtin = dr.Rows[0]["thongtin"].ToString();
                cv.Trangthai = dr.Rows[0]["trangthai"].ToString();
                cv.Handangki = dr.Rows[0]["handangki"].ToString();
                cv.Jobid = jobid;
                cv.Linhvuc = dr.Rows[0]["linhvuc"].ToString();
                cv.Diadiem = dr.Rows[0]["diadiem"].ToString();
                cv.Vitri = dr.Rows[0]["vitri"].ToString();
                cv.Yeucau = dr.Rows[0]["yeucau"].ToString();
                cv.Ngaytao = dr.Rows[0]["ngaytao"].ToString();
                cv.Noilamviec = dr.Rows[0]["noilamviec"].ToString();
                cv.Phucloi = dr.Rows[0]["phucloi"].ToString();
                cv.Dadangki = int.Parse(dr.Rows[0]["dadangki"].ToString());
                cv.Soluong = int.Parse(dr.Rows[0]["soluong"].ToString());
                cv.Userid = dr.Rows[0]["userid"].ToString();
            }
            return cv;
        }
    }
}
