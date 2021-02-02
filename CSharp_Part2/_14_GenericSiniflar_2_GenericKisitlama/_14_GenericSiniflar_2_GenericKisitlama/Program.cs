using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_GenericSiniflar_2_GenericKisitlama
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IEntity
    {

    }

    class Product:IEntity
    {

    }

    class Customer:IEntity
    {

    }

    class ProductDal
    {

    }

    class CustomerDal
    {

    }

    interface IRepository<T> where T:  class, IEntity, new()//class dedik cunku referans tip olsun istiyoruz.
        //string de bir referans tiptir. Eger sadece deger tipler istersek struct yazmaliyiz.
        //IEntity yazdik->IEntity olanlari sadece parametre verebiliriz.
        //new() -> Sadece new'lenebilen seyleri yazabilir.
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }

    interface ICustomerDal:IRepository<Customer>
    {

    }
    interface IProductDal
    {

    }
}
