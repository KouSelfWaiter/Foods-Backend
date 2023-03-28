using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.UpdateProductTranslation
{
    public class UpdateProductTranslationCommandValidator: AbstractValidator<UpdateProductTranslationCommandRequest>
    {
        public UpdateProductTranslationCommandValidator()
        {
            RuleFor(pt => pt.Name)
                .NotEmpty()
                .WithMessage("Lütfen ürün ismini giriniz")
                .MinimumLength(2)
                .WithMessage("Ürün ismi 2 karakterden fazla olmalıdır");
            RuleFor(pt => pt.Description)
                .MinimumLength(2)
                .WithMessage("Ürün açıklaması 2 karakterden fazla olmalıdır");
        }
    }
}
