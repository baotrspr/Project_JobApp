using Project_JobApp.Classes;
using Project_JobApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UC
{
    public partial class UCProfile : UserControl
    {
        TaiKhoanDAO tk = new TaiKhoanDAO();
        public UCProfile()
        {
            InitializeComponent();
        }

        public string Userid
        {
            get { return txtUserid.Text; }
            set { txtUserid.Text = value; }
        }
        public string Ho
        {
            get { return txtSurName.Text; }
            set { txtSurName.Text = value;}
        }
        public string Ten
        {
            get { return txtName.Text; }
            set { txtName.Text = value;}
        }

        public string Ngsinh
        {
            get { return dtpBday.Value.ToString("dd/MM/yyyy"); }
            set 
            {
                    dtpBday.Text = value;
            }
        }
        public string Cmnd
        {
            get { return txtCmnd.Text; }
            set { txtCmnd.Text = value; }
        }
        public string Gioitinh
        {
            get { return cbxSex.SelectedItem.ToString(); }
            set { cbxSex.Text = value; }
        }
        public string Diachi
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public string Sdt
        {
            get { return txtPhoneNum.Text; }
            set { txtPhoneNum.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Thongtin
        {
            get { return rtxtMoreInfo.Text; }
            set { rtxtMoreInfo.Text = value; }
        }

        Account acc;
        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }

        public void SetValue(Account acc)
        {
            Userid = acc.Userid;
            Ho = acc.Ho;
            Ten = acc.Ten;
            Ngsinh = acc.Ngsinh;
            Cmnd = acc.Cmnd;
            Gioitinh = acc.Gioitinh;
            Diachi = acc.Diachi;
            Sdt = acc.Sdt;
            Email = acc.Email;
            Thongtin = acc.Thongtin;
        }

        public void Load( Account acc)
        {
            GetValues(acc);
            btnSave.Enabled = false;
            pnForm.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                acc = new Account(txtUserid.Text, txtSurName.Text, txtName.Text, dtpBday.Value.ToString("dd/MM/yyyy"), txtCmnd.Text, cbxSex.SelectedItem.ToString(), txtAddress.Text, txtPhoneNum.Text, txtEmail.Text, rtxtMoreInfo.Text);
                if (tk.Chinhsua(acc))
                {
                    MessageBox.Show("Đã cập nhật chỉnh sửa!", "Thông báo");
                    Load(acc);
                }
                else MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Truy cập cỉnh sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                pnForm.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        public void GetValues(Account acc)
        {
            tk.GetInfo( ref acc);
            SetValue(acc);
        }
    }
}
