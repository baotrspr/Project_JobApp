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
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    SendMessage();
                    btnLogin_Click(sender, e);
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
        public void SendMessage()
        {
            MessageBox.Show("Đăng kí thành công!\n Vui lòng đăng nhập lại.", "Thông báo");
        }

        private bool Validation()
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text) ||
                String.IsNullOrWhiteSpace(txtRePassword.Text))
                return false;
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
