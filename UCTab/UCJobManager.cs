using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.UCMore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UCTab
{
    public partial class UCJobManager : UserControl
    {
        Account acc;
        CompanyDAO cpDAO = new CompanyDAO();
        public UCJobManager()
        {
            InitializeComponent();
        }
        public UCJobManager(Account acc)
        {
            InitializeComponent();
            this.acc = acc;

            LoadData();
        }

        public void LoadData()
        {
            if (flpList != null)
            {
                foreach (Control control in flpList.Controls.OfType<UCJobRow>())
                {
                    control.Dispose();
                    flpList.Controls.Remove(control);
                }
            }

            DataTable dt = cpDAO.GetJobList(acc);

            foreach (DataRow dr in dt.Rows)
            {
                Job j = new Job();

                j.Jobid = dr[0].ToString();
                j.Userid = dr[1].ToString();
                j.Tencv = dr[2].ToString();
                j.Ngaytao = dr[3].ToString();
                j.Vitri = dr[4].ToString();
                j.Mucluong = dr[5].ToString();
                j.Linhvuc = dr[6].ToString();
                j.Phucloi = dr[7].ToString();
                j.Yeucau = dr[8].ToString();

                UCJobRow ucJobRow = new UCJobRow(j);
                flpList.Controls.Add(ucJobRow);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
