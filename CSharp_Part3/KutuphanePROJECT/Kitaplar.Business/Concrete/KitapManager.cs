//VALIDATION EKLENECEK ******************************
//Delete Fonk icin try catch gerekebilir.
//_____________________________________________________

using Kitaplar.Business.Abstract;
using Kitaplar.DataAccess.Abstract;
using Kitaplar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.Business.Concrete
{
    public class KitapManager : IKitapService
    {
        private IKitapDal _kitapDal;

        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        public void Add(Kitap kitap)
        {
            _kitapDal.Add(kitap);
        }

        public void Delete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);
        }

        public List<Kitap> GetAll()
        {
            return _kitapDal.GetAll();  
        }

        public List<Kitap> GetKitaplarByKategori(int kategoriId)
        {
            return _kitapDal.GetAll(p => p.KategoriId == kategoriId);
        }

        public List<Kitap> GetKitaplarByKitapAd(string kitapAd)
        {
            return _kitapDal.GetAll(p => p.KitapAd.ToLower().Contains(kitapAd.ToLower()));
        }

        public void Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);
        }
    }
}
