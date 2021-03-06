﻿using System;
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
    public partial class Noise : Form
    {
        OpenFileDialog openImage = new OpenFileDialog();
        SaveFileDialog saveImage = new SaveFileDialog();
        Bitmap Real, Gaussian, Speckle, SP;
        int R, G, B;
        Color PixelColor;

        public Noise()
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

        private void btnGaussian_Click(object sender, EventArgs e)
        {
            if (Real != null)
            {
                Gaussian = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Random rand = new Random();

                for (int i = 0; i < Real.Width; i++)
                {
                    for (int j = 0; j < Real.Height; j++)
                    {
                        PixelColor = Real.GetPixel(i, j);

                        int p = rand.Next(0, 100);
                        Color noise = PixelColor;

                        if (p < 20)
                        {
                            int c = rand.Next(0, 256) - 128;
                            int r = PixelColor.R + c;
                            int g = PixelColor.G + c;
                            int b = PixelColor.B + c;

                            if (r < 0)
                                r = 0;
                            if (r > 255)
                                r = 255;
                            if (g < 0)
                                g = 0;
                            if (g > 255)
                                g = 255;
                            if (b < 0)
                                b = 0;
                            if (b > 255)
                                b = 255;

                            noise = Color.FromArgb(r, g, b);
                        }

                        Gaussian.SetPixel(i, j, noise);
                    }
                }

                pcbGaussianImage.Image = Gaussian;
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnSpeckle_Click(object sender, EventArgs e)
        {

            if (Real != null)
            {
                Speckle = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Random rand = new Random();

                for (int i = 0; i < Real.Width; i++)
                {
                    for (int j = 0; j < Real.Height; j++)
                    {
                        PixelColor = Real.GetPixel(i, j);

                        int p = rand.Next(0, 100);
                        Color noise = PixelColor;

                        if (p < 20)
                        {
                            int r = 0;
                            int g = 0;
                            int b = 0;

                            noise = Color.FromArgb(r, g, b);
                        }

                        Speckle.SetPixel(i, j, noise);
                    }
                }

                pcbSpeckleImage.Image = Speckle;
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnSP_Click(object sender, EventArgs e)
        {

            if (Real != null)
            {
                SP = new Bitmap(Real.Width, Real.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Random rand = new Random();

                for (int i = 0; i < Real.Width; i++)
                {
                    for (int j = 0; j < Real.Height; j++)
                    {
                        PixelColor = Real.GetPixel(i, j);

                        int p = rand.Next(0, 100);
                        Color noise = PixelColor;

                        if (p < 20)
                        {
                            int r = 255;
                            int g = 255;
                            int b = 255;

                            noise = Color.FromArgb(r, g, b);
                        }

                        SP.SetPixel(i, j, noise);
                    }
                }

                pcbSPImage.Image = SP;
            }
            else
                MessageBox.Show("Masukkan citra yang akan diolah");
        }

        private void btnGaussianSave_Click(object sender, EventArgs e)
        {
            if (Gaussian != null)
            {
                String pathFile = null;
                saveImage.Filter = "Bitmap (*.bmp) | *.bmp|Portable Network Graphics (*.png) | *.png|Joint Photographic Expert Group (*.jpeg) | *.jpeg";
                DialogResult result = saveImage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathFile = saveImage.FileName;
                    if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "bmp")
                        Gaussian.Save(pathFile, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "png")
                        Gaussian.Save(pathFile, System.Drawing.Imaging.ImageFormat.Png);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "jpeg")
                        Gaussian.Save(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Gambar berhasil disimpan");
                }
            }
            else
                MessageBox.Show("Tidak ada gambar yang bisa disimpan");
        }

        private void btnSpeckleSave_Click(object sender, EventArgs e)
        {
            if (Speckle != null)
            {
                String pathFile = null;
                saveImage.Filter = "Bitmap (*.bmp) | *.bmp|Portable Network Graphics (*.png) | *.png|Joint Photographic Expert Group (*.jpeg) | *.jpeg";
                DialogResult result = saveImage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathFile = saveImage.FileName;
                    if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "bmp")
                        Speckle.Save(pathFile, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "png")
                        Speckle.Save(pathFile, System.Drawing.Imaging.ImageFormat.Png);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "jpeg")
                        Speckle.Save(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Gambar berhasil disimpan");
                }
            }
            else
                MessageBox.Show("Tidak ada gambar yang bisa disimpan");
        }

        private void btnSPSave_Click(object sender, EventArgs e)
        {
            if (SP != null)
            {
                String pathFile = null;
                saveImage.Filter = "Bitmap (*.bmp) | *.bmp|Portable Network Graphics (*.png) | *.png|Joint Photographic Expert Group (*.jpeg) | *.jpeg";
                DialogResult result = saveImage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pathFile = saveImage.FileName;
                    if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "bmp")
                        SP.Save(pathFile, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "png")
                        SP.Save(pathFile, System.Drawing.Imaging.ImageFormat.Png);
                    else if (pathFile.Substring(pathFile.LastIndexOf(".") + 1) == "jpeg")
                        SP.Save(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Gambar berhasil disimpan");
                }
            }
            else
                MessageBox.Show("Tidak ada gambar yang bisa disimpan");
        }
    }
}
