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
    public partial class Preprocessing : Form
    {
        OpenFileDialog openImage = new OpenFileDialog();
        SaveFileDialog saveImage = new SaveFileDialog();
        Bitmap Real, Temp, Modify;
        int R, G, B;
        Color PixelColor;

        public Preprocessing()
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
                Modify = new Bitmap(pathFile);
                pcbRealImage.Image = Real;

                Temp = Real;
            }
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                Modify.Dispose();
                Modify = new Bitmap(Temp.Width, Temp.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                for (int i = 0; i < Temp.Width; i++)
                {
                    for (int j = 0; j < Temp.Height; j++)
                    {
                        PixelColor = Temp.GetPixel(i, j);
                        R = PixelColor.R + ((255 - PixelColor.R) * 15 / 100);
                        G = PixelColor.G + ((255 - PixelColor.G) * 15 / 100);
                        B = PixelColor.B + ((255 - PixelColor.B) * 15 / 100);

                        PixelColor = Color.FromArgb(R, G, B);
                        Modify.SetPixel(i, j, PixelColor);
                    }
                }

                Temp = new Bitmap(Modify);
                pcbModifiedImage.Image = Temp;

                MessageBox.Show("Increase Brightness Completed");
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                Modify.Dispose();
                Modify = new Bitmap(Temp.Width, Temp.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                for (int i = 0; i < Temp.Width; i++)
                {
                    for (int j = 0; j < Temp.Height; j++)
                    {
                        PixelColor = Temp.GetPixel(i, j);
                        R = PixelColor.R - (PixelColor.R * 15 / 100);
                        G = PixelColor.G - (PixelColor.G * 15 / 100);
                        B = PixelColor.B - (PixelColor.B * 15 / 100);

                        PixelColor = Color.FromArgb(R, G, B);
                        Modify.SetPixel(i, j, PixelColor);
                    }
                }
                Temp = new Bitmap(Modify);
                pcbModifiedImage.Image = Temp;

                MessageBox.Show("Decrease Brightness Completed");
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (Temp != null)
            {
                Modify = new Bitmap(Temp.Width, Temp.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                for (int i = 0; i < Temp.Width; i++)
                {
                    for (int j = 0; j < Temp.Height; j++)
                    {
                        PixelColor = Temp.GetPixel(i, j);
                        int average = (int)((PixelColor.R + PixelColor.G + PixelColor.B) / 3);

                        PixelColor = Color.FromArgb(average, average, average);
                        Modify.SetPixel(i, j, PixelColor);
                    }
                }

                Temp = new Bitmap(Modify);
                pcbModifiedImage.Image = Temp;

                MessageBox.Show("Converted to Grayscale");
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            if(Temp != null)
            { 
                Temp = Real;
                pcbModifiedImage.Image = new Bitmap(Real);
                MessageBox.Show("Restored to Original Image");
            }
            else
                MessageBox.Show("Belum ada citra");
        }
    }
}
