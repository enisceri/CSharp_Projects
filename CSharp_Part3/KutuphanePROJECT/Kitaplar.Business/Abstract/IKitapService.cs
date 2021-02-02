using Kitaplar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.Business.Abstract
{
    public interface IKitapService
    {
        List<Kitap> GetAll();
        List<Kitap> GetKitaplarByKategori(int kategoriId);
        List<Kitap> GetKitaplarByKitapAd(string kitapAd);
        void Add(Kitap kitap);
        void Delete(Kitap kitap);
        void Update(Kitap kitap);

    }
}
