using Project_JobApp.Classes;
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
    public partial class UCCreateJob : UserControl
    {
        Account acc;
        public UCCreateJob()
        {
            InitializeComponent();
        }

        public UCCreateJob(Account acc)
        {
            InitializeComponent();
            this.acc = acc;

            txtCompanyID.Text = this.acc.Userid;
        }

        public string JobID
        {
            get { return txtJobID.Text; }
        }
        public string Userid
        {
            get { return txtCompanyID.Text; }
        }
        public string Tieude
        {
            get { return txtTitle.Text; }
        }
        public string Ngaytao
        {
            get { return dtpDate.Value.ToString("dd/MM/yyyy"); }
        }
        public string Vitri
        {
            get { return txtPosition.Text; }
        }
        public string Mucluong
        {
            get { return txtJobSalary.Text; } 
        }
        public string Linhvuc
        {
            get { return txtJobField.Text; }
        }
        public string Phucloi
        {
            get { return txtProfit.Text; }
        }
        public string Yeucau
        {
            get { return rtxtRequire.Text; }
        }
    }
}
