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
    public partial class UCDetail : UserControl
    {
        public UCDetail()
        {
            InitializeComponent();
        }
        public UCDetail(Feeds feed)
        {
            InitializeComponent();

            this.feed = feed;
            lblID_1.Text = feed.Feedid;
            lblUser_1.Text = feed.Userid;
            lblGenre_1.Text = feed.Loaibai;
            lblUser_1.Text = feed.Userid;
            lblDate_1.Text = feed.NgDang;
            lblContent_1.Text = feed.Noidung;
            lblJobDetail.Text = feed.Jobdetail;
            lblTitle.Text = feed.Tieude;
        }
        Job job;
        public Job GetJob
        {
            get { return job; }
            set { job = value; }
        }
        Feeds feed;
        public Feeds GetFeed
        {
            get { return feed; }
            set { feed = value; }
        }
        public string Feedid
        {
            get { return lblID_1.Text; }
            set { lblID_1.Text = value; }
        }
        public string Userid
        {
            get { return lblUser_1.Text; }
            set { lblUser_1.Text = value; }
        }
        public string Tieude
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string NgayDang
        {
            get { return lblDate_1.Text; }
            set { lblDate_1.Text = value; }
        }
        public string Noidung
        {
            get { return lblContent_1.Text; }
            set { lblContent_1.Text = value; }
        }
        public string Loaibai
        {
            get { return lblGenre_1.Text; }
            set { lblGenre_1.Text = value;}
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
