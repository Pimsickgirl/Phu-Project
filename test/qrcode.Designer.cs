namespace test
{
    partial class qrcodemain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qrcodemain));
            this.GenerateQRcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QRcodeBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateQRcode
            // 
            this.GenerateQRcode.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateQRcode.Location = new System.Drawing.Point(215, 445);
            this.GenerateQRcode.Name = "GenerateQRcode";
            this.GenerateQRcode.Size = new System.Drawing.Size(160, 43);
            this.GenerateQRcode.TabIndex = 0;
            this.GenerateQRcode.Text = "Generate QRCode";
            this.GenerateQRcode.UseVisualStyleBackColor = true;
            this.GenerateQRcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate QR Code";
            // 
            // QRcodeBox
            // 
            this.QRcodeBox.Location = new System.Drawing.Point(24, 46);
            this.QRcodeBox.Name = "QRcodeBox";
            this.QRcodeBox.Size = new System.Drawing.Size(535, 352);
            this.QRcodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRcodeBox.TabIndex = 2;
            this.QRcodeBox.TabStop = false;
            this.QRcodeBox.Click += new System.EventHandler(this.QrCode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(46, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "พิมพ์เพื่อ Generate Qrcode";
            // 
            // qrcodemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 507);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QRcodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateQRcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "qrcodemain";
            this.Text = "Generate QR Code ";
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateQRcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox QRcodeBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}