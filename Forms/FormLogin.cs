using Project_JobApp.Classes;
using Project_JobApp.DAO;
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
        LoginDAO loginDAO = new LoginDAO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = "Jobseeker";
            if (rdbJobSeeker.Checked)
                role = "JobSeeker";
            else if (rdbCompany.Checked)
                role = "Company";
            Account acc = new Account(txtUsername.Text, txtPassword.Text, role);

            if (loginDAO.CheckLogin(acc))
            {
                if (acc.Vaitro == "JobSeeker")
                {
                    FormSeeker seeker = new FormSeeker(acc);
                    Success();
                    Hide();
                    seeker.ShowDialog();
                    this.Close();
                }
                else if (acc.Vaitro == "Company")
                {
                    FormCompany hirer = new FormCompany(acc);
                    Success();
                    Hide();
                    hirer.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                Fail();
            }
        }

        public void Success()
        {
            MessageBox.Show("Đăng nhập thành công!", "Thông báo");
        }
        public void Fail()
        {
            MessageBox.Show("Thông tin không khớp với hệ thống!", "Thông báo");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            Hide();
            formSignup.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
