using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_GenericSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Amasya");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
           
            parametrelerVer("Istanbul", "Ankara", "Eskisehir");

            Console.Read();
        }

        static void parametrelerVer(params string[] sehirler)
        {
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);            
        }
    }

    class Product
    {

    }

    class Customer
    {

    }
    interface IRepository<T>
    {
        List<T> GetAll();

        T Get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }

    interface IProductDal:IRepository<Product>
    {

    }

    interface ICustomerDal:IRepository<Customer>
    {
            
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
