using Applicaiton.Services.FileService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.ImageFiles.UploadImageFile
{
    public class UploadImageFileCommandHandler : IRequestHandler<UploadImageFileCommandRequest, UploadImageFileCommandResponse>
    {
        private readonly IFileService _fileService;
        public UploadImageFileCommandHandler(IFileService fileService)
        {
            _fileService = fileService;
        }

        public async Task<UploadImageFileCommandResponse> Handle(UploadImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            await _fileService.UploadFilesAsync(new() { ProductId = request.ProductId, FormFileCollection = request.FormFileCollection });
            return new UploadImageFileCommandResponse();
        }
    }
}
