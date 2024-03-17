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
    public partial class UCAccount : UserControl
    {
        Account acc;
        public Account GetAccount
        {
            get { return acc; }
            set { acc = value; }
        }

        public UCAccount()
        {
            InitializeComponent();
            txtUserID.Text = acc.Userid;
            txtPassword.Text = acc.Matkhau;
        }

        //public UCAccount()
        //{
        //    txtUserID.Text = acc.Userid;
        //    txtPassword.Text = acc.Matkhau;
        //}
    }
}
