using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }



        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    CategoryId = 1,
                    ProductName = "Laptop",
                    QuantityPerUnit = "1 in a box",
                    UnitPrice = 6000,
                    UnitsInStock = 5

                },

                new Product
                {
                    ProductId = 2,
                    CategoryId = 1,
                    ProductName = "Playstation 5",
                    QuantityPerUnit = "2 Joystick, a box and the cables",
                    UnitPrice = 8000,
                    UnitsInStock = 8

                }


            };
            return products;
        }



        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

    }
}
