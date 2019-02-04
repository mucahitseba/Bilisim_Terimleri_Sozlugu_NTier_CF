using Sozluk.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozluk.DAL
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConSozluk")
        {

        }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Kelime> Kelimeler { get; set; }
    }
}
