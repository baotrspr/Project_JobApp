using Project_JobApp.Classes;
using Project_JobApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_JobApp.UCMore;

namespace Project_JobApp.Forms
{
    public partial class FormViewApplicants : Form
    {
        CongviecDAO cvDAO = new CongviecDAO();
        string jobid;
        public FormViewApplicants()
        {
            InitializeComponent();
        }
        public FormViewApplicants(string jobid)
        {
            InitializeComponent();

            this.jobid = jobid;


        }

        private void FormViewApplicants_Load(object sender, EventArgs e)
        {
            DataTable dt = cvDAO.GetApplicants(jobid);
            flpDanhsach?.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                UngTuyen ut = new UngTuyen();
                ut.Userid = dr["userid"].ToString();
                ut.Jobid = dr["jobid"].ToString();
                ut.Tencv = dr["tencv"].ToString();
                ut.Thoigian = dr["thoigian"].ToString();
                ut.Macty = dr["congty"].ToString();
                ut.TTphanhoi = dr["trangthaiphanhoi"].ToString();
                ut.Loinhan = dr["loinhan"].ToString();
                UCAppliedSeeker view = new UCAppliedSeeker(ut);
                flpDanhsach.Controls.Add(view);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
