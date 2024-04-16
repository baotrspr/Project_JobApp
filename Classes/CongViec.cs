using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JobApp.Classes
{
    public class CongViec
    {
        string jobid;
        string userid;
        string tencty;
        string tencv;
        string ngaytao;
        string vitri;
        string mucluong;
        string linhvuc;
        string thongtin;
        string phucloi;
        string yeucau;
        int soluong;
        string noilamviec;
        string diadiem;
        string handangki;
        string trangthai;
        int dadangki;

        public CongViec() { }
        public CongViec(string jobid, string userid, string tencty, string tencv, string ngaytao, string vitri, string mucluong, string linhvuc, string thongtin, string phucloi, string yeucau, int soluong, string noilamviec, string diadiem, string handangki)
        {
            Jobid = jobid;
            Userid = userid;
            Tencv = tencv;
            Ngaytao = ngaytao;
            Vitri = vitri;
            Mucluong = mucluong;
            Linhvuc = linhvuc;
            Thongtin = thongtin;
            Phucloi = phucloi;
            Yeucau = yeucau;
            Soluong = soluong;
            Noilamviec = noilamviec;
            Diadiem = diadiem;
            Handangki = handangki;
            Tencty = tencty;
        }
        public CongViec(string jobid, string userid,string tencv, string ngaytao, string vitri, string mucluong, string linhvuc, string thongtin, string phucloi, string yeucau, int soluong, string noilamviec, string diadiem, string handangki)
        {
            Jobid = jobid;
            Userid = userid;
            Tencv = tencv;
            Ngaytao = ngaytao;
            Vitri = vitri;
            Mucluong = mucluong;
            Linhvuc = linhvuc;
            Thongtin = thongtin;
            Phucloi = phucloi;
            Yeucau = yeucau;
            Soluong = soluong;
            Noilamviec = noilamviec;
            Diadiem = diadiem;
            Handangki = handangki;
        }

        public string Jobid
        {
            get { return jobid; }
            set { jobid = value; }
        }
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Tencty
        {
            get { return tencty; }
            set { tencty = value; }
        }
        public string Tencv
        {
            get { return tencv; }
            set { tencv = value; }
        }
        public string Ngaytao
        {
            get { return ngaytao; }
            set { ngaytao = value; }
        }
        public string Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        public string Mucluong
        {
            get { return mucluong; }
            set { mucluong = value; }
        }
        public string Linhvuc
        {
            get { return linhvuc; }
            set { linhvuc = value; }
        }
        public string Thongtin
        {
            get { return thongtin; }
            set { thongtin = value; }
        }
        public string Phucloi
        {
            get { return phucloi; }
            set { phucloi = value; }
        }
        public string Yeucau
        {
            get { return yeucau; }
            set { yeucau = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Noilamviec
        {
            get { return noilamviec; }
            set { noilamviec = value; }
        }
        public string Handangki
        {
            get { return handangki; }
            set { handangki = value; }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public int Dadangki
        {
            get { return dadangki; }
            set { dadangki = value; }
        }
        public string Diadiem
        {
            get { return diadiem; }
            set { diadiem = value; }
        }
    }
}
