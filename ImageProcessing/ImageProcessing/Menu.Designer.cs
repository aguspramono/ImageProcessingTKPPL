namespace ImageProcessing
{
    partial class Menu
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
            this.btnNoise = new System.Windows.Forms.Button();
            this.btnSmoothing = new System.Windows.Forms.Button();
            this.btnEnhancement = new System.Windows.Forms.Button();
            this.btnPreprocessing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoise
            // 
            this.btnNoise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoise.Location = new System.Drawing.Point(199, 12);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(181, 35);
            this.btnNoise.TabIndex = 1;
            this.btnNoise.Text = "Image Noise";
            this.btnNoise.UseVisualStyleBackColor = true;
            this.btnNoise.Click += new System.EventHandler(this.btnNoise_Click);
            // 
            // btnSmoothing
            // 
            this.btnSmoothing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmoothing.Location = new System.Drawing.Point(12, 53);
            this.btnSmoothing.Name = "btnSmoothing";
            this.btnSmoothing.Size = new System.Drawing.Size(181, 35);
            this.btnSmoothing.TabIndex = 2;
            this.btnSmoothing.Text = "Image Smoothing";
            this.btnSmoothing.UseVisualStyleBackColor = true;
            this.btnSmoothing.Click += new System.EventHandler(this.btnSmoothing_Click);
            // 
            // btnEnhancement
            // 
            this.btnEnhancement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnhancement.Location = new System.Drawing.Point(199, 53);
            this.btnEnhancement.Name = "btnEnhancement";
            this.btnEnhancement.Size = new System.Drawing.Size(181, 35);
            this.btnEnhancement.TabIndex = 3;
            this.btnEnhancement.Text = "Image Enhancement";
            this.btnEnhancement.UseVisualStyleBackColor = true;
            this.btnEnhancement.Click += new System.EventHandler(this.btnEnhancement_Click);
            // 
            // btnPreprocessing
            // 
            this.btnPreprocessing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreprocessing.Location = new System.Drawing.Point(12, 12);
            this.btnPreprocessing.Name = "btnPreprocessing";
            this.btnPreprocessing.Size = new System.Drawing.Size(181, 35);
            this.btnPreprocessing.TabIndex = 0;
            this.btnPreprocessing.Text = "Image Preprocessing";
            this.btnPreprocessing.UseVisualStyleBackColor = true;
            this.btnPreprocessing.Click += new System.EventHandler(this.btnPreprocessing_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(392, 100);
            this.Controls.Add(this.btnEnhancement);
            this.Controls.Add(this.btnSmoothing);
            this.Controls.Add(this.btnPreprocessing);
            this.Controls.Add(this.btnNoise);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageProcessing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Button btnSmoothing;
        private System.Windows.Forms.Button btnEnhancement;
        private System.Windows.Forms.Button btnPreprocessing;
    }
}

