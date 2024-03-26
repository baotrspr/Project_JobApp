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
    public partial class UCProfileCompany : UserControl
    {
        CompanyDAO cpDAO = new CompanyDAO();
        Account acc;
        Company cp;

        public UCProfileCompany()
        {
            InitializeComponent();
        }
        public UCProfileCompany(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            LoadData();

            btnSave.Enabled = false;
            pnForm.Enabled = false;
        }

        private void LoadData()
        {
            cp = cpDAO.GetInfo(acc.Userid);

            txtAddress.Text = cp.Diachi;
            txtEmail.Text = cp.Email;
            txtLead.Text = cp.Ngdungdau;
            txtLicense.Text = cp.Giayphep;
            txtName.Text = cp.Ten;
            txtPhoneNum.Text = cp.Sdt;
            txtUserid.Text = cp.Userid;
            rtxtMoreInfo.Text = cp.Thongtin;
            dtpDay.Text = cp.Ngaythanhlap;
            txtField.Text = cp.Linhvuc;
            txtTax.Text = cp.Masothue;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cp = new Company(txtUserid.Text, txtName.Text, dtpDay.Value.ToString("dd/MM/yyyy"), txtLicense.Text, txtLead.Text, txtAddress.Text, txtPhoneNum.Text, txtTax.Text, txtField.Text, txtEmail.Text, rtxtMoreInfo.Text);
                    if (cpDAO.Chinhsua(cp))
                    {
                        MessageBox.Show("Đã cập nhật chỉnh sửa!", "Thông báo");
                        LoadData();
                    }
                    else MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
