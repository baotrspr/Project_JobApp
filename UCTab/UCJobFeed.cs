using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.Database;
using Project_JobApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UC
{
    public partial class UCJobFeed : UserControl
    {
        CongviecDAO jd = new CongviecDAO();

        Account acc;
        public UCJobFeed()
        {
            InitializeComponent();
        }
        public UCJobFeed(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            if (acc.Vaitro == "JobSeeker")
                btnCreate.Enabled = false;

            if (flpData != null)
            {
                foreach (UserControl uc in flpData.Controls)
                {
                    flpData.Controls.Remove(uc);
                }
            }
            LoadList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateJob create = new FormCreateJob(acc);
            create.ShowDialog();  
            LoadList();
        }

        private void LoadList()
        {
            if (flpData != null)
            {
                foreach (UserControl uc in flpData.Controls)
                {
                    flpData.Controls.Remove(uc);
                }
            }
            DataTable dt = jd.GetData();
            foreach (DataRow dr in dt.Rows)
            {
                Job j = new Job();
                j.Jobid = dr["jobid"].ToString();
                j.Tencv = dr["tencv"].ToString();
                j.Vitri = dr["vitri"].ToString();
                j.Linhvuc = dr["linhvuc"].ToString();
                j.Mucluong = dr["mucluong"].ToString();
                j.Yeucau = dr["yeucau"].ToString();
                j.Phucloi = dr["phucloi"].ToString();
                j.Userid = dr["userid"].ToString();
                j.Ngaytao = dr["ngaytao"].ToString();
                j.Trangthai = dr["trangthai"].ToString();
                UCThumbnail thumb = new UCThumbnail(j, acc);
                flpData.Controls.Add(thumb);
            }
        }
    }
}
