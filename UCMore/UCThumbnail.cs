using Project_JobApp.Classes;
using Project_JobApp.Database;
using Project_JobApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_JobApp.UC
{
    public partial class UCThumbnail : UserControl
    {
        CongViec job;
        Account acc;
        public UCThumbnail()
        {
            InitializeComponent();
        }
        public UCThumbnail(CongViec job, Account acc)
        {
            InitializeComponent();

            this.job = job;
            this.acc = acc;

            Tieude = job.Tencv;
            Nguoidang = job.Tencty;
            Diadiem = job.Diadiem;
            Mucluong = job.Mucluong;
            Noilamviec = job.Noilamviec;

            DateTime han = DateTime.ParseExact(job.Ngaytao, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            DateTime day = DateTime.Now;
            int songay = (int)(day - han).TotalDays;

            if (songay > 0)
                Ngaytao = songay.ToString() + " ngày trước";

            han = DateTime.ParseExact(job.Handangki, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            songay = (int)(han - day).TotalDays;
            if (songay > 0)
                Thoihan = job.Handangki + " ( Còn " + songay.ToString() + " ngày)";
            else
            {
                Thoihan = "Đã hết hạn đăng kí!";
            }
            //Thoihan = job.Handangki;
        }


        public string Tieude
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string Ngaytao
        {
            get { return lblDate_1.Text; }
            set { lblDate_1.Text = value; }
        }
        public string Nguoidang
        {
            get { return lblOwner_1.Text; }
            set { lblOwner_1.Text = value; }
        }
        public string Diadiem 
        { 
            get { return lblDiadiem.Text; }
            set { lblDiadiem.Text = value; }
        }
        public string Mucluong
        {
            get { return lblMucluong.Text; }
            set { lblMucluong.Text = value; }
        }
        public string Noilamviec
        {
            get { return lblNoilamviec.Text; }
            set { lblNoilamviec.Text = value; }
        }
        public string Thoihan
        {
            get { return lblThoihan.Text; }
            set { lblThoihan.Text = value; }
        }
        private void UCThumbnail_Click(object sender, EventArgs e)
        {
            FormJobDetail detail = new FormJobDetail(job, acc);
            detail.ShowDialog();
        }

        private void UCThumbnail_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.GhostWhite;
        }

        private void UCThumbnail_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
