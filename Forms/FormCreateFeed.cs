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

namespace Project_JobApp.Forms
{
    public partial class FormCreateFeed : Form
    {
        Account acc;
        Feeds feed;

        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }
        public Feeds GetFeed
        {
            get { return feed; }
            set { feed = value; }
        }

        public FormCreateFeed()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Load(Account acc)
        {
            GetAccount = acc;
            ucCreateFeed.Load(acc);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GetFeed = ucCreateFeed.Getfeed();
            Close();
        }
    }
}
