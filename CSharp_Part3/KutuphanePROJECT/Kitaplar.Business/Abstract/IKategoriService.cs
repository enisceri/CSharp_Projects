using Kitaplar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetAll();
    }
}
