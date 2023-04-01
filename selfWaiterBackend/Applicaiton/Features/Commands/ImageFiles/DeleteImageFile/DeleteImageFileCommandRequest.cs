using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.ImageFiles.DeleteImageFile
{
    public class DeleteImageFileCommandRequest: IRequest<DeleteImageFileCommandResponse>
    {
        public string ImageId { get; set; }
    }
}
