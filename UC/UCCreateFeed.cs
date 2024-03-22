using Project_JobApp.Classes;
using Project_JobApp.Forms;
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
    public partial class UCCreateFeed : UserControl
    {
        Account acc;
        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }
        public string Userid
        {
            get { return txtUserid.Text; }
            set { txtUserid.Text = value; }
        }
        public UCCreateFeed()
        {
            InitializeComponent();
        }


        public string Feedid
        {
            get { return txtFeedid.Text; }
            set { txtFeedid.Text = value;}
        }
        public string Tieude
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value;}
        }
        public string Ngdang
        {
            get { return dtpDate.Value.ToString("dd/MM/yyyy"); }
            set { dtpDate.Text = value; }
        }
        public string Loaibai
        {
            get { return txtGenre.Text;}
            set { txtGenre.Text = value;}
        }
        public string Thongtin
        {
            get { return txtInfo.Text; }
            set { txtInfo.Text = value;}
        }
        public string TtJob
        {
            get { return lblJobInfo_1.Text; }
            set { lblJobInfo_1.Text = value;}
        }

        public void Load(Account acc)
        {
            GetAccount = acc;
            txtUserid.Text = acc.Userid;
            if (acc.Vaitro == "JobSeeker")
            {
                txtGenre.Text = "Tìm việc";
                btnAddJob.Enabled = false;
                pnJobInfo.Visible = false;
            }
            else if (acc.Vaitro == "Hirer")
            {
                txtGenre.Text = "Tìm nhân viên";
                btnAddJob.Enabled = true;
                pnJobInfo.Visible = true;
            }
        }

        public Feeds Getfeed()
        {
            return new Feeds(Feedid, Userid, Tieude, Ngdang, Thongtin, Loaibai, TtJob);
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            FormCreateJob newjob = new FormCreateJob();
            newjob.Load(GetAccount);
            newjob.ShowDialog();
            TtJob = newjob.GetJobDetail();
        }

    }
}
