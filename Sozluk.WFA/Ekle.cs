using Sozluk.BLL.Repository;
using Sozluk.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozluk.WFA
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            IslemSecim islemSecim = new IslemSecim();
            islemSecim.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new KelimeRepo().Insert(new Kelime()
                {
                    Sozcuk = txtKelime.Text,
                    SozcukAnlami = txtAnlam.Text,
                    ResimYolu = Yer,
                    KullaniciId=7
                });
                MessageBox.Show("Kayıt İşlemi Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Başarısız");
            }
            FormuTemizle();
            
        }

        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtSearch")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is NumericUpDown nu)
                    nu.Value = 0;
                Yer = "";
            }
        }

        string Yer = "";
        string DosyaYolu = "";

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
                dosya.Title = "Bilişim Terimleri Sözlüğü";
                dosya.ShowDialog();
                DosyaYolu = dosya.FileName;
                Yer = Application.StartupPath.ToString() + "\\Resimler\\" + r.Next(1, 1000) + ".jpg";
                File.Copy(DosyaYolu, Yer);
            }
            catch (Exception)
            {
                Random r = new Random();
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
                dosya.Title = "Bilişim Terimleri Sözlüğü";
                dosya.ShowDialog();
                DosyaYolu = dosya.FileName;
                Yer = Application.StartupPath.ToString() + (r.Next(1, 1000) - 1).ToString() + "asd.jpg";
                File.Copy(DosyaYolu, Yer);
                MessageBox.Show(Yer);
            }
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (a == DialogResult.No)
            {

            }
        }
    }
}
