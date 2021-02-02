using Kitaplar.DataAccess.Abstract;
using Kitaplar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal:EfEntityRepositoryBase<Kategori,KitaplarContext>, IKategoriDal
    {
    }
}
