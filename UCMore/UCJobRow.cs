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

namespace Project_JobApp.UCMore
{
    public partial class UCJobRow : UserControl
    {
        CongViec j;
        CongviecDAO congviecDAO = new CongviecDAO();

        public UCJobRow()
        {
            InitializeComponent();
        }
        public UCJobRow(CongViec j)
        {
            InitializeComponent();
            this.j = j;

            lblMacv.Text = j.Jobid;
            lblNgaytao.Text = j.Ngaytao;
            lblTencv.Text = j.Tencv;
            lblVitri.Text = j.Vitri;
            lblSoluong.Text = j.Dadangki.ToString();
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            FormChinhsuaJob edit = new FormChinhsuaJob(j.Jobid);
            edit.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormJobDetail jobDetail = new FormJobDetail(j);
            jobDetail.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (congviecDAO.Xoa(j))
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi!", "Thông báo");
            }
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            FormViewApplicants viewapl = new FormViewApplicants(j.Jobid);
            viewapl.ShowDialog();
        }
    }
}
