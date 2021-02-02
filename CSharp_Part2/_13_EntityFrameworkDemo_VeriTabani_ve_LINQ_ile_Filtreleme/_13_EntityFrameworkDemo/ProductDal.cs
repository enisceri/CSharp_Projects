using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EntityFrameworkDemo
{
    class ProductDal
    {
        public List<Product> getAll()
        {
            //using sayesinde GarbageCollector'u beklemeden zorla is bitince bellekten atiyor.
            using (ETradeContext context = new ETradeContext())
            {   
                return  context.Products.ToList();
            }
        }

        public List<Product> getByName(string key)
        {
            //using sayesinde GarbageCollector'u beklemeden zorla is bitince bellekten atiyor.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.ProductName.Contains(key)).ToList();
            }
        }

        public List<Product> getByUnitPrice(decimal price)
        {
            using(ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }

        public List<Product> getByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }
        public Product getById(int id)
        {
            //TEK BIR URUN ARIYORSAK  BU FONKSIYON YAZILIR.

            //using sayesinde GarbageCollector'u beklemeden zorla is bitince bellekten atiyor.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
            }
        }
        public void addProduct(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                //Ekleme islemi asagidaki gibi de olabilir.
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
             
        }
        public void updateProduct(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                //Bizim gonderdigimiz product'u veritabanindaki ile iliskilendirir.
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void deleteProduct(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
