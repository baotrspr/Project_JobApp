using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UC.LoginUC loginUC = new UC.LoginUC();
            loginUC.Dock = DockStyle.Fill;
            pnProgram.Controls.Add(loginUC);

        }
    }
}
