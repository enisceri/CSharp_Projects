using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.ValidationRules.FluentValidation
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {            
            RuleFor(p => p.BookName).NotEmpty().WithMessage("Lütfen kitap adını yazınız.");
            RuleFor(p => p.AuthorName).NotEmpty().WithMessage("Lütfen yazar adını yazınız.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Lütfen kategori seçiniz");
            RuleFor(p => p.PrintYear).NotEmpty().WithMessage("Lütfen basım yılını giriniz.");
            RuleFor(p => p.NumberOfPages).NotEmpty().WithMessage("Lütfen sayfa sayısını giriniz.");
            RuleFor(p => p.Publisher).NotEmpty().WithMessage("Lütfen yayın evini giriniz.");
        }



    }
}
