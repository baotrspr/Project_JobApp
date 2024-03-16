using Project_JobApp.Classes;
using Project_JobApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormSignup : Form
    {
        SignupDAO signupdao = new SignupDAO();
        public FormSignup()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPassword.Text, txtRePassword.Text) == 0)
            {
                string vaitro = "admin";
                if (rdbHirer.Checked)
                {
                    vaitro = "hirer";
                }
                else if (rdbJobSeeker.Checked)
                {
                    vaitro = "seeker";
                }

                Account acc = new Account(txtUsername.Text, txtPassword.Text, vaitro);

                signupdao.Signup(acc);
                //if (signupdao.Signup(acc))
                //{
                //    MessageBox.Show("Đăng kí tài khoản thành công, vui lòng đăng nhập lại!", "Thông báo");
                //    btnLogin_Click(sender, e);
                //}
                //else
                //{
                //    MessageBox.Show("Tài khoản không hợp lệ hoặc đã tồn tại!", "Thông báo");
                //}
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo");
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
