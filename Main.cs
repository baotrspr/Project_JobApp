using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp
{
    public partial class Main : Form
    {
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnDocker_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Main()
        {
            InitializeComponent();
        }

        private static Main mainform;
        //Constructor cho mainform
        public static Main MainForm
        {
            get
            {
                if (mainform == null)
                    mainform = new Main();
                return mainform;
            }
        }
        //Tao doi tuong cho container <-> pnProgram
        public Panel container
        {
            get
            {
                return this.pnProgram;
            }
            set
            {
                this.pnProgram = value;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainform = this;
            UC.UCLogin loginUC = new UC.UCLogin();
            loginUC.Dock = DockStyle.Fill;
            mainform.container.Controls.Add(loginUC);
            mainform.container.Controls["loginUC"].BringToFront();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
