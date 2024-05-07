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
    public partial class FormCV : Form
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        public FormCV()
        {
            InitializeComponent();
        }
        public FormCV(string userid)
        {
            InitializeComponent();

            JobSeeker js = jsDAO.GetInfo(userid);
            lblTen.Text = js.Ho + " " + js.Ten;
            lblNgaysinh.Text = js.Ngsinh;
            lblGioitinh.Text = js.Gioitinh;
            lblThongtin.Text = js.Thongtin;
            lblEmail.Text = js.Email;
            lblSodt.Text = js.Sdt;
            lblDiachi.Text = js.Diachi;
            lblCmnd.Text = js.Cmnd;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
