using Project_JobApp.Classes;
using Project_JobApp.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
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
            using (var db = new JobAppDFContext())
            {
                var query = from c in db.CONGVIEC
                            join co in db.COMPANY on c.userid equals co.userid
                            select new
                            {
                                c.jobid,
                                c.userid,
                                c.tencv,
                                c.ngaytao,
                                c.vitri,
                                c.mucluong,
                                c.linhvuc,
                                c.thongtin,
                                c.phucloi,
                                c.yeucau,
                                c.soluong,
                                c.noilamviec,
                                c.diadiem,
                                c.handangki,
                                c.trangthai,
                                c.dadangki,
                                co.ten
                            };
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
                dt.Columns.Add("ten", typeof(string));

                foreach (var item in query)
                {
                    dt.Rows.Add(item.jobid, item.userid, item.tencv, item.ngaytao, item.vitri, item.mucluong, item.linhvuc, item.thongtin, item.phucloi,
                            item.yeucau, item.soluong, item.noilamviec, item.diadiem, item.handangki, item.trangthai, item.dadangki, item.ten);
                }
                return dt;
            }
            //string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid");
            //return dba.ExecuteSelect(sqlStr);
        }

        public DataTable GetData(string linhvuc)
        {
            using (var db = new JobAppDFContext())
            {
                var query = from c in db.CONGVIEC
                            join co in db.COMPANY on c.userid equals co.userid
                            where c.linhvuc == linhvuc
                            select new
                            {
                                c.jobid,
                                c.userid,
                                c.tencv,
                                c.ngaytao,
                                c.vitri,
                                c.mucluong,
                                c.linhvuc,
                                c.thongtin,
                                c.phucloi,
                                c.yeucau,
                                c.soluong,
                                c.noilamviec,
                                c.diadiem,
                                c.handangki,
                                c.trangthai,
                                c.dadangki,
                                co.ten
                            };
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
                dt.Columns.Add("ten", typeof(string));

                foreach (var item in query)
                {
                    dt.Rows.Add(item.jobid, item.userid, item.tencv, item.ngaytao, item.vitri, item.mucluong, item.linhvuc, item.thongtin, item.phucloi,
                            item.yeucau, item.soluong, item.noilamviec, item.diadiem, item.handangki, item.trangthai, item.dadangki, item.ten);
                }
                return dt;
            }
            //string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid where linhvuc = N'{0}'", field);
            //return dba.ExecuteSelect(sqlStr);
        }
        public DataTable GetData(int salary)
        {
            using (var db = new JobAppDFContext())
            {
                var query = from c in db.CONGVIEC
                            join co in db.COMPANY on c.userid equals co.userid
                            where c.mucluong.Contains(salary.ToString())
                            select new
                            {
                                c.jobid,
                                c.userid,
                                c.tencv,
                                c.ngaytao,
                                c.vitri,
                                c.mucluong,
                                c.linhvuc,
                                c.thongtin,
                                c.phucloi,
                                c.yeucau,
                                c.soluong,
                                c.noilamviec,
                                c.diadiem,
                                c.handangki,
                                c.trangthai,
                                c.dadangki,
                                co.ten
                            };
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
                dt.Columns.Add("ten", typeof(string));

                foreach (var item in query)
                {
                    dt.Rows.Add(item.jobid, item.userid, item.tencv, item.ngaytao, item.vitri, item.mucluong, item.linhvuc, item.thongtin, item.phucloi,
                            item.yeucau, item.soluong, item.noilamviec, item.diadiem, item.handangki, item.trangthai, item.dadangki, item.ten);
                }
                return dt;
            }
            //string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid where mucluong >= {0}", salary);
            //return dba.ExecuteSelect(sqlStr);
        }

        public bool Them(CongViec j)
        {
            try
            {
                using (var db = new JobAppDFContext())
                {
                    var job = new CONGVIEC
                    {
                        jobid = j.Jobid,
                        userid = j.Userid,
                        tencv = j.Tencv,
                        ngaytao = j.Ngaytao,
                        vitri = j.Vitri,
                        mucluong = j.Mucluong,
                        linhvuc = j.Linhvuc,
                        thongtin = j.Thongtin,
                        phucloi = j.Phucloi,
                        yeucau = j.Yeucau,
                        soluong = j.Soluong,
                        noilamviec = j.Noilamviec,
                        diadiem = j.Diadiem,
                        handangki = j.Handangki,
                        trangthai = "avail",
                        dadangki = 0,
                    };
                    db.CONGVIEC.Add(job);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return false;
            }
        }

        public bool Xoa(CongViec j)
        {
            try
            {
                using (var db = new JobAppDFContext())
                {
                    var job = db.CONGVIEC.Where(s => s.jobid == j.Jobid).Single();
                    db.CONGVIEC.Remove(job);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Sua(CongViec j)
        {
            try
            {
                using (var db = new JobAppDFContext())
                {
                    var job = db.CONGVIEC.Where(s => s.jobid == j.Jobid).Single();
                    job.jobid = j.Jobid;
                    job.userid = j.Userid;
                    job.tencv = j.Tencv;
                    job.ngaytao = j.Ngaytao;
                    job.vitri = j.Vitri;
                    job.mucluong = j.Mucluong;
                    job.linhvuc = j.Linhvuc;
                    job.thongtin = j.Thongtin;
                    job.phucloi = j.Phucloi;
                    job.yeucau = j.Yeucau;
                    job.soluong = j.Soluong;
                    job.noilamviec = j.Noilamviec;
                    job.diadiem = j.Diadiem;
                    job.handangki = j.Handangki;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public CongViec GetThongtin(string jobid)
        {
            using (var db = new JobAppDFContext())
            {
                var cv = db.CONGVIEC
                    .Join(
                        db.COMPANY,
                        c => c.userid,
                        co => co.userid,
                        (c, co) => new
                        {
                            CongViec = c,
                            CompanyTen = co.ten
                        }
                    )
                    .Where(x => x.CongViec.jobid == jobid)
                    .Select(x => new CongViec
                    {
                        Tencv = x.CongViec.tencv,
                        Mucluong = x.CongViec.mucluong,
                        Thongtin = x.CongViec.thongtin,
                        Trangthai = x.CongViec.trangthai,
                        Handangki = x.CongViec.handangki,
                        Jobid = x.CongViec.jobid,
                        Linhvuc = x.CongViec.linhvuc,
                        Diadiem = x.CongViec.diadiem,
                        Vitri = x.CongViec.vitri,
                        Yeucau = x.CongViec.yeucau,
                        Ngaytao = x.CongViec.ngaytao,
                        Noilamviec = x.CongViec.noilamviec,
                        Phucloi = x.CongViec.phucloi,
                        Dadangki = x.CongViec.dadangki.Value,
                        Soluong = x.CongViec.soluong.Value,
                        Userid = x.CongViec.userid
                    })
                    .FirstOrDefault();

                return cv;
            }
            //CongViec cv = new CongViec();
            //string sqlStr = string.Format("select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid where jobid = '{0}'", jobid);
            //DataTable dr = dba.SelectRow(sqlStr);
            //if (dr != null)
            //{
            //    cv.Tencv = dr.Rows[0]["tencv"].ToString();
            //    cv.Mucluong = dr.Rows[0]["mucluong"].ToString();
            //    cv.Thongtin = dr.Rows[0]["thongtin"].ToString();
            //    cv.Trangthai = dr.Rows[0]["trangthai"].ToString();
            //    cv.Handangki = dr.Rows[0]["handangki"].ToString();
            //    cv.Jobid = jobid;
            //    cv.Linhvuc = dr.Rows[0]["linhvuc"].ToString();
            //    cv.Diadiem = dr.Rows[0]["diadiem"].ToString();
            //    cv.Vitri = dr.Rows[0]["vitri"].ToString();
            //    cv.Yeucau = dr.Rows[0]["yeucau"].ToString();
            //    cv.Ngaytao = dr.Rows[0]["ngaytao"].ToString();
            //    cv.Noilamviec = dr.Rows[0]["noilamviec"].ToString();
            //    cv.Phucloi = dr.Rows[0]["phucloi"].ToString();
            //    cv.Dadangki = int.Parse(dr.Rows[0]["dadangki"].ToString());
            //    cv.Soluong = int.Parse(dr.Rows[0]["soluong"].ToString());
            //    cv.Userid = dr.Rows[0]["userid"].ToString();
            //}
            //return cv;
        }

        public DataTable GetApplicants(string jobid)
        {
            using (var db = new JobAppDFContext())
            {
                var query = db.UNGTUYEN.Where(s => s.jobid == jobid).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("userid", typeof(string));
                dt.Columns.Add("jobid", typeof(string));
                dt.Columns.Add("tencv", typeof(string));
                dt.Columns.Add("thoigian", typeof(string));
                dt.Columns.Add("congty", typeof(string));
                dt.Columns.Add("trangthaiphanhoi", typeof(string));
                dt.Columns.Add("loinhan", typeof(string));

                foreach (var item in query)
                {
                    dt.Rows.Add(item.userid, item.jobid, item.tencv, item.thoigian, item.congty, item.trangthaiphanhoi, item.loinhan);
                }
                return dt;
            }
            //string sqlstr = string.Format("select * from UNGTUYEN where jobid = '{0}'", jobid);
            //return dba.ExecuteSelect(sqlstr);
        }
    }
}
