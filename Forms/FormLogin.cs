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
                seeker.ShowDialog();
                this.Close();
            }
            else if (rbtHirer.Checked)
            {
                FormHirer hirer = new FormHirer();
                SendMessage();
                hirer.ShowDialog();
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
    }
}
