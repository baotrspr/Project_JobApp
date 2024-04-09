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
        DataTable dt;
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

            rdbAll.Checked = true;
            txtInput.Enabled = false;
            cbxField.Enabled = false;

            if (flpData != null)
            {
                foreach (UserControl uc in flpData.Controls)
                {
                    flpData.Controls.Remove(uc);
                }
            }
            dt = jd.GetData();
            LoadList(dt);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateJob create = new FormCreateJob(acc);
            create.ShowDialog();  
            LoadList(dt);
        }

        private void LoadList(DataTable dt)
        {
            if (flpData != null)
            {
                foreach (UCThumbnail uc in flpData.Controls)
                {
                    uc.Dispose();
                    flpData.Controls.Remove(uc);
                }
            }
            //DataTable dt = jd.GetData();
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
            {
                dt = jd.GetData();
                LoadList(dt);
            }
            else if (rdbField.Checked)
            {
                string choose = cbxField.SelectedItem.ToString();
                dt = jd.GetData(choose);
                LoadList(dt);
            }
            else if (rdbSalary.Checked)
            {
                int input = int.Parse(txtInput.Text);
                dt = jd.GetData(input);
                LoadList(dt);
            }
        }

        private void rdbField_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbField.Checked == true)
                cbxField.Enabled = true;
            else cbxField.Enabled = false;
        }

        private void rdbSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSalary.Checked == true)
            {
                txtInput.Enabled = true;
            }
            else txtInput.Enabled = false;
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked == true)
            {
                txtInput.Enabled = false;
                cbxField.Enabled = false;
            }
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            rdbAll.Checked = true;
            rdbAll_CheckedChanged(sender, e);
            dt = jd.GetData();
            LoadList(dt);
        }
    }
}
