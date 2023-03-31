using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandValidator: AbstractValidator<CreateOrderCommandRequest>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(o => o.Note)
                .MinimumLength(3)
                .WithMessage("Not uzunlugu minumum 3 karakter olmalıdır");

        }
    }
}
