using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozluk.MODELS.Entities
{
    [Table("Kullanicilar")]
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        [StringLength(20)]
        [Required]
        public string Ad { get; set; }
        [StringLength(20)]
        [Required]
        public string Soyad { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        public string Meslek { get; set; }
        [Required]
        public string GizliCevap { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool? AktifMi { get; set; } = false;
        public virtual ICollection<Kelime> Kelimeler { get; set; } = new HashSet<Kelime>();
    }
}
