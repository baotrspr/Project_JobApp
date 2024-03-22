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
        public UCThumbnail()
        {
            InitializeComponent();
        }
        public UCThumbnail(Feeds feed)
        {
            InitializeComponent();

            Tfeed = feed;
            Tieude = feed.Tieude;
            NgDang = feed.NgDang;
            Feedid = feed.Feedid;
            Nguoidang = feed.Userid;
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

        private void UCThumbnail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Tfeed.Feedid + Tfeed.Tieude);
            FormFeedDetail detail = new FormFeedDetail(Tfeed);
            detail.ShowDialog();
        }
        
    }
}
