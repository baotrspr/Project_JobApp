using Project_JobApp.Classes;
using Project_JobApp.Database;
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
        public UCThumbnail()
        {
            InitializeComponent();
        }

        Feeds tfeed;

        public Feeds Tfeed
        {
            get { return tfeed; }
            set { tfeed = value; }
        }
        public string Tieude
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string NgDang
        {
            get { return lblDate_1.Text; }
            set { lblDate_1.Text = value; }
        }
        public string Nguoidang
        {
            get { return lblOwner_1.Text; }
            set { lblOwner_1.Text = value; }
        }
        public string Feedid
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        public void Load(Feeds feed)
        {
            Tfeed = feed;
            Tieude = feed.Tieude;
            NgDang = feed.NgDang;
            Feedid = feed.Feedid;
            Nguoidang = feed.Userid;
        }

        private void UCThumbnail_Click(object sender, EventArgs e)
        {
            UCDetail detail = new UCDetail();
            detail.Load(Tfeed);
            Form detailForm = new Form();
            detailForm.Size = new Size(810, 550);
            detailForm.StartPosition = FormStartPosition.CenterScreen;
            detailForm.Controls.Add(detail);
            detailForm.ShowDialog();
        }
        
    }
}
