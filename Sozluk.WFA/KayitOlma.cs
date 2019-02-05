using Sozluk.BLL.Repository;
using Sozluk.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozluk.WFA
{
    public partial class KayitOlma : Form
    {
        public KayitOlma()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {

                new KullaniciRepo().Insert(new Kullanici()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    GizliCevap = txtCevap.Text,
                    Meslek = txtMeslek.Text,
                    DogumTarihi = dtDogumTarihi.Value,
                    KullaniciAdi = txtAd.Text.Substring(0, 2) + txtSoyad.Text.Substring(0, 2) + txtMeslek.Text.Substring(0, 2),
                    Sifre=(txtSoyad.Text[1]+txtAd.Text[2]+txtMeslek.Text[1]+txtCevap.Text.Substring(0,2))
                });
                MessageBox.Show("Kayıt Başarılı");
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
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
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
