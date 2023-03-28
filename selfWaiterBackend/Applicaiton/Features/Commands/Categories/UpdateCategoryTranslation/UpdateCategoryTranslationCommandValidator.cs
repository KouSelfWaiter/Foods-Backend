using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.UpdateCategoryTranslation
{
    public class UpdateCategoryTranslationCommandValidator: AbstractValidator<UpdateCategoryTranslationCommandRequest>
    {
        public UpdateCategoryTranslationCommandValidator()
        {
            RuleFor(ct => ct.Name)
               .NotEmpty()
               .WithMessage("Lütfen kategori ismini giriniz")
               .MinimumLength(2)
               .WithMessage("Kategori ismi 2 karakterden fazla olmalıdır");
        }
    }
}
