using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.CreateCategory
{
    public class CreateCategoryCommandValidator: AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Lütfen kategori ismi giriniz")
                .MinimumLength(2)
                .WithMessage("Kategori ismi minumum 2 karakter olamalıdır");
        }
    }
}
