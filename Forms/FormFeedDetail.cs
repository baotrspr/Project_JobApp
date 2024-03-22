using Project_JobApp.Classes;
using Project_JobApp.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormFeedDetail : Form
    {
        public FormFeedDetail()
        {
            InitializeComponent();
        }
        Feeds feed;
        public FormFeedDetail(Feeds feed)
        {
            InitializeComponent();

            this.feed = feed;

            MessageBox.Show(feed.Tieude + this.feed.Feedid);


        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFeedDetail_Load(object sender, EventArgs e)
        {
            UCDetail ucDetail = new UCDetail(feed);
            pnTab.Controls.Add(ucDetail);
        }
    }
}
