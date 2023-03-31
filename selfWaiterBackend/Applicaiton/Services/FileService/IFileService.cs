using Applicaiton.DTOs.FileDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.FileService
{
    public interface IFileService
    {
        Task UploadFilesAsync(UploadFileDTO uploadFileDTO);
        Task DeleteFileAsync(DeleteFileDTO deleteFileDTO);
    }
}
