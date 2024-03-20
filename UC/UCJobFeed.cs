using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.Database;
using Project_JobApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UC
{
    public partial class UCJobFeed : UserControl
    {
        BaiDangDAO bd = new BaiDangDAO();
        public UCJobFeed()
        {
            InitializeComponent();
        }
        Account acc;
        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }
        public void Load(Account inacc)
        {
            if (flpData != null)
            {
                foreach (UserControl uc in flpData.Controls)
                {
                    flpData.Controls.Remove(uc);
                }
            }
            GetAccount = inacc;
            DataTable dt = bd.GetData();
            foreach (DataRow dr in dt.Rows)
            {
                Feeds feed = new Feeds();
                feed.Feedid = dr["idbai"].ToString();
                feed.Tieude = dr["tieude"].ToString();
                feed.Noidung = dr["noidung"].ToString();
                feed.Userid = dr["userid"].ToString();
                feed.Loaibai = dr["userid"].ToString();
                feed.NgDang = dr["ngaydang"].ToString();
                feed.Jobdetail = dr["motacv"].ToString();
                UCThumbnail thumb = new UCThumbnail();
                thumb.Load(feed);
                flpData.Controls.Add(thumb);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Feeds newfeed = new Feeds();
            FormCreateFeed create = new FormCreateFeed();
            create.Load(acc);
            create.ShowDialog();
            newfeed = create.GetFeed;
            bd.Them(newfeed);
            Load(acc);
        }
    }
}
