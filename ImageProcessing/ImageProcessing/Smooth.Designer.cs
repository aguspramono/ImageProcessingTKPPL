namespace ImageProcessing
{
    partial class Smooth
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
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pcbRealImage = new System.Windows.Forms.PictureBox();
            this.pcbMeanImage = new System.Windows.Forms.PictureBox();
            this.pcbMedianImage = new System.Windows.Forms.PictureBox();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnMedianSave = new System.Windows.Forms.Button();
            this.btnMeanSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMeanImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMedianImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenImage.Location = new System.Drawing.Point(112, 218);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(101, 35);
            this.btnOpenImage.TabIndex = 9;
            this.btnOpenImage.Text = "Browse...";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pcbRealImage
            // 
            this.pcbRealImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbRealImage.Location = new System.Drawing.Point(12, 12);
            this.pcbRealImage.Name = "pcbRealImage";
            this.pcbRealImage.Size = new System.Drawing.Size(300, 200);
            this.pcbRealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRealImage.TabIndex = 10;
            this.pcbRealImage.TabStop = false;
            // 
            // pcbMeanImage
            // 
            this.pcbMeanImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbMeanImage.Location = new System.Drawing.Point(318, 12);
            this.pcbMeanImage.Name = "pcbMeanImage";
            this.pcbMeanImage.Size = new System.Drawing.Size(300, 200);
            this.pcbMeanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMeanImage.TabIndex = 18;
            this.pcbMeanImage.TabStop = false;
            // 
            // pcbMedianImage
            // 
            this.pcbMedianImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbMedianImage.Location = new System.Drawing.Point(624, 12);
            this.pcbMedianImage.Name = "pcbMedianImage";
            this.pcbMedianImage.Size = new System.Drawing.Size(300, 200);
            this.pcbMedianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMedianImage.TabIndex = 17;
            this.pcbMedianImage.TabStop = false;
            // 
            // btnMedian
            // 
            this.btnMedian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedian.Location = new System.Drawing.Point(624, 218);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(125, 35);
            this.btnMedian.TabIndex = 14;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnMean
            // 
            this.btnMean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMean.Location = new System.Drawing.Point(318, 218);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(125, 35);
            this.btnMean.TabIndex = 13;
            this.btnMean.Text = "Mean Filter";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnMedianSave
            // 
            this.btnMedianSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedianSave.Location = new System.Drawing.Point(755, 218);
            this.btnMedianSave.Name = "btnMedianSave";
            this.btnMedianSave.Size = new System.Drawing.Size(67, 35);
            this.btnMedianSave.TabIndex = 15;
            this.btnMedianSave.Text = "Save";
            this.btnMedianSave.UseVisualStyleBackColor = true;
            // 
            // btnMeanSave
            // 
            this.btnMeanSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeanSave.Location = new System.Drawing.Point(449, 218);
            this.btnMeanSave.Name = "btnMeanSave";
            this.btnMeanSave.Size = new System.Drawing.Size(67, 35);
            this.btnMeanSave.TabIndex = 16;
            this.btnMeanSave.Text = "Save";
            this.btnMeanSave.UseVisualStyleBackColor = true;
            // 
            // Smooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 265);
            this.Controls.Add(this.pcbMeanImage);
            this.Controls.Add(this.pcbMedianImage);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.btnMedianSave);
            this.Controls.Add(this.btnMeanSave);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pcbRealImage);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Smooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Smoothing";
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMeanImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMedianImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pcbRealImage;
        private System.Windows.Forms.PictureBox pcbMeanImage;
        private System.Windows.Forms.PictureBox pcbMedianImage;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnMedianSave;
        private System.Windows.Forms.Button btnMeanSave;
    }
}