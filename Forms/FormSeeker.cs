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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormSeeker : Form
    {
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Account acc;
        public FormSeeker()
        {
            InitializeComponent();
        }
        public FormSeeker(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            lblInfo.Text = "Chào mừng " + acc.Userid;
        }

        private void docker_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormSeeker_Load(object sender, EventArgs e)
        {
            ucHome.BringToFront();
            rdbHome.Checked = true;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát khỏi phiên đăng nhập này?", "Thông báo" , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                this.Close();
            }
        }

        private void rdbHome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHome.Checked)
            {
                ucHome.BringToFront();
            }
        }

        private void rdbFeed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFeed.Checked)
            {
                UC.UCJobFeed ucJobFeed = new UC.UCJobFeed(acc);
                pnTab.Controls.Add(ucJobFeed);
                ucJobFeed.Dock = DockStyle.Fill;
                ucJobFeed.BringToFront();
            }
        }

        private void rdbApplied_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbApplied.Checked)
            {
                UCAppliedJob ucAppliedJob = new UCAppliedJob(acc);
                pnTab.Controls.Add(ucAppliedJob);
                ucAppliedJob.Dock = DockStyle.Fill;
                ucAppliedJob.BringToFront();
            }
        }

        private void rdbInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInfo.Checked)
            {
                UCProfileSeeker ucProfile = new UCProfileSeeker(acc);
                pnTab.Controls.Add(ucProfile);
                ucProfile.Dock = DockStyle.Fill;
                ucProfile.BringToFront();
            }
        }

        private void rdbAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAccount.Checked)
            {
                UCAccount ucAccount = new UCAccount(acc);
                pnTab.Controls.Add(ucAccount);
                ucAccount.Dock = DockStyle.Fill;
                ucAccount.BringToFront();
            }
        }
    }
}
