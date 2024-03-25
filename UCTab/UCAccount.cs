using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.Forms;
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
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        TaiKhoanDAO tk = new TaiKhoanDAO();
        Account acc;

        public bool checkDel = false;
        public UCAccount()
        {
            InitializeComponent();
        }
        public UCAccount(Account acc)
        {
            InitializeComponent();
            this.acc = acc;

            LoadData();

            pnValidate.Visible = false;
            pnDelValidate.Visible = false;
            lblConfirm.Visible = false;
        }

        public void LoadData()
        {
            txtUserID.Text = acc.Userid;
            txtPassword.Text = acc.Matkhau;
            txtRole.Text = acc.Vaitro;
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

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnValidate.Visible = true;
            lblConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtReNewPass.Text)
            {
                if (txtOldPass.Text == acc.Matkhau)
                {
                    if (txtOldPass.Text != txtNewPass.Text)
                    {
                        acc = new Account(Userid, txtNewPass.Text);
                        DialogResult dr = MessageBox.Show("Bạn chắc chắn đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                            if (tk.DoiMK(acc))
                            {
                                MessageBox.Show("Đã cập nhật chỉnh sửa!", "Thông báo");
                                LoadData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnDelValidate.Visible = true;
        }

        private void btnDelConfirm_Click(object sender, EventArgs e)
        {
            if (txtDelPassword.Text == txtPassword.Text)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    if (tk.XoaTK(acc))
                    {
                        MessageBox.Show("Đã xóa tài khoản!", "Thông báo");
                        checkDel = true;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                    }
            }
            else
            {
                MessageBox.Show("Mật khẩu chưa chính xác!", "Thông báo");
            }
        }
    }
}
