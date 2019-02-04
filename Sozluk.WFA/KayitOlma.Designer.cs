namespace Sozluk.WFA
{
    partial class KayitOlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOlma));
            this.btnGeri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCikis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.LightGreen;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Location = new System.Drawing.Point(85, 417);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(174, 41);
            this.btnGeri.TabIndex = 43;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(106, 61);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Lime;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitOl.Location = new System.Drawing.Point(86, 368);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(173, 41);
            this.btnKayitOl.TabIndex = 41;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtCevap
            // 
            this.txtCevap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCevap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCevap.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCevap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCevap.Location = new System.Drawing.Point(84, 335);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(4);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(195, 19);
            this.txtCevap.TabIndex = 40;
            this.txtCevap.Text = "En Sevdiğiniz Hayvan?";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogumTarihi.Location = new System.Drawing.Point(84, 303);
            this.dtDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(173, 25);
            this.dtDogumTarihi.TabIndex = 39;
            // 
            // txtMeslek
            // 
            this.txtMeslek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMeslek.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeslek.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMeslek.Location = new System.Drawing.Point(84, 270);
            this.txtMeslek.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(173, 19);
            this.txtMeslek.TabIndex = 38;
            this.txtMeslek.Text = "Meslek";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSoyad.Location = new System.Drawing.Point(85, 235);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(172, 19);
            this.txtSoyad.TabIndex = 37;
            this.txtSoyad.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAd.Location = new System.Drawing.Point(86, 198);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 19);
            this.txtAd.TabIndex = 36;
            this.txtAd.Text = "Ad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(301, 9);
            this.lblCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(17, 17);
            this.lblCikis.TabIndex = 44;
            this.lblCikis.Text = "X";
            // 
            // KayitOlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(323, 466);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.txtMeslek);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitOlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitOlma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCikis;
    }
}