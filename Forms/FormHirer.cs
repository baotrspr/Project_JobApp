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
    public partial class FormHirer : Form
    {
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormHirer()
        {
            InitializeComponent();
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
            UC.UCHome ucHome = new UC.UCHome();
            pnTab.Controls.Add(ucHome);
            pnTab.Controls["ucHome"].BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(192, 255, 192);
            btnJobFeeds.BackColor = Color.FromArgb(224, 224, 224);
            btnAccount.BackColor = Color.FromArgb(224, 224, 224);
            btnPostedJobs.BackColor = Color.FromArgb(224, 224, 224);
            btnMyProfile.BackColor = Color.FromArgb(224, 224, 224);
            btnList.BackColor = Color.FromArgb(224, 224, 224);

            UC.UCHome ucHome = new UC.UCHome();
            pnTab.Controls.Add(ucHome);
            pnTab.Controls["ucHome"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucHome)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnJobFeeds_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnJobFeeds.BackColor = Color.FromArgb(192, 255, 192);
            btnAccount.BackColor = Color.FromArgb(224, 224, 224);
            btnPostedJobs.BackColor = Color.FromArgb(224, 224, 224);
            btnMyProfile.BackColor = Color.FromArgb(224, 224, 224);
            btnList.BackColor = Color.FromArgb(224, 224, 224);

            UC.UCJobFeed ucJobFeed = new UC.UCJobFeed();
            pnTab.Controls.Add(ucJobFeed);
            pnTab.Controls["ucJobFeed"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucJobFeed)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnPostedJobs_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnJobFeeds.BackColor = Color.FromArgb(224, 224, 224);
            btnAccount.BackColor = Color.FromArgb(224, 224, 224);
            btnPostedJobs.BackColor = Color.FromArgb(192, 255, 192);
            btnMyProfile.BackColor = Color.FromArgb(224, 224, 224);
            btnList.BackColor = Color.FromArgb(224, 224, 224);

            UC.UCPostedJob ucPostedJob = new UC.UCPostedJob();
            pnTab.Controls.Add(ucPostedJob);
            pnTab.Controls["ucPostedJob"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucPostedJob)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnJobFeeds.BackColor = Color.FromArgb(224, 224, 224);
            btnAccount.BackColor = Color.FromArgb(224, 224, 224);
            btnPostedJobs.BackColor = Color.FromArgb(224, 224, 224);
            btnMyProfile.BackColor = Color.FromArgb(192, 255, 192);
            btnList.BackColor = Color.FromArgb(224, 224, 224);

            UC.UCProfile ucProfile = new UC.UCProfile();
            pnTab.Controls.Add(ucProfile);
            pnTab.Controls["ucProfile"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucProfile)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnJobFeeds.BackColor = Color.FromArgb(224, 224, 224);
            btnAccount.BackColor = Color.FromArgb(192, 255, 192);
            btnPostedJobs.BackColor = Color.FromArgb(224, 224, 224);
            btnMyProfile.BackColor = Color.FromArgb(224, 224, 224);
            btnList.BackColor = Color.FromArgb(224, 224, 224);

            UC.UCAccount ucAccount = new UC.UCAccount();
            pnTab.Controls.Add(ucAccount);
            pnTab.Controls["ucAccount"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucAccount)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnJobFeeds.BackColor = Color.FromArgb(224, 224, 224);
            btnAccount.BackColor = Color.FromArgb(224, 224, 224);
            btnPostedJobs.BackColor = Color.FromArgb(224, 224, 224);
            btnMyProfile.BackColor = Color.FromArgb(224, 224, 224);
            btnList.BackColor = Color.FromArgb(224, 224, 224);

            UC.UCList ucList = new UC.UCList();
            pnTab.Controls.Add(ucList);
            pnTab.Controls["ucList"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucList)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
