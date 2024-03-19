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

namespace Project_JobApp.UC
{
    public partial class UCAccount : UserControl
    {
        TaiKhoanDAO tk = new TaiKhoanDAO();
        Account acc;
        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }
        public UCAccount()
        {
            InitializeComponent();
        }

        public string Userid
        {
            get { return txtUserID.Text; }
            set { txtUserID.Text = value; }
        }
        public string Matkhau
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public void GetValues(Account acc)
        {
            txtUserID.Text = acc.Userid;
            txtPassword.Text = acc.Matkhau;
        }

        public void SetValues(Account acc)
        {
            acc.Matkhau = txtPassword.Text;
        }
        public void Load(Account acc)
        {
            pnValidate.Visible = false;
            lblConfirm.Visible = false;
            GetValues(acc);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnValidate.Visible = true;
            lblConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acc.Matkhau);
            if (txtNewPass.Text == txtReNewPass.Text)
            {
                if (txtOldPass.Text == GetAccount.Matkhau)
                {
                    if (txtOldPass.Text != txtNewPass.Text)
                    {
                        acc = new Account(Userid, txtNewPass.Text);
                        DialogResult dr = MessageBox.Show("Bạn chắc chắn đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                            if (tk.Chinhsua(acc))
                            {
                                MessageBox.Show("Đã cập nhật chỉnh sửa!", "Thông báo");
                                Load(acc);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ chưa chính xác!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo");
            }
        }
    }
}
