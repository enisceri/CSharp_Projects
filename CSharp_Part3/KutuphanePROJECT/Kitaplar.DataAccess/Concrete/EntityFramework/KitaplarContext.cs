using Kitaplar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.DataAccess.Concrete.EntityFramework
{
    public class KitaplarContext:DbContext
    {
        public DbSet<Kitap> EvKutuphane { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
