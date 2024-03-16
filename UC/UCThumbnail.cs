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
        string tid;
        Feeds tfeed;
        public Feeds Tfeed
        {
            get { return tfeed; }
            set { tfeed = value; }
        }
        private void UCThumbnail_Click(object sender, EventArgs e)
        {
            UCDetail detail = new UCDetail();
            Form detailForm = new Form();
            detailForm.Controls.Add(detail);
            detailForm.ShowDialog();
        }
        public string GetTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string GetDate
        {
            get { return lblDate_1.Text; }
            set { lblDate_1.Text = value; }
        }
        public string GetField
        {
            get { return lblField_1.Text; }
            set { lblField_1.Text = value; }
        }
        public string GetID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
    }
}
