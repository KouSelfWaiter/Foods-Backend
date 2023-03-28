using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.CreateCategoryTranslation
{
    public class CreateCategoryTranslationCommandValidator: AbstractValidator<CreateCategoryTranslationCommandRequest>
    {
        public CreateCategoryTranslationCommandValidator()
        {
            RuleFor(ct => ct.Name)
                .NotEmpty()
                .WithMessage("Lütfen kategori ismini giriniz")
                .MinimumLength(2)
                .WithMessage("Kategori ismi 2 karakterden fazla olmalıdır");
        }
    }
}
