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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            Noise noiseForm = new Noise();

            noiseForm.ShowDialog();
        }

        private void btnSmoothing_Click(object sender, EventArgs e)
        {
            Smooth smoothForm = new Smooth();

            smoothForm.ShowDialog();
        }

        private void btnEnhancement_Click(object sender, EventArgs e)
        {
            Enhancement enhancementForm = new Enhancement();

            enhancementForm.ShowDialog();
        }
    }
}
