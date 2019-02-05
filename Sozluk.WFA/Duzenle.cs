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
    public partial class Duzenle : Form
    {
        public Duzenle()
        {
            InitializeComponent();
        }

        private void Duzenle_Load(object sender, EventArgs e)
        {
            KelimeleriGetir();
        }
        private void KelimeleriGetir()
        {
            lstKelimeler.DataSource = new KelimeRepo().GetAll().ToList();
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            IslemSecim islemSecim = new IslemSecim();
            islemSecim.Show();
            this.Hide();
        }
        

        private void lstKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var kelime = lstKelimeler.SelectedItem as Kelime;
            txtSozcuk.Text = kelime.Sozcuk;
            txtAnlam.Text = new KelimeRepo().GetById(kelime.KelimeId).SozcukAnlami.ToString();
            pbResim.Image = Image.FromFile(new KelimeRepo().GetById(kelime.KelimeId).ResimYolu);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        string DosyaYolu;
        string Yer;
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
        Kelime kelime;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kelime seciliKelime = (Kelime)lstKelimeler.SelectedItem;
                seciliKelime.Sozcuk = txtSozcuk.Text;
                seciliKelime.SozcukAnlami = txtAnlam.Text;
                seciliKelime.ResimYolu = Yer;
                new KelimeRepo().Update();
                MessageBox.Show("Kelime güncelleme işlemi başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Kelime güncelleme işlemi başarısız");

            }
            KelimeleriGetir();
            
        }
    }
}
