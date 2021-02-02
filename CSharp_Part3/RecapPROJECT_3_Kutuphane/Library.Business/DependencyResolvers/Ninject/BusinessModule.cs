using Library.Business.Abstract;
using Library.Business.Concrete;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<IBookService>().To<BookManager>().InSingletonScope();

            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();
        }
    }
}
