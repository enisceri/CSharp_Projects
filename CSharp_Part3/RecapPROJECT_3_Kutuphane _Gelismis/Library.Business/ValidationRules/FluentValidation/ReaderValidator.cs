using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.ValidationRules.FluentValidation
{
    public class ReaderValidator:AbstractValidator<Reader>
    {
        public ReaderValidator()
        {
            RuleFor(p => p.BookName).NotEmpty().WithMessage("Lütfen kitap adını yazınız.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Lütfen kategori seçiniz.");
            RuleFor(p => p.BookId).NotEmpty().WithMessage("Lütfen kitap numarasını seçiniz.");
            RuleFor(p => p.UserId).NotEmpty().WithMessage("Lütfen kullanıcı seçiniz.");



        }
    }
}
