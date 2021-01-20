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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudR1 = new System.Windows.Forms.NumericUpDown();
            this.nudS1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudR2 = new System.Windows.Forms.NumericUpDown();
            this.nudS2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHEImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCSImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS2)).BeginInit();
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
            this.btnCS.Location = new System.Drawing.Point(623, 218);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(47, 35);
            this.btnCS.TabIndex = 6;
            this.btnCS.Text = "CS";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnHE
            // 
            this.btnHE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHE.Location = new System.Drawing.Point(318, 218);
            this.btnHE.Name = "btnHE";
            this.btnHE.Size = new System.Drawing.Size(47, 35);
            this.btnHE.TabIndex = 1;
            this.btnHE.Text = "HE";
            this.btnHE.UseVisualStyleBackColor = true;
            this.btnHE.Click += new System.EventHandler(this.btnHE_Click);
            // 
            // btnCSSave
            // 
            this.btnCSSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCSSave.Location = new System.Drawing.Point(857, 218);
            this.btnCSSave.Name = "btnCSSave";
            this.btnCSSave.Size = new System.Drawing.Size(67, 35);
            this.btnCSSave.TabIndex = 8;
            this.btnCSSave.Text = "Save";
            this.btnCSSave.UseVisualStyleBackColor = true;
            this.btnCSSave.Click += new System.EventHandler(this.btnCSSave_Click);
            // 
            // btnHESave
            // 
            this.btnHESave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHESave.Location = new System.Drawing.Point(371, 218);
            this.btnHESave.Name = "btnHESave";
            this.btnHESave.Size = new System.Drawing.Size(67, 35);
            this.btnHESave.TabIndex = 7;
            this.btnHESave.Text = "Save";
            this.btnHESave.UseVisualStyleBackColor = true;
            this.btnHESave.Click += new System.EventHandler(this.btnHESave_Click);
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
            this.pcbRealImage.TabIndex = 20;
            this.pcbRealImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "r1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "s1 :";
            // 
            // nudR1
            // 
            this.nudR1.Location = new System.Drawing.Point(711, 218);
            this.nudR1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR1.Name = "nudR1";
            this.nudR1.Size = new System.Drawing.Size(46, 23);
            this.nudR1.TabIndex = 2;
            // 
            // nudS1
            // 
            this.nudS1.Location = new System.Drawing.Point(711, 247);
            this.nudS1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudS1.Name = "nudS1";
            this.nudS1.Size = new System.Drawing.Size(46, 23);
            this.nudS1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "r2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "s2 :";
            // 
            // nudR2
            // 
            this.nudR2.Location = new System.Drawing.Point(797, 218);
            this.nudR2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR2.Name = "nudR2";
            this.nudR2.Size = new System.Drawing.Size(46, 23);
            this.nudR2.TabIndex = 4;
            // 
            // nudS2
            // 
            this.nudS2.Location = new System.Drawing.Point(797, 247);
            this.nudS2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudS2.Name = "nudS2";
            this.nudS2.Size = new System.Drawing.Size(46, 23);
            this.nudS2.TabIndex = 5;
            // 
            // Enhancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 281);
            this.Controls.Add(this.nudS2);
            this.Controls.Add(this.nudS1);
            this.Controls.Add(this.nudR2);
            this.Controls.Add(this.nudR1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
            this.Text = "Image Enhancement";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHEImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCSImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRealImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudR1;
        private System.Windows.Forms.NumericUpDown nudS1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudR2;
        private System.Windows.Forms.NumericUpDown nudS2;
    }
}