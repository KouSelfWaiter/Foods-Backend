using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.ImageFiles.UploadImageFile
{
    public class UploadImageFileCommandRequest : IRequest<UploadImageFileCommandResponse>
    {
        public string ProductId { get; set; }
        public IFormFileCollection? FormFileCollection { get; set; }
    }
}
