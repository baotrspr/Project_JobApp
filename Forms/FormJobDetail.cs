using Project_JobApp.Classes;
using Project_JobApp.DAO;
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
    public partial class FormJobDetail : Form
    {
        AppliedListDAO listDAO = new AppliedListDAO();
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        public FormJobDetail()
        {
            InitializeComponent();
        }
        Job job;
        Account acc;
        AppliedList apl;
        public FormJobDetail(Job job, Account acc)
        {
            InitializeComponent();

            this.job = job;
            this.acc = acc;

            if (acc.Vaitro == "Company" || job.Trangthai == "accepted")
                btnApply.Enabled = false;

            lblJobID.Text = job.Jobid;
            lblJobName.Text = job.Tencv;
            lblPosition.Text = job.Vitri;
            lblField.Text = job.Linhvuc;
            lblDate.Text = job.Ngaytao;
            lblProfit.Text = job.Phucloi;
            lblRequire.Text = job.Yeucau;
            lblSalary.Text = job.Mucluong;
            lblUserID.Text = job.Userid;

        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            AppliedList ap = new AppliedList(acc.Userid, job.Jobid, job.Tencv, DateTime.Now.ToString("dd/MM/yyyy"), job.Userid, "waiting");
            if (listDAO.Them(ap))
            {
                MessageBox.Show("Ứng tuyển thành công, đợi công ty xét duyệt nhé!", "Thông báo");
                btnApply.Enabled = false;
            }
            else
            {
                MessageBox.Show("Có lỗi!", "Thông báo");
            }
        }
    }
}
