using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Baskets.CreateBasketItem
{
    public class CreateBasketItemCommandValidator: AbstractValidator<CreateBasketItemCommandRequest>
    {
        public CreateBasketItemCommandValidator()
        {
            RuleFor(bi => bi.Quantity)
                .NotEmpty()
                .WithMessage("Seçilen ürünün adedi girilmek zorundadır")
                .GreaterThan(0)
                .WithMessage("Seçilen ürünün adedi 0 dan fazla olmalıdır");
        }
    }
}
