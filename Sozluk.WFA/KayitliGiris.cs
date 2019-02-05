using Sozluk.BLL.Repository;
using Sozluk.MODELS.Entities;
using Sozluk.MODELS.ViewModels;
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
    public partial class KayitliGiris : Form
    {
        public KayitliGiris()
        {
            InitializeComponent();
        }



        private void KayitliGiris_Load(object sender, EventArgs e)
        {
            KelimeleriGetir();
        }

        private void KelimeleriGetir()
        {
            lstKelimeler.DataSource = new KelimeRepo().GetAll().ToList();
        }

        private void lstKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kelime=lstKelimeler.SelectedItem as Kelime;
            txtAnlam.Text = new KelimeRepo().GetById(kelime.KelimeId).SozcukAnlami.ToString();
            pbResim.Image = Image.FromFile(new KelimeRepo().GetById(kelime.KelimeId).ResimYolu);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void btnCikis_Click(object sender, EventArgs e)
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

        private void btnIslemSecim_Click(object sender, EventArgs e)
        {
            IslemSecim islemSecim = new IslemSecim();
            islemSecim.Show();
            this.Hide();
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
