using Applicaiton.Services.Repositories.ImageFileRepository;
using Domain.Entities.Files;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ImageFileRepository
{
    public class ImageFileWriteRepository : WriteRepository<ImageFile>, IImageFileWriteRepository
    {
        public ImageFileWriteRepository(SelfWaiterDbContext context) : base(context)
        {
        }
    }
}
