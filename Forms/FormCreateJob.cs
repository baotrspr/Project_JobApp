using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormCreateJob : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


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

        private void docker_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
