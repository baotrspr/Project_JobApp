using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormCreateJob : Form
    {
        Account acc;
        UCCreateJob ucCreateJob;
        CongviecDAO jDAO = new CongviecDAO();
        public FormCreateJob()
        {
            InitializeComponent();
        }

        public FormCreateJob(Account inacc)
        {
            InitializeComponent();

            this.acc = inacc;
            ucCreateJob = new UCCreateJob(acc);
            pnMain.Controls.Add(ucCreateJob);
            ucCreateJob.Dock = DockStyle.Fill;
            ucCreateJob.BringToFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            CongViec j = new CongViec(ucCreateJob.JobID, ucCreateJob.Userid, ucCreateJob.Tieude, ucCreateJob.Ngaytao, ucCreateJob.Vitri, ucCreateJob.Mucluong, ucCreateJob.Linhvuc, ucCreateJob.Mota, ucCreateJob.Phucloi,ucCreateJob.Yeucau, ucCreateJob.Soluong, ucCreateJob.Noilamviec, ucCreateJob.Diadiem, ucCreateJob.Handk);
            
                if (jDAO.Them(j))
            {
                MessageBox.Show("Thêm công việc thành công!", "Thông báo");
                DialogResult = DialogResult.OK;
                Close();
            } else
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
        }
    }
}
