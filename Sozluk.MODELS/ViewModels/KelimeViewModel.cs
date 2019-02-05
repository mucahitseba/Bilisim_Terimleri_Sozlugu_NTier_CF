using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozluk.MODELS.ViewModels
{
    public class KelimeViewModel
    {
        public int KelimeId { get; set; }
        public string Sozcuk { get; set; }
        public string SozcukAnlami { get; set; }
        public string ResimYolu { get; set; }
        public int KullaniciId { get; set; }

    }
}
