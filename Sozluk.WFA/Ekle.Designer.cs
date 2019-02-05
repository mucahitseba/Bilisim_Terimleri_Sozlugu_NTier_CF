namespace Sozluk.WFA
{
    partial class Ekle
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
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnlam = new System.Windows.Forms.TextBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(291, 9);
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
            this.btnGeri.Location = new System.Drawing.Point(74, 320);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(207, 46);
            this.btnGeri.TabIndex = 36;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(74, 273);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(208, 41);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResimSec.Location = new System.Drawing.Point(79, 215);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(115, 34);
            this.btnResimSec.TabIndex = 34;
            this.btnResimSec.Text = "Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Resim:";
            // 
            // txtAnlam
            // 
            this.txtAnlam.Location = new System.Drawing.Point(78, 76);
            this.txtAnlam.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnlam.Multiline = true;
            this.txtAnlam.Name = "txtAnlam";
            this.txtAnlam.Size = new System.Drawing.Size(204, 123);
            this.txtAnlam.TabIndex = 32;
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(78, 38);
            this.txtKelime.Margin = new System.Windows.Forms.Padding(4);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(204, 22);
            this.txtKelime.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Anlamı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kelime:";
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(323, 375);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnlam);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnlam;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}