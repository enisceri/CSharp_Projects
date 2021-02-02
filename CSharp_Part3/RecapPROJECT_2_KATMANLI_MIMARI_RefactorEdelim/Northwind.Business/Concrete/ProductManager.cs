﻿using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ProductValidation(product);
            _productDal.AddProduct(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.DeleteProduct(product);

            }
            catch (Exception)
            {
                throw new Exception("Silme gerçekleşemedi");    
            }
        }

        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string searchKey)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(searchKey.ToLower()));
        }

        public void Update(Product product)
        {
            ProductValidation(product);
            _productDal.UpdateProduct(product);     
        }

        private void ProductValidation(Product product)
        {   //DOGRULAMA FONKSIYONU
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);

            if(result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            
        }
    }
}
