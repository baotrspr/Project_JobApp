using Project_JobApp.Classes;
using Project_JobApp.DAO;
using Project_JobApp.UC;
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
    public partial class FormChinhsuaJob : Form
    {
        CongviecDAO jDAO = new CongviecDAO();
        CongViec cv;
        UCCreateJob ucThongtin;
        public FormChinhsuaJob()
        {
            InitializeComponent();
        }
        public FormChinhsuaJob(string jobid)
        {
            InitializeComponent();

            cv = jDAO.GetThongtin(jobid);
            ucThongtin = new UCCreateJob(cv);
            pnTab.Controls.Add(ucThongtin);
            ucThongtin.Dock = DockStyle.Fill;
            ucThongtin.BringToFront();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CongViec j = new CongViec(ucThongtin.JobID, ucThongtin.Userid, ucThongtin.Tieude, ucThongtin.Ngaytao, ucThongtin.Vitri, ucThongtin.Mucluong, ucThongtin.Linhvuc, ucThongtin.Mota, ucThongtin.Phucloi, ucThongtin.Yeucau, ucThongtin.Soluong, ucThongtin.Noilamviec, ucThongtin.Diadiem, ucThongtin.Handk);
            if (jDAO.Sua(j))
            {
                MessageBox.Show("Đã cập nhật chỉnh sửa!", "Thông báo");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
        }
    }
}
