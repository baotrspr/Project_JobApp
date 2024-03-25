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

namespace Project_JobApp.UCMore
{
    public partial class UCJobRow : UserControl
    {
        Job j;
        CongviecDAO congviecDAO = new CongviecDAO();

        public UCJobRow()
        {
            InitializeComponent();
        }
        public UCJobRow(Job j)
        {
            InitializeComponent();
            this.j = j;

            lblJobID.Text = j.Jobid;
            lblDay.Text = j.Ngaytao;
            lblName.Text = j.Tencv;
            lblPosition.Text = j.Vitri;
            lblStatus.Text = j.Trangthai;
        }

        private void btnDelJob_Click(object sender, EventArgs e)
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
    }
}
