using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandValidator: AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Lütfen ürün adını giriniz")
                .MinimumLength(2)
                .WithMessage("Ürün adı minumum 2 karakter olmalıdır");
            RuleFor(p => p.Description)
                .MinimumLength(3)
                .WithMessage("Ürün açıklması minumum 3 karakter olmalıdır");
            RuleFor(p => p.Price)
                .GreaterThan(0)
                .WithMessage("Ürün fiyatı 0 dan büyük olmalıdır");
        }
    }
}
