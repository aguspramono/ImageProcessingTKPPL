namespace ImageProcessing
{
    partial class Enhancement
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
            this.pcbHEImage = new System.Windows.Forms.PictureBox();
            this.pcbCSImage = new System.Windows.Forms.PictureBox();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnHE = new System.Windows.Forms.Button();
            this.btnCSSave = new System.Windows.Forms.Button();
            this.btnHESave = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pcbRealImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHEImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCSImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbHEImage
            // 
            this.pcbHEImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbHEImage.Location = new System.Drawing.Point(318, 12);
            this.pcbHEImage.Name = "pcbHEImage";
            this.pcbHEImage.Size = new System.Drawing.Size(300, 200);
            this.pcbHEImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHEImage.TabIndex = 26;
            this.pcbHEImage.TabStop = false;
            // 
            // pcbCSImage
            // 
            this.pcbCSImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbCSImage.Location = new System.Drawing.Point(624, 12);
            this.pcbCSImage.Name = "pcbCSImage";
            this.pcbCSImage.Size = new System.Drawing.Size(300, 200);
            this.pcbCSImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCSImage.TabIndex = 25;
            this.pcbCSImage.TabStop = false;
            // 
            // btnCS
            // 
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCS.Location = new System.Drawing.Point(624, 218);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(125, 35);
            this.btnCS.TabIndex = 22;
            this.btnCS.Text = "CS";
            this.btnCS.UseVisualStyleBackColor = true;
            // 
            // btnHE
            // 
            this.btnHE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHE.Location = new System.Drawing.Point(318, 218);
            this.btnHE.Name = "btnHE";
            this.btnHE.Size = new System.Drawing.Size(125, 35);
            this.btnHE.TabIndex = 21;
            this.btnHE.Text = "HE";
            this.btnHE.UseVisualStyleBackColor = true;
            this.btnHE.Click += new System.EventHandler(this.btnHE_Click);
            // 
            // btnCSSave
            // 
            this.btnCSSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCSSave.Location = new System.Drawing.Point(755, 218);
            this.btnCSSave.Name = "btnCSSave";
            this.btnCSSave.Size = new System.Drawing.Size(67, 35);
            this.btnCSSave.TabIndex = 23;
            this.btnCSSave.Text = "Save";
            this.btnCSSave.UseVisualStyleBackColor = true;
            // 
            // btnHESave
            // 
            this.btnHESave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHESave.Location = new System.Drawing.Point(449, 218);
            this.btnHESave.Name = "btnHESave";
            this.btnHESave.Size = new System.Drawing.Size(67, 35);
            this.btnHESave.TabIndex = 24;
            this.btnHESave.Text = "Save";
            this.btnHESave.UseVisualStyleBackColor = true;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenImage.Location = new System.Drawing.Point(112, 218);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(101, 35);
            this.btnOpenImage.TabIndex = 19;
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
            this.pcbRealImage.TabIndex = 20;
            this.pcbRealImage.TabStop = false;
            // 
            // Enhancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 265);
            this.Controls.Add(this.pcbHEImage);
            this.Controls.Add(this.pcbCSImage);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnHE);
            this.Controls.Add(this.btnCSSave);
            this.Controls.Add(this.btnHESave);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pcbRealImage);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Enhancement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enhancement";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHEImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCSImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbHEImage;
        private System.Windows.Forms.PictureBox pcbCSImage;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnHE;
        private System.Windows.Forms.Button btnCSSave;
        private System.Windows.Forms.Button btnHESave;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pcbRealImage;
    }
}