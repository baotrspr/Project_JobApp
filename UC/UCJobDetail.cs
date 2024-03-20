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
    public partial class UCJobDetail : UserControl
    {
        Job newjob;
        public UCJobDetail()
        {
            InitializeComponent();
        }
        public string Jobid
        {
            get { return txtJobid.Text; }
            set { txtJobid.Text = value;}
        }
        public string Tencv
        {
            get { return txtJobname.Text; } 
            set { txtJobname.Text = value;}
        }
        public string Mucluong
        {
            get { return txtJobSalary.Text; }
            set { txtJobSalary.Text = value;}
        }
        public string Linhvuc
        {
            get { return txtJobField.Text; }
            set { txtJobField.Text = value;}
        }
        public string Thongtin
        {
            get { return txtJobinfo.Text; }
            set { txtJobinfo.Text = value;}
        }
        public string Trinhdo
        {
            get { return txtJoblevel.Text; }
            set { txtJoblevel.Text = value; }
        }
        public string Userid
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }
        //public Job GetJob
        //{
        //    get { return newjob; }
        //    set { newjob = value; }
        //}
        public string GetJobDetail()
        {
            newjob = new Job(Jobid, Tencv, Mucluong, Linhvuc, Thongtin, Trinhdo, Userid);
            return newjob.ToString();
        }
        public Job GetJob()
        {
            return new Job(Jobid, Tencv, Mucluong, Linhvuc, Thongtin, Trinhdo, Userid);
        }
        public void Load(Account acc)
        {
            
            txtUser.Text = acc.Userid;
        }
    }
}
