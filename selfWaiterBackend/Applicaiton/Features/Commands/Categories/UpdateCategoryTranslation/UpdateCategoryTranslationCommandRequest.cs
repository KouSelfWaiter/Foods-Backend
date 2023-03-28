using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.UpdateCategoryTranslation
{
    public class UpdateCategoryTranslationCommandRequest: IRequest<UpdateCategoryTranslationCommandResponse>
    {
        public int TranslationCode { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
    }
}
