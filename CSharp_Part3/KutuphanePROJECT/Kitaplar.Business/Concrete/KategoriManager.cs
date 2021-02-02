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
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public List<Kategori> GetAll()
        {
            return _kategoriDal.GetAll();   
        }
    }
}
