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
    public partial class UCProfileSeeker : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        Account acc;
        JobSeeker js;
        public UCProfileSeeker()
        {
            InitializeComponent();
        }

        public UCProfileSeeker(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            LoadData();

            btnSave.Enabled = false;
            pnForm.Enabled = false;
        }

        public void LoadData()
        {
            js = jsDAO.GetInfo(acc.Userid);

            txtName.Text = js.Ten;
            txtSurName.Text = js.Ho;
            txtAddress.Text = js.Diachi;
            txtCmnd.Text = js.Cmnd;
            txtPhoneNum.Text = js.Sdt;
            txtEmail.Text = js.Email;
            txtUserid.Text = js.Userid;
            rtxtMoreInfo.Text = js.Thongtin;
            cbxSex.Text = js.Gioitinh;
            dtpBday.Text = js.Ngsinh;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    js = new JobSeeker(txtUserid.Text, txtSurName.Text, txtName.Text, dtpBday.Value.ToString("dd/MM/yyyy"), txtCmnd.Text, cbxSex.SelectedItem.ToString(), txtAddress.Text, txtPhoneNum.Text, txtEmail.Text, rtxtMoreInfo.Text);
                    if (jsDAO.Chinhsua(js))
                    {
                        MessageBox.Show("Đã cập nhật chỉnh sửa!", "Thông báo");
                        UCProfileSeeker_Load(sender, e);
                    }
                    else MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Truy cập chỉnh sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                pnForm.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void UCProfileSeeker_Load(object sender, EventArgs e)
        {
            LoadData();

            btnSave.Enabled = false;
            pnForm.Enabled = false;
        }
    }
}
