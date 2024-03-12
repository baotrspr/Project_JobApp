using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbtJobSeeker.Checked)
            {
                
                FormSeeker seeker = new FormSeeker();
                SendMessage();
                Hide();
                seeker.ShowDialog();
                this.Close();
            }
            else if (rbtHirer.Checked)
            {
                FormHirer hirer = new FormHirer();
                SendMessage();
                Hide();
                hirer.ShowDialog();
                this.Close();
            }
            else
            {
                FormAdmin formAdmin = new FormAdmin();
                Hide();
                formAdmin.ShowDialog();
                this.Close();
            }
        }

        public void SendMessage()
        {
            MessageBox.Show("Đăng nhập thành công!", "Thông báo");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            formSignup.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
