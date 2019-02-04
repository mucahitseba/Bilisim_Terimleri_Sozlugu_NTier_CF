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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            var kullanici = new KullaniciRepo().GetAll().Find(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.GizliCevap == txtCevap.Text);
            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Gizli Cevap Hatalı");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı:"+kullanici.KullaniciAdi+"\n\n"+"Şifre:"+kullanici.Sifre);
                Giris giris = new Giris();
                giris.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
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
