using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.FileDTO
{
    public class UploadFileDTO
    {
        public string ProductId { get; set; }
        public IFormFileCollection? FormFileCollection { get; set; }
    }
}
