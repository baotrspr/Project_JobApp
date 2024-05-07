using Project_JobApp.Classes;
using Project_JobApp.DAO;
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

namespace Project_JobApp.UCMore
{
    public partial class UCAppliedSeeker : UserControl
    {
        UngTuyen apl;
        AppliedListDAO apDAO = new AppliedListDAO();
        public UCAppliedSeeker()
        {
            InitializeComponent();
        }
        public UCAppliedSeeker(UngTuyen apl)
        {
            InitializeComponent();
            this.apl = apl;


            lblUserid.Text = apl.Userid;
            lblThoigian.Text = apl.Thoigian;
            if (apl.TTphanhoi == "waiting")
                pbxStatus.Image = Project_JobApp.Properties.Resources.writing;
            else if (apl.TTphanhoi == "accepted")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.accepted;
                btnChapnhan.Enabled = false;
                btnTuchoi.Enabled = false;
            }
            else if (apl.TTphanhoi == "rejected")
            {
                pbxStatus.Image = Project_JobApp.Properties.Resources.rejected;
                btnChapnhan.Enabled = false;
                btnTuchoi.Enabled = false;
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FormLoinhan loinhan = new FormLoinhan();
            loinhan.ShowDialog();

            DialogResult dr = loinhan.DialogResult;
            if (dr == DialogResult.OK)
            {
                apl.Loinhan = loinhan.Loinhan;
                if (apDAO.ChapNhan(apl))
                {
                    MessageBox.Show("Đã cập nhật!", "Thông báo");
                    pbxStatus.Image = Project_JobApp.Properties.Resources.accepted;
                    btnChapnhan.Enabled = false;
                    btnTuchoi.Enabled = false;
                }
                else
                    MessageBox.Show("Lỗi!", "Thông báo");
            }
            
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            FormLoinhan loinhan = new FormLoinhan();
            loinhan.ShowDialog();

            DialogResult dr = loinhan.DialogResult;
            if (dr == DialogResult.OK)
            {
                apl.Loinhan = loinhan.Loinhan;
                if (apDAO.TuChoi(apl))
                {
                    MessageBox.Show("Đã cập nhật!", "Thông báo");
                    pbxStatus.Image = Project_JobApp.Properties.Resources.rejected;
                    btnChapnhan.Enabled = false;
                    btnTuchoi.Enabled = false;
                }
                else
                    MessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btnXemhoso_Click(object sender, EventArgs e)
        {
            FormCV cv = new FormCV(apl.Userid);
            cv.ShowDialog();
        }
    }
}
