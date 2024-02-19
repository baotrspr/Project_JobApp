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
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UC.SignUpUC signupUC = new UC.SignUpUC();
            signupUC.Dock = DockStyle.Fill;
            Main.MainForm.container.Controls.Add(signupUC);
            Main.MainForm.container.Controls["signupUC"].BringToFront();
            foreach (Main main in Main.MainForm.container.Controls.OfType<Main>())
                Main.MainForm.container.Controls.Remove(main);
        }
    }
}
