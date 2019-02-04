using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozluk.MODELS.Entities
{
    [Table("Kelimeler")]
    public class Kelime
    {
        [Key]
        public int KelimeId { get; set; }
        [Required]
        public string Sozcuk { get; set; }
        [Required]
        public string SozcukAnlami { get; set; }
        public string ResimYolu { get; set; }
        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici kullanici { get; set; }


    }
}
