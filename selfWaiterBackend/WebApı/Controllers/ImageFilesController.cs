﻿using Applicaiton.Features.Commands.ImageFiles.DeleteImageFile;
using Applicaiton.Features.Commands.ImageFiles.UploadImageFile;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageFilesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImageFilesController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UploadImageFile([FromQuery] UploadImageFileCommandRequest uploadImageFileCommandRequest)
        {
            // dosyaları request parametresinden çekecegiz
            uploadImageFileCommandRequest.FormFileCollection = Request.Form.Files;

            UploadImageFileCommandResponse response = await _mediator.Send(uploadImageFileCommandRequest);

            return Ok(response);
        }

        [HttpDelete("{ImageId}")]
        [Authorize]
        public async Task<IActionResult> DeleteImaeFile([FromRoute] DeleteImageFileCommandRequest deleteImageFileCommandRequest)
        {
     
            DeleteImageFileCommandResponse response = await _mediator.Send(deleteImageFileCommandRequest);

            return Ok(response);

        }
    }
}
