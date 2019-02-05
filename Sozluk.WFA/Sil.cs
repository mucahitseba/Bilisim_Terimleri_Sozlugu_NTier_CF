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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }


        private void Sil_Load(object sender, EventArgs e)
        {
            KelimeleriGetir();
        }

        private void KelimeleriGetir()
        {
            lstKelimeler.DataSource = new KelimeRepo().GetAll().ToList();
        }

        private void lstKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kelime = lstKelimeler.SelectedItem as Kelime;
            txtSozcuk.Text = kelime.Sozcuk;
            txtAnlam.Text = new KelimeRepo().GetById(kelime.KelimeId).SozcukAnlami.ToString();
            pbResim.Image = Image.FromFile(new KelimeRepo().GetById(kelime.KelimeId).ResimYolu);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKelimeler.SelectedItem == null) return;
            try
            {
                Kelime seciliKelime = (Kelime)lstKelimeler.SelectedItem;
                new KelimeRepo().Delete(seciliKelime);
                MessageBox.Show($"{seciliKelime.Sozcuk} isimli kelime silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi başarısız.");
            }
            KelimeleriGetir();
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            IslemSecim islemSecim = new IslemSecim();
            islemSecim.Show();
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

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            List<Kelime> kelimeler = new List<Kelime>();
            new KelimeRepo().Queryable().Where(x => x.Sozcuk.ToLower().Contains(ara)).ToList().ForEach(x => kelimeler.Add(new Kelime()
            {
                Sozcuk = x.Sozcuk
            }));
            lstKelimeler.DataSource = kelimeler;
        }
    }
}
