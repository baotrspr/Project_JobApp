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
    public partial class UCAppliedJobs : UserControl
    {
        AppliedList apl;
        AppliedListDAO apDAO = new AppliedListDAO();
        public UCAppliedJobs()
        {
            InitializeComponent();
        }
        public UCAppliedJobs(AppliedList apl)
        {
            InitializeComponent();
            this.apl = apl;

            lblJobID.Text = apl.Jobid;
            lblTencv.Text = apl.Tencv;
            lblCompany.Text = apl.Macty;
            lblTime.Text = apl.Thoigian;
            if (apl.TTphanhoi == "waiting")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.hourglass;
            } else if(apl.TTphanhoi == "accepted")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.accepted;
            } else if (apl.TTphanhoi == "rejected")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.rejected;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn hủy đăng kí?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (apDAO.Xoa(apl))
                {
                    MessageBox.Show("Hủy thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Có lỗi!", "Thông báo");
                }
            }
        }
    }
}
