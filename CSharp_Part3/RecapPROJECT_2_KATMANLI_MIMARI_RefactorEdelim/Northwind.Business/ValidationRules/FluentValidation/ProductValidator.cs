using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithErrorCode("404 NOT FOUND").WithMessage("Ürün adı boş geçilemez.").WithErrorCode("ÜRÜN ADI BOŞ"); //Urun ismi girilmeli kurali.
            RuleFor(p => p.CategoryId).NotEmpty(); //CategoryId bos olmamali, girilmeli.
            RuleFor(p => p.UnitPrice).NotEmpty(); //UnitPrice bos olmamali, girilmeli.
            RuleFor(p => p.QuantityPerUnit).NotEmpty(); //QuantityPerUnit bos olmamali, girilmeli.
            RuleFor(p => p.UnitsInStock).NotEmpty(); //UnitsInStock bos olmamali, girilmeli.

            RuleFor(p => p.UnitPrice).GreaterThan(0);//Fiyat 0 TL'den fazla olmali.
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);//Stok en az 0 olabilir.
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);//kategori 2 iken fiyat en az 10 TL

            //Örnek kural
            RuleFor(p => p.UnitsInStock).Must(UnitStockRuleForCategoryIdEqualThree).When(p =>p.CategoryId == 3).WithMessage("Kategori ID'si 3 olan ürünlerin stoğu en az 5 olmalıdır.");





        }

        private bool UnitStockRuleForCategoryIdEqualThree(short arg)
        {
            return arg > 5 ? true : false;
        }
    }
}
