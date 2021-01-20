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
        SaveFileDialog saveImage = new SaveFileDialog();
        Bitmap Real, pctHE, pctCS;
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

        private void btnCS_Click(object sender, EventArgs e)
        {
            if (Real != null)
            {
                int r1 = (int)nudR1.Value, s1 = (int)nudS1.Value, r2 = (int)nudR2.Value, s2 = (int)nudS2.Value;

                if(r1 <= r2 && s1 <= s2)
                {
                    pctCS = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    for (int i = 0; i < Real.Width; i++)
                    {
                        for (int j = 0; j < Real.Height; j++)
                        {
                            int r, g, b;

                            PixelColor = Real.GetPixel(i, j);

                            if (PixelColor.R < r1)
                                r = PixelColor.R * (int)Math.Round((double)(s1 / r1));
                            else if (PixelColor.R < r2)
                                r = s1 + ((PixelColor.R - r1) * (int)Math.Round((double)((s2 - s1) / (r2 - r1))));
                            else
                                r = s2 + ((PixelColor.R - r2) * (int)Math.Round((double)((255 - s2) / (255 - r2))));

                            if (PixelColor.G < r1)
                                g = PixelColor.G * (int)Math.Round((double)(s1 / r1));
                            else if (PixelColor.G < r2)
                                g = s1 + ((PixelColor.G - r1) * (int)Math.Round((double)((s2 - s1) / (r2 - r1))));
                            else
                                g = s2 + ((PixelColor.G - r2) * (int)Math.Round((double)((255 - s2) / (255 - r2))));

                            if (PixelColor.B < r1)
                                b = PixelColor.B * (int)Math.Round((double)(s1 / r1));
                            else if (PixelColor.B < r2)
                                b = s1 + ((PixelColor.B - r1) * (int)Math.Round((double)((s2 - s1) / (r2 - r1))));
                            else
                                b = s2 + ((PixelColor.B - r2) * (int)Math.Round((double)((255 - s2) / (255 - r2))));

                            pctCS.SetPixel(i, j, Color.FromArgb(r, g, b));
                        }
                    }

                    pcbCSImage.Image = pctCS;
                }
                else
                    MessageBox.Show("Note : r1 <= r2 & s1 <= s2");
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnCSSave_Click(object sender, EventArgs e)
        {
            if (pctCS != null)
            {
                String pathFile = null;
                saveImage.Filter = "Bitmap (*.bmp) | *.bmp|Portable Network Graphics (*.png) | *.png|Joint Photographic Expert Group (*.jpeg) | *.jpeg";
                DialogResult result = saveImage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathFile = saveImage.FileName;
                    if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "bmp")
                        pctCS.Save(pathFile, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "png")
                        pctCS.Save(pathFile, System.Drawing.Imaging.ImageFormat.Png);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "jpeg")
                        pctCS.Save(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Gambar berhasil disimpan");
                }
            }
            else
                MessageBox.Show("Tidak ada gambar yang bisa disimpan");
        }

        private void btnHESave_Click(object sender, EventArgs e)
        {
            if (pctHE != null)
            {
                String pathFile = null;
                saveImage.Filter = "Bitmap (*.bmp) | *.bmp|Portable Network Graphics (*.png) | *.png|Joint Photographic Expert Group (*.jpeg) | *.jpeg";
                DialogResult result = saveImage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathFile = saveImage.FileName;
                    if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "bmp")
                        pctHE.Save(pathFile, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "png")
                        pctHE.Save(pathFile, System.Drawing.Imaging.ImageFormat.Png);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "jpeg")
                        pctHE.Save(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Gambar berhasil disimpan");
                }
            }
            else
                MessageBox.Show("Tidak ada gambar yang bisa disimpan");
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
            {
                pctHE = HE(Real);
                pcbHEImage.Image = pctHE;
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }
    }
}
