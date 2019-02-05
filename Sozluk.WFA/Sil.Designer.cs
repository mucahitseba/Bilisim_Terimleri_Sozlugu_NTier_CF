namespace Sozluk.WFA
{
    partial class Sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sil));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtAnlam = new System.Windows.Forms.TextBox();
            this.txtSozcuk = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstKelimeler = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbResim);
            this.groupBox3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(494, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(295, 303);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "                  Resim                    ";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(19, 58);
            this.pbResim.Margin = new System.Windows.Forms.Padding(4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(261, 207);
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(275, 240);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(211, 44);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(784, 8);
            this.lblCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(17, 17);
            this.lblCikis.TabIndex = 37;
            this.lblCikis.Text = "X";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Location = new System.Drawing.Point(275, 288);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(211, 44);
            this.btnGeri.TabIndex = 35;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtAnlam
            // 
            this.txtAnlam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAnlam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnlam.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnlam.ForeColor = System.Drawing.Color.White;
            this.txtAnlam.Location = new System.Drawing.Point(275, 66);
            this.txtAnlam.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnlam.Multiline = true;
            this.txtAnlam.Name = "txtAnlam";
            this.txtAnlam.Size = new System.Drawing.Size(211, 166);
            this.txtAnlam.TabIndex = 33;
            this.txtAnlam.Text = "Kelime Anlamı";
            this.txtAnlam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSozcuk
            // 
            this.txtSozcuk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSozcuk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSozcuk.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSozcuk.ForeColor = System.Drawing.Color.White;
            this.txtSozcuk.Location = new System.Drawing.Point(275, 29);
            this.txtSozcuk.Margin = new System.Windows.Forms.Padding(4);
            this.txtSozcuk.Multiline = true;
            this.txtSozcuk.Name = "txtSozcuk";
            this.txtSozcuk.Size = new System.Drawing.Size(211, 30);
            this.txtSozcuk.TabIndex = 32;
            this.txtSozcuk.Text = "Kelime Adı";
            this.txtSozcuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAra.Location = new System.Drawing.Point(55, 29);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(211, 30);
            this.txtAra.TabIndex = 30;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // lstKelimeler
            // 
            this.lstKelimeler.FormattingEnabled = true;
            this.lstKelimeler.ItemHeight = 16;
            this.lstKelimeler.Location = new System.Drawing.Point(10, 66);
            this.lstKelimeler.Name = "lstKelimeler";
            this.lstKelimeler.Size = new System.Drawing.Size(258, 260);
            this.lstKelimeler.TabIndex = 40;
            this.lstKelimeler.SelectedIndexChanged += new System.EventHandler(this.lstKelimeler_SelectedIndexChanged);
            // 
            // Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(811, 340);
            this.Controls.Add(this.lstKelimeler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtAnlam);
            this.Controls.Add(this.txtSozcuk);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sil";
            this.Load += new System.EventHandler(this.Sil_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtAnlam;
        private System.Windows.Forms.TextBox txtSozcuk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstKelimeler;
    }
}