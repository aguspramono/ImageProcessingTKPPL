namespace ImageProcessing
{
    partial class Preprocessing
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
            this.pcbModifiedImage = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pcbRealImage = new System.Windows.Forms.PictureBox();
            this.btnModifiedSave = new System.Windows.Forms.Button();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnVerticalMirror = new System.Windows.Forms.Button();
            this.btnHorizontalMirror = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModifiedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).BeginInit();
            this.grbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbModifiedImage
            // 
            this.pcbModifiedImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbModifiedImage.Location = new System.Drawing.Point(318, 12);
            this.pcbModifiedImage.Name = "pcbModifiedImage";
            this.pcbModifiedImage.Size = new System.Drawing.Size(300, 200);
            this.pcbModifiedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbModifiedImage.TabIndex = 29;
            this.pcbModifiedImage.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenImage.Location = new System.Drawing.Point(112, 218);
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
            this.pcbRealImage.Location = new System.Drawing.Point(12, 12);
            this.pcbRealImage.Name = "pcbRealImage";
            this.pcbRealImage.Size = new System.Drawing.Size(300, 200);
            this.pcbRealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRealImage.TabIndex = 28;
            this.pcbRealImage.TabStop = false;
            // 
            // btnModifiedSave
            // 
            this.btnModifiedSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifiedSave.Location = new System.Drawing.Point(435, 218);
            this.btnModifiedSave.Name = "btnModifiedSave";
            this.btnModifiedSave.Size = new System.Drawing.Size(67, 35);
            this.btnModifiedSave.TabIndex = 1;
            this.btnModifiedSave.Text = "Save";
            this.btnModifiedSave.UseVisualStyleBackColor = true;
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnRotateLeft);
            this.grbControl.Controls.Add(this.btnRotateRight);
            this.grbControl.Controls.Add(this.btnVerticalMirror);
            this.grbControl.Controls.Add(this.btnHorizontalMirror);
            this.grbControl.Controls.Add(this.btnOriginal);
            this.grbControl.Controls.Add(this.btnGrayscale);
            this.grbControl.Controls.Add(this.btnDarken);
            this.grbControl.Controls.Add(this.btnLighten);
            this.grbControl.Location = new System.Drawing.Point(12, 259);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(605, 104);
            this.grbControl.TabIndex = 31;
            this.grbControl.TabStop = false;
            this.grbControl.Text = "Tools Box";
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotateLeft.Location = new System.Drawing.Point(155, 22);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(143, 35);
            this.btnRotateLeft.TabIndex = 3;
            this.btnRotateLeft.Text = "Rotate -90°";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotateRight.Location = new System.Drawing.Point(6, 22);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(143, 35);
            this.btnRotateRight.TabIndex = 2;
            this.btnRotateRight.Text = "Rotate 90°";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            // 
            // btnVerticalMirror
            // 
            this.btnVerticalMirror.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerticalMirror.Location = new System.Drawing.Point(453, 22);
            this.btnVerticalMirror.Name = "btnVerticalMirror";
            this.btnVerticalMirror.Size = new System.Drawing.Size(143, 35);
            this.btnVerticalMirror.TabIndex = 5;
            this.btnVerticalMirror.Text = "Vertical Mirror";
            this.btnVerticalMirror.UseVisualStyleBackColor = true;
            // 
            // btnHorizontalMirror
            // 
            this.btnHorizontalMirror.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHorizontalMirror.Location = new System.Drawing.Point(304, 22);
            this.btnHorizontalMirror.Name = "btnHorizontalMirror";
            this.btnHorizontalMirror.Size = new System.Drawing.Size(143, 35);
            this.btnHorizontalMirror.TabIndex = 4;
            this.btnHorizontalMirror.Text = "Horizontal Mirror";
            this.btnHorizontalMirror.UseVisualStyleBackColor = true;
            // 
            // btnOriginal
            // 
            this.btnOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOriginal.Location = new System.Drawing.Point(453, 63);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(143, 35);
            this.btnOriginal.TabIndex = 9;
            this.btnOriginal.Text = "Restore Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrayscale.Location = new System.Drawing.Point(304, 63);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(143, 35);
            this.btnGrayscale.TabIndex = 8;
            this.btnGrayscale.Text = "Convert to Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDarken.Location = new System.Drawing.Point(155, 63);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(143, 35);
            this.btnDarken.TabIndex = 7;
            this.btnDarken.Text = "Decrease Brightness";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLighten.Location = new System.Drawing.Point(6, 63);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(143, 35);
            this.btnLighten.TabIndex = 6;
            this.btnLighten.Text = "Increase Brightness";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // Preprocessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 375);
            this.Controls.Add(this.grbControl);
            this.Controls.Add(this.btnModifiedSave);
            this.Controls.Add(this.pcbModifiedImage);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pcbRealImage);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Preprocessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Preprocessing";
            ((System.ComponentModel.ISupportInitialize)(this.pcbModifiedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).EndInit();
            this.grbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbModifiedImage;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pcbRealImage;
        private System.Windows.Forms.Button btnModifiedSave;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnVerticalMirror;
        private System.Windows.Forms.Button btnHorizontalMirror;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnLighten;
    }
}