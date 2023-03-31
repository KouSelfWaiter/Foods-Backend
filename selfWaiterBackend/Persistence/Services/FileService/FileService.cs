using Applicaiton.DTOs.FileDTO;
using Applicaiton.Services.FileService;
using Applicaiton.Services.Repositories.ImageFileRepository;
using Applicaiton.Services.Repositories.ProductRepository;
using Applicaiton.Services.Storage;
using Domain.Entities.Files;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.FileService
{
    public class FileService : IFileService
    {
        private readonly IProductReadRepository _productRepository;
        private readonly IImageFileWriteRepository _imageFileWriteRepository;
        private readonly IImageFileReadRepository _imageFileReadRepository;
        private readonly IStorageService _storageService;
        public FileService(IProductReadRepository productRepository, IImageFileWriteRepository imageFileWriteRepository, IStorageService storageService, IImageFileReadRepository imageFileReadRepository)
        {
            _productRepository = productRepository;
            _imageFileWriteRepository = imageFileWriteRepository;
            _storageService = storageService;
            _imageFileReadRepository = imageFileReadRepository;
        }

        public async Task DeleteFileAsync(DeleteFileDTO deleteFileDTO)
        {
            ImageFile imageFile = await _imageFileReadRepository.GetByIdAsync(deleteFileDTO.ImageId);
            if (imageFile == null)
                throw new Exception("Ressim Bulunamadı");

            await _storageService.DeleteAsync("product", imageFile.FileName);

            _imageFileWriteRepository.Remove(imageFile);

            _ = await _imageFileWriteRepository.SaveAsync();
        }

        public async Task UploadFilesAsync(UploadFileDTO uploadFileDTO)
        {
            Product product = await _productRepository.GetByIdAsync(uploadFileDTO.ProductId);
            if (product == null)
                throw new Exception("Ürün bulunamadı");

            var datas = await _storageService.UploadAsync("product", uploadFileDTO.FormFileCollection);
            // datas = (filename, pathOrContainerName)

            await _imageFileWriteRepository.AddRangeAsync(datas.Select(d => new ImageFile
            {
                FileName = d.fileName,
                Path = d.pathOrContainerName,
                Storage = _storageService.StorageName,
                Products = new List<Product>() { product },
                IsActive = true
            }).ToList());

            await _imageFileWriteRepository.SaveAsync();
        }
    }
}
