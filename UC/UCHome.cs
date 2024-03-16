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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            count.Start();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            lblFullDay.Text = DateTime.Now.ToString("dddd");
            lblDay.Text = DateTime.Now.ToString("dd");
            lblMonth.Text = "Tháng " + DateTime.Now.ToString("MM");
            lblYear.Text = DateTime.Now.ToString("yyyy");
        }

        private void count_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
