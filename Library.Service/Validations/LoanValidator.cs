using FluentValidation;
using Library.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Validations
{
    public class LoanValidator : AbstractValidator<LoanDto>
    {
        public LoanValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(x => x.DeliveryDate).NotEmpty().WithMessage("Lütfen bu alanı boş geçmeyiniz");
            RuleFor(m => m.ReturnDate).GreaterThan(m => m.DeliveryDate).WithMessage("Getirme Tarihi kitabın teslim alındığı tarihten büyük olmalıdır.");
        }
    }

}
    