using Sozluk.BLL.Repository;
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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
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

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayitOlma kayitOlma = new KayitOlma();
            kayitOlma.Show();
            this.Hide();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = new KullaniciRepo().GetAll().Find(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text);
            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı Adı veya şifre Hatalı");
            }
            else
            {
                kullanici.AktifMi = true;
                new KullaniciRepo().Update();
                KayitliGiris kayitliGiris = new KayitliGiris();
                kayitliGiris.Show();
                this.Hide();
            }
        }
    }
}
