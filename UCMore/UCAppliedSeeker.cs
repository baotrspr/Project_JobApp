using Project_JobApp.Classes;
using Project_JobApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UCMore
{
    public partial class UCAppliedSeeker : UserControl
    {
        AppliedList apl;
        AppliedListDAO apDAO = new AppliedListDAO();
        public UCAppliedSeeker()
        {
            InitializeComponent();
        }
        public UCAppliedSeeker(AppliedList apl)
        {
            InitializeComponent();
            this.apl = apl;

            lblSeekerID.Text = apl.Userid;
            lblJob.Text = apl.Tencv;
            lblTime.Text = apl.Thoigian;
            if (apl.TTphanhoi == "waiting")
                pbxStatus.Image = Project_JobApp.Properties.Resources.writing;
            else if (apl.TTphanhoi == "accepted")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.accepted;
                btnAccept.Enabled = false;
                btnDecline.Enabled = false;
            }
            else if (apl.TTphanhoi == "rejected")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.rejected;
                btnAccept.Enabled = false;
                btnDecline.Enabled = false;
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (apDAO.ChapNhan(apl))
            {
                MessageBox.Show("Đã cập nhật!", "Thông báo");
                pbxStatus.Image = Project_JobApp.Properties.Resources.accepted;
                btnAccept.Enabled = false;
                btnDecline.Enabled = false;
            }
            else
                MessageBox.Show("Lỗi!", "Thông báo");
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (apDAO.TuChoi(apl))
            {
                MessageBox.Show("Đã cập nhật!", "Thông báo");
                pbxStatus.Image = Project_JobApp.Properties.Resources.rejected;
                btnAccept.Enabled = false;
                btnDecline.Enabled = false;
            }
            else
                MessageBox.Show("Lỗi!", "Thông báo");
        }
    }
}
