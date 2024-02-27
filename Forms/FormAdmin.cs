using Project_JobApp.UC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UCAccountManager ucAccountManager = new UCAccountManager();
            pnTab.Controls.Add(ucAccountManager);
            pnTab.Controls["ucAccountManager"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucAccountManager)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            UCPostManager ucPostManager = new UCPostManager();
            pnTab.Controls.Add(ucPostManager);
            pnTab.Controls["ucPostManager"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucPostManager)
                    pnTab.Controls.Remove(userControl);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            UC.UCHome ucHome = new UC.UCHome();
            pnTab.Controls.Add(ucHome);
            pnTab.Controls["ucHome"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucHome)
                    pnTab.Controls.Remove(userControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC.UCHome ucHome = new UC.UCHome();
            pnTab.Controls.Add(ucHome);
            pnTab.Controls["ucHome"].BringToFront();
            foreach (UserControl userControl in pnTab.Controls)
                if (userControl != ucHome)
                    pnTab.Controls.Remove(userControl);
        }
    }
}
