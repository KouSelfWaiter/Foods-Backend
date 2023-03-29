using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.UpdateBasketItem
{
    public class UpdateBasketItemCommandValidator: AbstractValidator<UpdateBasketItemCommandRequest>
    {
        public UpdateBasketItemCommandValidator()
        {
            RuleFor(bi => bi.Quantity)
                .NotEmpty()
                .WithMessage("Ürün miktarı girmek zorunludur.")
                .GreaterThan(0)
                .WithMessage("Ürün miktarı 0 dan büyük olmalıdır.");
        }
    }
}
