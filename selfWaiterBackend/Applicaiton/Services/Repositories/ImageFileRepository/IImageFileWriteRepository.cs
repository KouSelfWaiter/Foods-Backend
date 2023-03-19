using Core.Persistence.Repositories;
using Domain.Entities.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.Repositories.ImageFileRepository
{
    public interface IImageFileWriteRepository: IWriteRepository<ImageFile>
    {
    }
}
