using Applicaiton.Services.FileService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Commands.ImageFiles.DeleteImageFile
{
    public class DeleteImageFileCommandHandler : IRequestHandler<DeleteImageFileCommandRequest, DeleteImageFileCommandResponse>
    {
        private readonly IFileService _fileService;

        public DeleteImageFileCommandHandler(IFileService fileService)
        {
            _fileService = fileService;
        }

        public async Task<DeleteImageFileCommandResponse> Handle(DeleteImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            await _fileService.DeleteFileAsync(new()
            {
                ImageId = request.ImageId,
            });

            return new();
        }
    }
}
