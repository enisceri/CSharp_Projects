using Kitaplar.Business.Abstract;
using Kitaplar.Business.Concrete;
using Kitaplar.DataAccess.Abstract;
using Kitaplar.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IKategoriService>().To<KategoriManager>().InSingletonScope();
            Bind<IKitapService>().To<KitapManager>().InSingletonScope();

            Bind<IKategoriDal>().To<EfKategoriDal>().InSingletonScope();
            Bind<IKitapDal>().To<EfKitapDal>().InSingletonScope();


        }
    }
}
