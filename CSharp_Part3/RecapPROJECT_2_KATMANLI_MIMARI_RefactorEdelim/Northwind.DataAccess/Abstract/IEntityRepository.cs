using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtre vermezse tum urunleri verir.
        T GetProduct(Expression<Func<T,bool>> filter); //Burada mutlaka filtre verilecek.
        void AddProduct(T entity);
        void UpdateProduct(T entity);
        void DeleteProduct(T entity);
    }
}
