using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.UCMore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UC
{
    public partial class UCAppliedJob : UserControl
    {
        
        Account acc;
        AppliedListDAO apDAO = new AppliedListDAO();
        public UCAppliedJob()
        {
            InitializeComponent();
        }
        public UCAppliedJob(Account acc)
        {
            InitializeComponent();
            this.acc = acc;

            lblTitle.Text = "Danh sách công việc đã ứng tuyển";
            Load(); 
        }

        private void Load()
        {
            if (flpList != null)
            {
                foreach (UCAppliedJobs uc in flpList.Controls)
                {
                    uc.Dispose();
                    flpList.Controls.Remove(uc);
                }
            }
            DataTable dt = apDAO.GetJobData(acc.Userid);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UngTuyen apl = new UngTuyen();
                    apl.Userid = dr[0].ToString();
                    apl.Jobid = dr[1].ToString();
                    apl.Tencv = dr[2].ToString();
                    apl.Thoigian = dr[3].ToString();
                    apl.Macty = dr[4].ToString();
                    apl.TTphanhoi = dr[5].ToString();
                    apl.Loinhan = dr[6].ToString();
                    UCAppliedJobs ucApplied = new UCAppliedJobs(apl);
                    flpList.Controls.Add(ucApplied);
                }
            }
        }
    }
}
