using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_JobApp.UC
{
    public partial class UCProfile : UserControl
    {
        public UCProfile()
        {
            InitializeComponent();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opnfd = new OpenFileDialog();
                opnfd.Title = "Select Image file";
                opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                opnfd.Multiselect = false;
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    pbxPhoto.Image = new Bitmap(opnfd.FileName);
                    pbxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi\n" + ex.Message, "Failed");
            }
        }
    }
}
