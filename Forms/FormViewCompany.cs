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
    public partial class FormViewCompany : Form
    {
        Company cp;
        CompanyDAO cpDAO = new CompanyDAO();
        public FormViewCompany()
        {
            InitializeComponent();
        }
        public FormViewCompany(string userid)
        {
            InitializeComponent();
            cp = cpDAO.GetInfo(userid);

            lblDiachi.Text = cp.Diachi;
            lblEmail.Text = cp.Email;
            lblWebsite.Text = cp.Website;
            lblLinhvuc.Text = cp.Linhvuc;
            lblMasothue.Text = cp.Masothue;
            lblNgaythanhlap.Text = cp.Ngaythanhlap;
            lblNguoidungdau.Text = cp.Ngdungdau;
            lblSodt.Text = cp.Sdt;
            lblTen.Text = cp.Ten;
            lblThongtin.Text = cp.Thongtin;

            Size s = TextRenderer.MeasureText(cp.Thongtin, lblThongtin.Font);
            lblThongtin.Width = s.Width;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
