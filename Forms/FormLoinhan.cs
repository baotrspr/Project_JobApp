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
    public partial class FormLoinhan : Form
    {
        public string Loinhan;
        public FormLoinhan()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Loinhan = rtxtLoinhan.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
