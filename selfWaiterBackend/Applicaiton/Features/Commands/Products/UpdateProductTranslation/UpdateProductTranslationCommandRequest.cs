using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Products.UpdateProductTranslation
{
    public class UpdateProductTranslationCommandRequest: IRequest<UpdateProductTranslationCommandResponse>
    {
        public int TranslationCode { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ProductId { get; set; }
    }
}
