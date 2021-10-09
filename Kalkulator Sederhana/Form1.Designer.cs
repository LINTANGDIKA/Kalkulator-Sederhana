
namespace Kalkulator_Sederhana
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nilai3 = new ns1.BunifuMetroTextbox();
            this.label1 = new ns1.BunifuCustomLabel();
            this.label2 = new ns1.BunifuCustomLabel();
            this.label3 = new ns1.BunifuCustomLabel();
            this.tambah = new ns1.BunifuImageButton();
            this.kurang = new ns1.BunifuImageButton();
            this.kali = new ns1.BunifuImageButton();
            this.bagi = new ns1.BunifuImageButton();
            this.bersih = new ns1.BunifuThinButton2();
            this.nilai2 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.nilai1 = new ns1.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nilai3
            // 
            this.nilai3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nilai3.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.nilai3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nilai3.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.nilai3.BorderThickness = 3;
            this.nilai3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nilai3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilai3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nilai3.isPassword = false;
            this.nilai3.Location = new System.Drawing.Point(222, 353);
            this.nilai3.Margin = new System.Windows.Forms.Padding(5);
            this.nilai3.Name = "nilai3";
            this.nilai3.Size = new System.Drawing.Size(298, 56);
            this.nilai3.TabIndex = 6;
            this.nilai3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nilai 1 :";
            this.label1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nilai 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 56);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hasil :";
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tambah.Image = ((System.Drawing.Image)(resources.GetObject("tambah.Image")));
            this.tambah.ImageActive = null;
            this.tambah.Location = new System.Drawing.Point(30, 476);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(91, 92);
            this.tambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tambah.TabIndex = 10;
            this.tambah.TabStop = false;
            this.tambah.Zoom = 10;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // kurang
            // 
            this.kurang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kurang.Image = ((System.Drawing.Image)(resources.GetObject("kurang.Image")));
            this.kurang.ImageActive = null;
            this.kurang.Location = new System.Drawing.Point(163, 476);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(91, 92);
            this.kurang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kurang.TabIndex = 11;
            this.kurang.TabStop = false;
            this.kurang.Zoom = 10;
            this.kurang.Click += new System.EventHandler(this.kurang_Click);
            // 
            // kali
            // 
            this.kali.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kali.Image = ((System.Drawing.Image)(resources.GetObject("kali.Image")));
            this.kali.ImageActive = null;
            this.kali.Location = new System.Drawing.Point(296, 476);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(91, 92);
            this.kali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kali.TabIndex = 12;
            this.kali.TabStop = false;
            this.kali.Zoom = 10;
            this.kali.Click += new System.EventHandler(this.kali_Click);
            // 
            // bagi
            // 
            this.bagi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bagi.Image = ((System.Drawing.Image)(resources.GetObject("bagi.Image")));
            this.bagi.ImageActive = null;
            this.bagi.Location = new System.Drawing.Point(429, 476);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(91, 92);
            this.bagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bagi.TabIndex = 13;
            this.bagi.TabStop = false;
            this.bagi.Zoom = 10;
            this.bagi.Click += new System.EventHandler(this.bagi_Click);
            // 
            // bersih
            // 
            this.bersih.ActiveBorderThickness = 1;
            this.bersih.ActiveCornerRadius = 20;
            this.bersih.ActiveFillColor = System.Drawing.SystemColors.ControlDark;
            this.bersih.ActiveForecolor = System.Drawing.Color.White;
            this.bersih.ActiveLineColor = System.Drawing.SystemColors.ControlDark;
            this.bersih.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bersih.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bersih.BackgroundImage")));
            this.bersih.ButtonText = "Bersih";
            this.bersih.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bersih.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bersih.ForeColor = System.Drawing.Color.SeaGreen;
            this.bersih.IdleBorderThickness = 1;
            this.bersih.IdleCornerRadius = 20;
            this.bersih.IdleFillColor = System.Drawing.Color.White;
            this.bersih.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.bersih.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.bersih.Location = new System.Drawing.Point(182, 613);
            this.bersih.Margin = new System.Windows.Forms.Padding(8);
            this.bersih.Name = "bersih";
            this.bersih.Size = new System.Drawing.Size(187, 65);
            this.bersih.TabIndex = 14;
            this.bersih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bersih.Click += new System.EventHandler(this.bersih_Click);
            // 
            // nilai2
            // 
            this.nilai2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nilai2.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.nilai2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nilai2.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.nilai2.BorderThickness = 3;
            this.nilai2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nilai2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilai2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nilai2.isPassword = false;
            this.nilai2.Location = new System.Drawing.Point(222, 267);
            this.nilai2.Margin = new System.Windows.Forms.Padding(5);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(298, 56);
            this.nilai2.TabIndex = 15;
            this.nilai2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(192, 45);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(253, 34);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Simple Kalkulator";
            // 
            // nilai1
            // 
            this.nilai1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nilai1.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.nilai1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nilai1.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.nilai1.BorderThickness = 3;
            this.nilai1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nilai1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilai1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nilai1.isPassword = false;
            this.nilai1.Location = new System.Drawing.Point(222, 173);
            this.nilai1.Margin = new System.Windows.Forms.Padding(5);
            this.nilai1.Name = "nilai1";
            this.nilai1.Size = new System.Drawing.Size(298, 56);
            this.nilai1.TabIndex = 19;
            this.nilai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(548, 722);
            this.Controls.Add(this.nilai1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.nilai2);
            this.Controls.Add(this.bersih);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nilai3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMetroTextbox nilai3;
        private ns1.BunifuCustomLabel label1;
        private ns1.BunifuCustomLabel label2;
        private ns1.BunifuCustomLabel label3;
        private ns1.BunifuImageButton tambah;
        private ns1.BunifuImageButton kurang;
        private ns1.BunifuImageButton kali;
        private ns1.BunifuImageButton bagi;
        private ns1.BunifuThinButton2 bersih;
        private ns1.BunifuMetroTextbox nilai2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMetroTextbox nilai1;
    }
}

