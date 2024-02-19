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
    public partial class SignUpUC : UserControl
    {
        public SignUpUC()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UC.LoginUC loginUC = new UC.LoginUC();
            loginUC.Dock = DockStyle.Fill;
            Main.MainForm.container.Controls.Add(loginUC);
            Main.MainForm.container.Controls["loginUC"].BringToFront();
            foreach (Main main in Main.MainForm.container.Controls.OfType<Main>())
                Main.MainForm.container.Controls.Remove(main);
        }
    }
}
