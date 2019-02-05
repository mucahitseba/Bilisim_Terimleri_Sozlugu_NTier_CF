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
    public partial class IslemSecim : Form
    {
        public IslemSecim()
        {
            InitializeComponent();
        }

       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil sil = new Sil();
            sil.Show();
            this.Hide();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Duzenle duzenle = new Duzenle();
            duzenle.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            KayitliGiris kayitliGiris = new KayitliGiris();
            kayitliGiris.Show();
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
