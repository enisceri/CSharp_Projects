using Library.DataAccess.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntityFramework
{
    public class EfReaderDal : EfEntityRepositoryBase<Reader, LibraryContext>, IReaderDal
    {
    }
}
