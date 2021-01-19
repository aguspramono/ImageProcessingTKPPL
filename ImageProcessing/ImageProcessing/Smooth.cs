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
        Bitmap Real, Mean, Median;

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

        private void btnMedian_Click(object sender, EventArgs e)
        {
            if (Real != null)
            {
                int[] dataR = new int[9];
            int[] dataG = new int[9];
            int[] dataB = new int[9];
            
            Median = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

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

                    dataR[0] = p1.R;
                    dataR[1] = p2.R;
                    dataR[2] = p3.R;
                    dataR[3] = p4.R;
                    dataR[4] = p5.R;
                    dataR[5] = p6.R;
                    dataR[6] = p7.R;
                    dataR[7] = p8.R;
                    dataR[8] = p9.R;

                    dataG[0] = p1.G;
                    dataG[1] = p2.G;
                    dataG[2] = p3.G;
                    dataG[3] = p4.G;
                    dataG[4] = p5.G;
                    dataG[5] = p6.G;
                    dataG[6] = p7.G;
                    dataG[7] = p8.G;
                    dataG[8] = p9.G;

                    dataB[0] = p1.B;
                    dataB[1] = p2.B;
                    dataB[2] = p3.B;
                    dataB[3] = p4.B;
                    dataB[4] = p5.B;
                    dataB[5] = p6.B;
                    dataB[6] = p7.B;
                    dataB[7] = p8.B;
                    dataB[8] = p9.B;

                    for (int x = 0; x < dataR.Length - 1; x++)
                    {
                        for (int y = x + 1; y < dataR.Length; y++)
                        {
                            if (dataR[x] > dataR[y])
                            {
                                int tmp = dataR[x];
                                dataR[x] = dataR[y];
                                dataR[y] = tmp;
                            }

                            if (dataG[x] > dataG[y])
                            {
                                int tmp = dataG[x];
                                dataG[x] = dataG[y];
                                dataG[y] = tmp;
                            }

                            if (dataB[x] > dataB[y])
                            {
                                int tmp = dataB[x];
                                dataB[x] = dataB[y];
                                dataB[y] = tmp;
                            }
                        }
                    }

                    int medianR = dataR[4], medianG = dataG[4], medianB = dataB[4];
                    Median.SetPixel(i, j, Color.FromArgb(medianR, medianG, medianB));
                }
            }
            
                pcbMedianImage.Image = Median;
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
    }

        private void btnMean_Click(object sender, EventArgs e)
        {
            if (Real != null)
            {
                Mean = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

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
