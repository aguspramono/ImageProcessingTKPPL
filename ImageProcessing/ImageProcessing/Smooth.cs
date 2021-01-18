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
    public partial class Smooth : Form
    {
        OpenFileDialog openImage = new OpenFileDialog();
        Bitmap Real, Mean;

        public Smooth()
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

        private void btnMean_Click(object sender, EventArgs e)
        {
            if (Real != null)
            {
                Mean = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Random rand = new Random();

                for (int i = 1; i < Real.Width - 1; i++)
                {
                    for (int j = 1; j < Real.Height - 1; j++)
                    {
                        Color p1 = Real.GetPixel(i - 1, j - 1);
                        Color p2 = Real.GetPixel(i - 1, j);
                        Color p3 = Real.GetPixel(i - 1, j + 1);
                        Color p4 = Real.GetPixel(i, j - 1);
                        Color p5 = Real.GetPixel(i, j);
                        Color p6 = Real.GetPixel(i, j + 1);
                        Color p7 = Real.GetPixel(i + 1, j - 1);
                        Color p8 = Real.GetPixel(i + 1, j);
                        Color p9 = Real.GetPixel(i + 1, j + 1);

                        int meanR = (p1.R + p2.R + p3.R + p4.R + p5.R + p6.R + p7.R + p8.R + p9.R) / 9;
                        int meanG = (p1.G + p2.G + p3.G + p4.G + p5.G + p6.G + p7.G + p8.G + p9.G) / 9;
                        int meanB = (p1.B + p2.B + p3.B + p4.B + p5.B + p6.B + p7.B + p8.B + p9.B) / 9;

                        Mean.SetPixel(i, j, Color.FromArgb(meanR, meanG, meanB));
                    }
                }

                pcbMeanImage.Image = Mean;
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }
    }
}
