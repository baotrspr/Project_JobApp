﻿using Project_JobApp.Classes;
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
        SignupDAO signupDAO = new SignupDAO();
        public FormSignup()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPassword.Text, txtRePassword.Text) == 0)
            {
                string vaitro = "Admin";
                if (rdbHirer.Checked)
                {
                    vaitro = "Hirer";
                }
                else if (rdbJobSeeker.Checked)
                {
                    vaitro = "JobSeeker";
                }

                Account acc = new Account(txtUsername.Text, txtPassword.Text, vaitro);

                signupDAO.Signup(acc);
                
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo");
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Hide();
            formLogin.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
