namespace ImageProcessing
{
    partial class Noise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbGaussianImage = new System.Windows.Forms.PictureBox();
            this.pcbSpeckleImage = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pcbRealImage = new System.Windows.Forms.PictureBox();
            this.pcbSPImage = new System.Windows.Forms.PictureBox();
            this.btnGaussian = new System.Windows.Forms.Button();
            this.btnSpeckle = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnGaussianSave = new System.Windows.Forms.Button();
            this.btnSpeckleSave = new System.Windows.Forms.Button();
            this.btnSPSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGaussianImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpeckleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSPImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbGaussianImage
            // 
            this.pcbGaussianImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbGaussianImage.Location = new System.Drawing.Point(12, 277);
            this.pcbGaussianImage.Name = "pcbGaussianImage";
            this.pcbGaussianImage.Size = new System.Drawing.Size(300, 200);
            this.pcbGaussianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGaussianImage.TabIndex = 12;
            this.pcbGaussianImage.TabStop = false;
            // 
            // pcbSpeckleImage
            // 
            this.pcbSpeckleImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbSpeckleImage.Location = new System.Drawing.Point(318, 277);
            this.pcbSpeckleImage.Name = "pcbSpeckleImage";
            this.pcbSpeckleImage.Size = new System.Drawing.Size(300, 200);
            this.pcbSpeckleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSpeckleImage.TabIndex = 10;
            this.pcbSpeckleImage.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenImage.Location = new System.Drawing.Point(418, 218);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(101, 35);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "Browse...";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pcbRealImage
            // 
            this.pcbRealImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbRealImage.Location = new System.Drawing.Point(318, 12);
            this.pcbRealImage.Name = "pcbRealImage";
            this.pcbRealImage.Size = new System.Drawing.Size(300, 200);
            this.pcbRealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRealImage.TabIndex = 8;
            this.pcbRealImage.TabStop = false;
            // 
            // pcbSPImage
            // 
            this.pcbSPImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbSPImage.Location = new System.Drawing.Point(624, 277);
            this.pcbSPImage.Name = "pcbSPImage";
            this.pcbSPImage.Size = new System.Drawing.Size(300, 200);
            this.pcbSPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSPImage.TabIndex = 12;
            this.pcbSPImage.TabStop = false;
            // 
            // btnGaussian
            // 
            this.btnGaussian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGaussian.Location = new System.Drawing.Point(12, 483);
            this.btnGaussian.Name = "btnGaussian";
            this.btnGaussian.Size = new System.Drawing.Size(125, 35);
            this.btnGaussian.TabIndex = 1;
            this.btnGaussian.Text = "Gaussian Noise";
            this.btnGaussian.UseVisualStyleBackColor = true;
            this.btnGaussian.Click += new System.EventHandler(this.btnGaussian_Click);
            // 
            // btnSpeckle
            // 
            this.btnSpeckle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpeckle.Location = new System.Drawing.Point(318, 483);
            this.btnSpeckle.Name = "btnSpeckle";
            this.btnSpeckle.Size = new System.Drawing.Size(125, 35);
            this.btnSpeckle.TabIndex = 2;
            this.btnSpeckle.Text = "Speckle Noise";
            this.btnSpeckle.UseVisualStyleBackColor = true;
            this.btnSpeckle.Click += new System.EventHandler(this.btnSpeckle_Click);
            // 
            // btnSP
            // 
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSP.Location = new System.Drawing.Point(624, 483);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(125, 35);
            this.btnSP.TabIndex = 3;
            this.btnSP.Text = "Salt|Pepper Noise";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnGaussianSave
            // 
            this.btnGaussianSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGaussianSave.Location = new System.Drawing.Point(143, 483);
            this.btnGaussianSave.Name = "btnGaussianSave";
            this.btnGaussianSave.Size = new System.Drawing.Size(67, 35);
            this.btnGaussianSave.TabIndex = 4;
            this.btnGaussianSave.Text = "Save";
            this.btnGaussianSave.UseVisualStyleBackColor = true;
            this.btnGaussianSave.Click += new System.EventHandler(this.btnGaussianSave_Click);
            // 
            // btnSpeckleSave
            // 
            this.btnSpeckleSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpeckleSave.Location = new System.Drawing.Point(452, 483);
            this.btnSpeckleSave.Name = "btnSpeckleSave";
            this.btnSpeckleSave.Size = new System.Drawing.Size(67, 35);
            this.btnSpeckleSave.TabIndex = 5;
            this.btnSpeckleSave.Text = "Save";
            this.btnSpeckleSave.UseVisualStyleBackColor = true;
            this.btnSpeckleSave.Click += new System.EventHandler(this.btnSpeckleSave_Click);
            // 
            // btnSPSave
            // 
            this.btnSPSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSPSave.Location = new System.Drawing.Point(755, 483);
            this.btnSPSave.Name = "btnSPSave";
            this.btnSPSave.Size = new System.Drawing.Size(67, 35);
            this.btnSPSave.TabIndex = 6;
            this.btnSPSave.Text = "Save";
            this.btnSPSave.UseVisualStyleBackColor = true;
            this.btnSPSave.Click += new System.EventHandler(this.btnSPSave_Click);
            // 
            // Noise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 530);
            this.Controls.Add(this.pcbSPImage);
            this.Controls.Add(this.pcbGaussianImage);
            this.Controls.Add(this.pcbSpeckleImage);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnSpeckle);
            this.Controls.Add(this.btnGaussian);
            this.Controls.Add(this.btnSPSave);
            this.Controls.Add(this.btnSpeckleSave);
            this.Controls.Add(this.btnGaussianSave);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pcbRealImage);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Noise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Noise";
            ((System.ComponentModel.ISupportInitialize)(this.pcbGaussianImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpeckleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSPImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbGaussianImage;
        private System.Windows.Forms.PictureBox pcbSpeckleImage;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pcbRealImage;
        private System.Windows.Forms.PictureBox pcbSPImage;
        private System.Windows.Forms.Button btnGaussian;
        private System.Windows.Forms.Button btnSpeckle;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnGaussianSave;
        private System.Windows.Forms.Button btnSpeckleSave;
        private System.Windows.Forms.Button btnSPSave;
    }
}