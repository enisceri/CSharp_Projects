using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filtre vermezse tum urunleri verir.
        T GetEntity(Expression<Func<T, bool>> filter); //Burada mutlaka filtre verilecek.
        void AddEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
    }
}
