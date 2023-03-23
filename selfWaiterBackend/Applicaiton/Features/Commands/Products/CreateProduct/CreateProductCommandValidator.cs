using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandValidator: AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductCommandValidator()
        {
            //rules
        }
    }
}
