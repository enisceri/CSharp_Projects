using Kitaplar.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.Entities.Concrete
{
    public class Kategori:IEntity
    {
        public int KategoriId { get; set; }
        public int KategoriAd { get; set; }

    }
}
