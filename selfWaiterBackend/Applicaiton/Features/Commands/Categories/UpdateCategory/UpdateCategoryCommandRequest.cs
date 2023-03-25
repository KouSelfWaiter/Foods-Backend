using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.Categories.UpdateCategory
{
    public class UpdateCategoryCommandRequest: IRequest<UpdateCategoryCommandResponse>
    {
        public string Id { get; set; }
        public int TranslationCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
