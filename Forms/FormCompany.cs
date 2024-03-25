using Project_JobApp.Classes;
using Project_JobApp.UC;
using Project_JobApp.UCTab;
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
    public partial class FormCompany : Form
    {
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Account acc;

        public FormCompany()
        {
            InitializeComponent();
        }

        public FormCompany(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
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

        private void FormHirer_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Chào mừng " + acc.Userid;
            ucHome.BringToFront();
            rdbHome.Checked = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát khỏi phiên đăng nhập này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void rdbInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInfo.Checked)
            {
                UCProfileCompany ucProfile = new UCProfileCompany(acc);
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

        private void rdbJobManager_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJobManager.Checked)
            {
                UCJobManager ucJobManager = new UCJobManager(acc);
                pnTab.Controls.Add(ucJobManager);
                ucJobManager.Dock = DockStyle.Fill;
                ucJobManager.BringToFront();
            }
        }
    }
}
