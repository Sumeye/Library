using FluentValidation;
using FluentValidation.Validators;
using Library.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Validations
{
    public class BooksValidator : AbstractValidator<BooksSaveDto>
    {
        public BooksValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.Author).NotNull().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.CategoryId).NotNull().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.Name).NotNull().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.ISBN).MaximumLength(13).WithMessage("Lütfen en yüksek 13 karakterli bir değer giriniz");

            RuleFor(x => x.ISBN)
                .Custom((x, context) =>
                {
                    if ((!(int.TryParse(x, out int value)) || value < 0))
                    {
                        context.AddFailure($"Lütfen Numeric ve 0 dan büyük bir değer giriniz  ");
                    }
                });

        }



    }
}
