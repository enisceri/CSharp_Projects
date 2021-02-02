using Kitaplar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.DataAccess.Abstract
{
    public interface IKitapDal:IEntityRepository<Kitap>
    {
    }
}
