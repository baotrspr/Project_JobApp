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

namespace Project_JobApp.Forms
{
    public partial class FormCreateJob : Form
    {
        Job newjob;
        JobDAO jd = new JobDAO();
        Account acc;
        string jobdetailstr;
        public Job GetJob
        {
            get { return newjob; }
            set { newjob = value;}
        }
        public string JobDetailstr
        {
            get { return jobdetailstr; }
            set { jobdetailstr = value; }
        }
        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }
        public FormCreateJob()
        {
            InitializeComponent();
        }
        public void Load(Account acc)
        {
            GetAccount = acc;
            ucJobDetail.Load(acc);
        }
        private void btnAddJob_Click(object sender, EventArgs e)
        {
            GetJob = ucJobDetail.GetJob();
            jd.Them(GetJob);
            JobDetailstr = ucJobDetail.GetJobDetail();
            Close();
        }
        public string GetJobDetail()
        {
            return jobdetailstr;
        }
    }
}
