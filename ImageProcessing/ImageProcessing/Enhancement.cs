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
        int R, G, B;
        Color PixelColor;

        public Bitmap HE(Bitmap temp)
        {
            int[] oldfreqR = new int[256];
            int[] oldfreqG = new int[256];
            int[] oldfreqB = new int[256];
            int[] newR = new int[256];
            int[] newG = new int[256];
            int[] newB = new int[256];
            int[] newfreqR = new int[256];
            int[] newfreqG = new int[256];
            int[] newfreqB = new int[256];

            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    PixelColor = temp.GetPixel(i, j);

                    oldfreqR[PixelColor.R]++;
                    oldfreqG[PixelColor.G]++;
                    oldfreqB[PixelColor.B]++;
                }
            }

            int distKumulatifR = 0;
            int distKumulatifG = 0;
            int distKumulatifB = 0;

            for (int i = 0; i < 256; i++)
            {
                if (oldfreqR[i] != 0)
                {
                    distKumulatifR = distKumulatifR + oldfreqR[i];
                    int newColor = (int)Math.Floor(((double)distKumulatifR / (temp.Width * temp.Height)) * 255);
                    newR[i] = newColor;
                }


                if (oldfreqG[i] != 0)
                {
                    distKumulatifG = distKumulatifG + oldfreqG[i];
                    int newColor = (int)Math.Floor(((double)distKumulatifG / (temp.Width * temp.Height)) * 255);
                    newG[i] = newColor;
                }

                if (oldfreqB[i] != 0)
                {
                    distKumulatifB = distKumulatifB + oldfreqB[i];
                    int newColor = (int)Math.Floor(((double)distKumulatifB / (temp.Width * temp.Height)) * 255);
                    newB[i] = newColor;
                }
            }

            Bitmap mod = new Bitmap(temp.Width, temp.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    PixelColor = temp.GetPixel(i, j);
                    R = newR[PixelColor.R];
                    newfreqR[R]++;
                    G = newG[PixelColor.G];
                    newfreqG[G]++;
                    B = newB[PixelColor.B];
                    newfreqB[B]++;

                    PixelColor = Color.FromArgb(R, G, B);
                    mod.SetPixel(i, j, PixelColor);
                }
            }

            return mod;
        }

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

        private void btnHE_Click(object sender, EventArgs e)
        {
            if(Real != null)
                pcbHEImage.Image = HE(Real);
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }
    }
}
