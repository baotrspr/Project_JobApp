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
                CongViec j = new CongViec();

                j.Jobid = dr["jobid"].ToString();
                j.Userid = dr["userid"].ToString();
                j.Tencv = dr["tencv"].ToString();
                j.Ngaytao = dr["ngaytao"].ToString();
                j.Vitri = dr["vitri"].ToString();
                j.Mucluong = dr["mucluong"].ToString();
                j.Linhvuc = dr["linhvuc"].ToString();
                j.Phucloi = dr["phucloi"].ToString();
                j.Yeucau = dr["yeucau"].ToString();
                j.Thongtin = dr["thongtin"].ToString() ;
                j.Handangki = dr["handangki"].ToString();
                j.Soluong = int.Parse(dr["soluong"].ToString());
                j.Dadangki = int.Parse(dr["dadangki"].ToString());
                j.Trangthai = dr["trangthai"].ToString();
                j.Noilamviec = dr["noilamviec"].ToString();
                j.Diadiem= dr["diadiem"].ToString();

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
