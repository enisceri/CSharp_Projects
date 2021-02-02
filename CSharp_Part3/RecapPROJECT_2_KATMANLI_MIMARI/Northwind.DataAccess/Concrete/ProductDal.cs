using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }
        public Product GetProduct(int id)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }
        public void AddProduct(Product product)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            //YAZILACAK
        }
        public void DeleteProduct(Product product)
        {

        }
    }
}
