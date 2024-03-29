﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.CreateProduct
{
    public class CreateProductCommandRequest: IRequest<CreateProductCommandResponse>
    {
        public int TranslationCode { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}
