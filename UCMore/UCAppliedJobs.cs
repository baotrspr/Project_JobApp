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
    public partial class UCAppliedJobs : UserControl
    {
        UngTuyen apl;
        AppliedListDAO apDAO = new AppliedListDAO();
        CongViec j;
        CongviecDAO cvDAO = new CongviecDAO();
        Company cp;
        CompanyDAO compDAO = new CompanyDAO();
        public UCAppliedJobs()
        {
            InitializeComponent();
        }
        public UCAppliedJobs(UngTuyen apl)
        {
            InitializeComponent();
            this.apl = apl;
            if (apl.TTphanhoi == "waiting")
                lblTrangthai.Text = "Đang chờ xét duyệt";
            else if (apl.TTphanhoi == "accepted")
            {
                lblTrangthai.Text = "Đã xét duyệt";
                lblTrangthai.ForeColor = Color.Green;
            }
            else if (apl.TTphanhoi == "rejected")
            {
                lblTrangthai.Text = "Không được xét duyệt";
                lblTrangthai.ForeColor = Color.DarkRed;
            }
            lblTencv.Text = apl.Tencv;
            lblCongty.Text = apl.Macty;
            lblThoigian.Text = apl.Thoigian;
            if (apl.Loinhan == "none")
            {
                llblLoinhan.Visible = false;
            }
            else
            {
                llblLoinhan.Visible = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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

        private void llblLoinhan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (apl.Loinhan != "none")
            {
                MessageBox.Show("Lời nhắn của công ty: \n" + apl.Loinhan, "Lời nhắn", MessageBoxButtons.OK);
            }
        }

        private void btnXemcv_Click(object sender, EventArgs e)
        {
            j = cvDAO.GetThongtin(apl.Jobid);
            FormJobDetail jobDetail = new FormJobDetail(j);
            jobDetail.ShowDialog();
        }

        private void btnXemCty_Click(object sender, EventArgs e)
        {
            cp = compDAO.GetInfo(apl.Macty);
            FormViewCompany viewcp = new FormViewCompany(apl.Macty);
            viewcp.ShowDialog();
        }
    }
} 
