using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.Forms
{
    public partial class FormJobDetail : Form
    {
        //Drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void dock_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        AppliedListDAO listDAO = new AppliedListDAO();
        //JobSeekerDAO jsDAO = new JobSeekerDAO();
        CompanyDAO compDAO = new CompanyDAO();
        public FormJobDetail()
        {
            InitializeComponent();
        }
        CongViec job;
        Account acc;
        AppliedList apl;
        public FormJobDetail(CongViec job, Account acc)
        {
            InitializeComponent();

            this.job = job;
            this.acc = acc;

            if (acc.Vaitro == "Company" || job.Trangthai == "notavail")
                btnUngtuyen.Enabled = false;
            if (acc.Vaitro == "JobSeeker" && listDAO.KiemtraUT(acc.Userid) == false)
                btnUngtuyen.Enabled = true;

            lblMacv.Text = job.Jobid;
            lblJobName.Text = job.Tencv;
            lblVitri.Text = job.Vitri;
            lblLinhvuc.Text = job.Linhvuc;
            lblNgaytao.Text = job.Ngaytao;
            lblPhucloi.Text = job.Phucloi;
            lblYeucau.Text = job.Yeucau;
            lblSoluong.Text = job.Soluong.ToString();
            lblLuong.Text = job.Mucluong;
            lblUserID.Text = job.Tencty;
            lblDadangki.Text = job.Dadangki.ToString();
            lblHandangki.Text = job.Handangki.ToString();
            llblXemCty.Text = job.Userid.ToString();
            lblMota.Text = job.Thongtin;

            Size size1 = TextRenderer.MeasureText(job.Thongtin, lblMota.Font);
            lblMota.Width = size1.Width;
            Size size2 = TextRenderer.MeasureText(job.Phucloi, lblPhucloi.Font);
            lblPhucloi.Width = size2.Width;
            Size size3 = TextRenderer.MeasureText(job.Yeucau, lblYeucau.Font);
            lblYeucau.Width = size3.Width;
        }

        public FormJobDetail(CongViec job)
        {
            InitializeComponent();

            this.job = job;
            btnUngtuyen.Visible = false;

            lblMacv.Text = job.Jobid;
            lblJobName.Text = job.Tencv;
            lblVitri.Text = job.Vitri;
            lblLinhvuc.Text = job.Linhvuc;
            lblNgaytao.Text = job.Ngaytao;
            lblPhucloi.Text = job.Phucloi;
            lblYeucau.Text = job.Yeucau;
            lblSoluong.Text = job.Soluong.ToString();
            lblLuong.Text = job.Mucluong;
            lblUserID.Text = job.Tencty;
            lblDadangki.Text = job.Dadangki.ToString();
            lblHandangki.Text = job.Handangki.ToString();
            llblXemCty.Text = job.Userid.ToString();
            lblMota.Text = job.Thongtin;

            Size size1 = TextRenderer.MeasureText(job.Thongtin, lblMota.Font);
            lblMota.Width = size1.Width;
            Size size2 = TextRenderer.MeasureText(job.Phucloi, lblPhucloi.Font);
            lblPhucloi.Width = size2.Width;
            Size size3 = TextRenderer.MeasureText(job.Yeucau, lblYeucau.Font);
            lblYeucau.Width = size3.Width;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            AppliedList ap = new AppliedList(acc.Userid, job.Jobid, job.Tencv, DateTime.Now.ToString("dd/MM/yyyy"), job.Userid, "waiting", "none");
            if (listDAO.Them(ap))
            {
                MessageBox.Show("Ứng tuyển thành công, đợi công ty xét duyệt nhé!", "Thông báo");
                btnUngtuyen.Enabled = false;
            }
            else
            {
                MessageBox.Show("Có lỗi!", "Thông báo");
            }
        }

        private void llblXemCty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormViewCompany cpView = new FormViewCompany(job.Userid);
            cpView.ShowDialog();
        }
    }
}
