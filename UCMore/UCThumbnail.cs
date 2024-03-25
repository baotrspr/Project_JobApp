using Project_JobApp.Classes;
using Project_JobApp.Database;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_JobApp.UC
{
    public partial class UCThumbnail : UserControl
    {
        Job job;
        Account acc;
        public UCThumbnail()
        {
            InitializeComponent();
        }
        public UCThumbnail(Job job, Account acc)
        {
            InitializeComponent();

            this.job = job;
            this.acc = acc;

            Tieude = job.Tencv;
            Ngaytao = job.Ngaytao;
            Nguoidang = job.Userid;
            if (job.Trangthai == "accepted")
                pbxStatus.Image = Project_JobApp.Properties.Resources.accepted;
            else
                pbxStatus.Image = Project_JobApp.Properties.Resources.hourglass;
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

        private void UCThumbnail_Click(object sender, EventArgs e)
        {
            FormJobDetail detail = new FormJobDetail(job, acc);
            detail.ShowDialog();
        }

    }
}
