using Project_JobApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UC
{
    public partial class UCCreateJob : UserControl
    {
        Account acc;
        CongViec cv;
        public UCCreateJob()
        {
            InitializeComponent();
        }

        public UCCreateJob(Account acc)
        {
            InitializeComponent();
            this.acc = acc;

            txtMacty.Text = this.acc.Userid;
        }
        public UCCreateJob(CongViec cv)
        {
            InitializeComponent();

            this.cv = cv;

            txtMacty.Text = cv.Userid;
            txtDiadiem.Text = cv.Diadiem;
            txtMacv.Text = cv.Jobid;
            txtMucluong.Text = cv.Mucluong;
            txtSoluong.Text = cv.Soluong.ToString();
            txtTieude.Text = cv.Tencv;
            txtVitri.Text = cv.Vitri;
            rtxtMota.Text = cv.Thongtin;
            rtxtPhucloi.Text = cv.Phucloi;
            rtxtYeucau.Text = cv.Yeucau;
            dtpHandk.Text = cv.Handangki;
            dtpNgaytao.Text = cv.Ngaytao;
            cbxLinhvuc.Text = cv.Linhvuc;
            cbxNoilamviec.Text = cv.Noilamviec;
        }

        public string JobID
        {
            get { return txtMacv.Text; }
            set { txtMacv.Text = value;}
        }
        public string Userid
        {
            get { return txtMacty.Text; }
            set { txtMacty.Text = value;}
        }
        public string Tieude
        {
            get { return txtTieude.Text; }
            set { txtTieude.Text = value;}
        }
        public string Ngaytao
        {
            get { return dtpNgaytao.Value.ToString("dd/MM/yyyy"); }
            set { dtpNgaytao.Text = value;}
        }
        public string Handk
        {
            get { return dtpHandk.Value.ToString("dd/MM/yyyy"); }
            set { dtpHandk.Text = value;}
        }
        public string Vitri
        {
            get { return txtVitri.Text; }
            set { txtVitri.Text = value;}
        }
        public string Mucluong
        {
            get { return txtMucluong.Text; }
            set { txtMucluong.Text = value;}
        }
        public string Linhvuc
        {
            get { return cbxLinhvuc.SelectedItem.ToString(); }
            set { cbxLinhvuc.Text = value;}
        }
        public string Phucloi
        {
            get { return rtxtPhucloi.Text; }
            set { rtxtPhucloi.Text = value; }
        }
        public string Yeucau
        {
            get { return rtxtYeucau.Text; }
            set { rtxtYeucau.Text = value;}
        }
        public int Soluong
        {
            get { return int.Parse(txtSoluong.Text); }
            set { txtSoluong.Text = value.ToString(); }
        }
        public string Mota
        {
            get { return rtxtMota.Text; }
            set { rtxtMota.Text = value; }
        }
        public string Noilamviec
        {
            get { return cbxNoilamviec.SelectedItem.ToString(); }
            set { cbxNoilamviec.Text = value; }
        }
        public string Diadiem
        {
            get { return txtDiadiem.Text;}
            set { txtDiadiem.Text = value;}
        }
    }
}
