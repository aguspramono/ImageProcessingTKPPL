using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Enhancement : Form
    {
        OpenFileDialog openImage = new OpenFileDialog();
        Bitmap Real;

        public Enhancement()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            String pathFile = null;
            openImage.Filter = "Image Files (*.bmp;*.jpg;*.jpeg*;*.png) | *.bmp;*.jpg;*.jpeg;*.png";
            DialogResult result = openImage.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathFile = openImage.FileName;
                Real = new Bitmap(pathFile);
                pcbRealImage.Image = Real;
            }
        }
    }
}
