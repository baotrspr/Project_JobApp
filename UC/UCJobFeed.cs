using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.Database;
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
        public void Load(Account acc)
        {
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
                UCThumbnail thumb = new UCThumbnail();
                thumb.Load(feed);
                flpData.Controls.Add(thumb);
            }
        }
    }
}
