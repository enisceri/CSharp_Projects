using Kitaplar.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.Entities.Concrete
{
    public class Kitap:IEntity
    {
        public int KitapId { get; set; }
        public int KategoriId { get; set; }
        public string KitapAd { get; set; }
        public string YazarAdSoyad { get; set; }
        public int Sayfa { get; set; }
        public int MyProperty { get; set; }
        public string YayinEvi { get; set; }
        public int BaskiNo { get; set; }
        public int CiltNo { get; set; }



    }
}
